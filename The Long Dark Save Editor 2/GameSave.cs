using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using The_Long_Dark_Save_Editor_2.Game_data;
using The_Long_Dark_Save_Editor_2.Helpers;

namespace The_Long_Dark_Save_Editor_2
{
    public class GameSave
    {
        public long LastSaved { get; set; }
        private DynamicSerializable<BootSaveGameFormat> dynamicBoot;
        public BootSaveGameFormat Boot { get { return dynamicBoot.Obj; } }

        private DynamicSerializable<GlobalSaveGameFormat> dynamicGlobal;
        public GlobalSaveGameFormat Global { get { return dynamicGlobal.Obj; } }

        public AfflictionsContainer Afflictions { get; set; }

        private DynamicSerializable<SlotData> dynamicSlotData;
        public SlotData SlotData { get { return dynamicSlotData.Obj; } }

        public string OriginalRegion { get; set; }
        private float[] originalPosition;

        public string path;

        public void LoadSave(string path)
        {
            this.path = path;
            string slotJson = EncryptString.Decompress(File.ReadAllBytes(path));
            dynamicSlotData = new DynamicSerializable<SlotData>(slotJson);

            var bootJson = EncryptString.Decompress(SlotData.m_Dict["boot"]);
            dynamicBoot = new DynamicSerializable<BootSaveGameFormat>(bootJson);
            OriginalRegion = Boot.m_SceneName.Value;

            var globalJson = EncryptString.Decompress(SlotData.m_Dict["global"]);
            dynamicGlobal = new DynamicSerializable<GlobalSaveGameFormat>(globalJson);

            Afflictions = new AfflictionsContainer(Global);

            var pos = Global.PlayerManager.m_SaveGamePosition;
            originalPosition = new float[] { pos[0], pos[1], pos[2] };
        }

        public void Save()
        {
            LastSaved = DateTime.Now.Ticks;
            var bootSerialized = dynamicBoot.Serialize();
            SlotData.m_Dict["boot"] = EncryptString.Compress(bootSerialized);

            // If position is changed, set z coordinate to float.infinity to avoid going under terrain
            var pos = Global.PlayerManager.m_SaveGamePosition;
            if (OriginalRegion != Boot.m_SceneName.Value || pos[0] != originalPosition[0] || pos[1] != originalPosition[1] || pos[2] != originalPosition[2])
                pos[1] = 9999999;

            Global.SceneTransition.m_SceneSaveFilenameCurrent = Boot.m_SceneName.Value;
            Global.SceneTransition.m_SceneSaveFilenameNextLoad = Boot.m_SceneName.Value;
            Global.PlayerManager.m_CheatsUsed = true;
            Afflictions.SerializeTo(Global);

            var globalSerialized = dynamicGlobal.Serialize();
            SlotData.m_Dict["global"] = EncryptString.Compress(globalSerialized);

            SlotData.m_Timestamp = DateTime.Now;
            var slotDataSerialized = dynamicSlotData.Serialize();
            File.WriteAllBytes(path, EncryptString.Compress(slotDataSerialized));
        }
    }
}
