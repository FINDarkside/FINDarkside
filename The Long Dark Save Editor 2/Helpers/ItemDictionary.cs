﻿using System.Collections.Generic;
using System.Diagnostics;
using The_Long_Dark_Save_Editor_2.Game_data;

namespace The_Long_Dark_Save_Editor_2.Helpers
{

	public class ItemInfo
	{
		public ItemCategory category;
		public string defaultSerialized;
		public bool hide;
		public bool preventDelete;
	}


	public static class ItemDictionary
	{
		public static Dictionary<string, ItemInfo> itemInfo = new Dictionary<string, ItemInfo>();

		private static void AddItemInfo(string itemID, ItemCategory category, string defaultSerialized, bool hide = false, bool preventDelete = false)
		{
			itemInfo.Add(itemID, new ItemInfo { category = category, defaultSerialized = defaultSerialized, hide = hide , preventDelete = preventDelete});
		}

		public static string GetInGameName(string name)
		{
			return Properties.Resources.ResourceManager.GetString(name, System.Globalization.CultureInfo.CurrentUICulture) ?? 
				Properties.Resources.ResourceManager.GetString(name, System.Globalization.CultureInfo.InvariantCulture) ?? 
				name;
		}

		public static ItemCategory GetCategory(string name)
		{
			if (itemInfo.ContainsKey(name))
				return itemInfo[name].category;
			return ItemCategory.Unknown;
		}

		static ItemDictionary()
		{
			AddItemInfo("GEAR_BottleAntibiotics", ItemCategory.FirstAid, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_BottleHydrogenPeroxide", ItemCategory.FirstAid, @"{""LiquidItem"": {""m_LiquidLitersProxy"": 1}}");
			AddItemInfo("GEAR_BottlePainKillers", ItemCategory.FirstAid, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_HeavyBandage", ItemCategory.FirstAid, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_OldMansBeardDressing", ItemCategory.FirstAid, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_WaterPurificationTablets", ItemCategory.FirstAid, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_EmergencyStim", ItemCategory.FirstAid, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");

			AddItemInfo("GEAR_Balaclava", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_BaseBallCap", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_BasicBoots", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_BasicGloves", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_BasicShoes", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_BasicWinterCoat", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_BasicWoolHat", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_BasicWoolScarf", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_BearSkinCoat", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_CargoPants", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_CombatBoots", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_CombatPants", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_CottonHoodie", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_CottonScarf", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_CottonShirt", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_CottonSocks", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_CowichanSweater", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_DeerSkinBoots", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_DeerSkinPants", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_DownParka", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_DownSkiJacket", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_DownVest", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_EarMuffs", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_FisherManSweater", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_FleeceMittens", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_FleeceSweater", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_Gauntlets", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_HeavyParka", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_HeavyWoolSweater", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_InsulatedBoots", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_InsulatedPants", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_InsulatedVest", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_Jeans", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_LeatherShoes", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_LightParka", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_LongUnderwear", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_LongUnderwearWool", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_MackinawJacket", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_MilitaryParka", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_Mittens", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_MuklukBoots", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_PlaidShirt", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_PremiumWinterCoat", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_QualityWinterCoat", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_RabbitSkinMittens", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_SkiBoots", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_SkiGloves", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_SkiJacket", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_TeeShirt", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_Toque", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_WolfSkinCape", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_WoolShirt", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_WoolSocks", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_WoolSweater", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_WoolWrap", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_WoolWrapCap", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_WorkBoots", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_WorkGloves", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_WorkPants", ItemCategory.Clothing, @"{""ClothingItem"": {}}");
			AddItemInfo("GEAR_ClimbingSocks", ItemCategory.Clothing, @"{""ClothingItem"": {}}");

			AddItemInfo("GEAR_BeefJerky", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 350}}");
			AddItemInfo("GEAR_CandyBar", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}}");
			AddItemInfo("GEAR_CannedBeans", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 600}, ""SmashableItem"": {}}");
			AddItemInfo("GEAR_CannedSardines", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 300}, ""SmashableItem"": {}}");
			AddItemInfo("GEAR_CattailStalk", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 150}, ""StackableItem"":{""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_CoffeeCup", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 100}}");
			AddItemInfo("GEAR_CoffeeTin", ItemCategory.Food, @"{""StackableItem"":{""m_UnitsProxy"": 6}}");
			AddItemInfo("GEAR_CondensedMilk", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 750}}");
			AddItemInfo("GEAR_CookedLakeWhiteFish", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_CookedMeatBear", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_CookedMeatDeer", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_CookedMeatRabbit", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_CookedMeatWolf", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_CookedRainbowTrout", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_CookedSmallMouthBass", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_Crackers", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 600}}");
			AddItemInfo("GEAR_DogFood", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 500}, ""SmashableItem"": {}}");
			AddItemInfo("GEAR_EnergyBar", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 500}}");
			AddItemInfo("GEAR_GranolaBar", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 300}}");
			AddItemInfo("GEAR_GreenTeaCup", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 100}}");
			AddItemInfo("GEAR_GreenTeaPackage", ItemCategory.Food, @"{""StackableItem"":{""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_MRE", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 1750}}");
			AddItemInfo("GEAR_PeanutButter", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 900}}");
			AddItemInfo("GEAR_PinnacleCanPeaches", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 450}, ""SmashableItem"": {}}");
			AddItemInfo("GEAR_RawCohoSalmon", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_RawLakeWhiteFish", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_RawMeatBear", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_RawMeatDeer", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_RawMeatRabbit", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_RawMeatWolf", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_RawRainbowTrout", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_RawSmallMouthBass", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 200}, WeightKG: 1}");
			AddItemInfo("GEAR_ReishiTea", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 100}}");
			AddItemInfo("GEAR_RoseHipTea", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 100}}");
			AddItemInfo("GEAR_Soda", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 250}}");
			AddItemInfo("GEAR_SodaGrape", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 250}}");
			AddItemInfo("GEAR_SodaOrange", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 250}}");
			AddItemInfo("GEAR_TomatoSoupCan", ItemCategory.Food, @"{""FoodItem"": {""m_CaloriesRemainingProxy"": 300}, ""SmashableItem"": {}}");
			AddItemInfo("GEAR_WaterSupplyNotPotable", ItemCategory.Food, @"{""WaterSupply"":{""m_VolumeProxy"": 1}}", true);
			AddItemInfo("GEAR_WaterSupplyPotable", ItemCategory.Food, @"{""WaterSupply"":{""m_VolumeProxy"": 1}}", true);
			//gear_bookmanual


			AddItemInfo("GEAR_Accelerant", ItemCategory.Tools, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Arrow", ItemCategory.Tools, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_ArrowShaft", ItemCategory.Tools, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_BearSkinBedRoll", ItemCategory.Tools, @"{""Bed"": {}}");
			AddItemInfo("GEAR_BedRoll", ItemCategory.Tools, @"{""Bed"": {}}");
			AddItemInfo("GEAR_Bow", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_Brand", ItemCategory.Tools, @"{""TorchItem"": {}}"); //Check!!
			AddItemInfo("GEAR_CanOpener", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_Firestriker", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_FlareA", ItemCategory.Tools, @"{""FlareItem"": {}}");
			AddItemInfo("GEAR_FlareGunAmmoSingle", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_Flaregun", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_Hacksaw", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_Hammer", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_Hatchet", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_HatchetImprovised", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_HighQualityTools", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_Hook", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_HookAndLine", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_JerrycanRusty", ItemCategory.Tools, @"{""LiquidItem"": {""m_LiquidLitersProxy"": 1}}");
			AddItemInfo("GEAR_KeroseneLampB", ItemCategory.Tools, @"{""KeroseneLampItem"": {""m_CurrentFuelLitersProxy"": 1}}");
			AddItemInfo("GEAR_Knife", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_KnifeImprovised", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_LampFuel", ItemCategory.Tools, @"{""LiquidItem"": {""m_LiquidLitersProxy"": 1}}");
			AddItemInfo("GEAR_Line", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_MagnifyingLens", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_NewsprintRoll", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_PackMatches", ItemCategory.Tools, @"{""StackableItem"": {""m_UnitsProxy"": 10}, ""MatchesItem"": {}}");
			AddItemInfo("GEAR_Prybar", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_Rifle", ItemCategory.Tools, @"{""WeaponItem"": {""m_RoundsInClipProxy"": 10}}");
			AddItemInfo("GEAR_RifleAmmoBox", ItemCategory.Tools, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_RifleAmmoSingle", ItemCategory.Tools, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_RifleCleaningKit", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_Rope", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_SewingKit", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_SharpeningStone", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_SimpleTools", ItemCategory.Tools, @"{}");
			AddItemInfo("GEAR_Snare", ItemCategory.Tools, @"{""SnareItem"": {}}");
			AddItemInfo("GEAR_Torch", ItemCategory.Tools, @"{""TorchItem"": {}}");
			AddItemInfo("GEAR_WoodMatches", ItemCategory.Tools, @"{""StackableItem"": {""m_UnitsProxy"": 10}, ""MatchesItem"": {}}");


			AddItemInfo("GEAR_ArrowHead", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}, ""InProgressItem"": {""m_PercentComplete"": 100}}");
			AddItemInfo("GEAR_BearHide", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}, ""EvolveItem"": {}}");
			AddItemInfo("GEAR_BearHideDried", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_BirchSapling", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}, ""EvolveItem"": {}}");
			AddItemInfo("GEAR_BirchSaplingDried", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_BookA", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_BookB", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}", true);
			AddItemInfo("GEAR_BookC", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}", true);
			AddItemInfo("GEAR_BookD", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}", true);
			AddItemInfo("GEAR_BookE", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}", true);
			AddItemInfo("GEAR_BookF", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}", true);
			AddItemInfo("GEAR_BookManual", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}", true);
			AddItemInfo("GEAR_CattailTinder", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Cloth", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Coal", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_CrowFeather", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Firelog", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Gut", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}, ""EvolveItem"": {}}");
			AddItemInfo("GEAR_GutDried", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Hardwood", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Leather", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_LeatherDried", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_LeatherHide", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_LeatherHideDried", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_MapleSapling", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}, ""EvolveItem"": {}}");
			AddItemInfo("GEAR_MapleSaplingDried", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Newsprint", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_OldMansBeardHarvested", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_RabbitPelt", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}, ""EvolveItem"": {}}");
			AddItemInfo("GEAR_RabbitPeltDried", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_ReclaimedWoodB", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_ReishiMushroom", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_RoseHip", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_ScrapMetal", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Softwood", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Stick", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Tinder", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_WolfPelt", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_WolfPeltDried", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");

			//Books
			AddItemInfo("GEAR_BookCarcassHarvesting", ItemCategory.Books, @"{""ResearchItem"": {}}");
			AddItemInfo("GEAR_BookCooking", ItemCategory.Books, @"{""ResearchItem"": {}}");
			AddItemInfo("GEAR_BookFireStarting", ItemCategory.Books, @"{""ResearchItem"": {}}");
			AddItemInfo("GEAR_BookIceFishing", ItemCategory.Books, @"{""ResearchItem"": {}}");
			AddItemInfo("GEAR_BookRifleFirearm", ItemCategory.Books, @"{""ResearchItem"": {}}");
			AddItemInfo("GEAR_BookRifleFirearmAdvanced", ItemCategory.Books, @"{""ResearchItem"": {}}");

			AddItemInfo("GEAR_ClimbersJournal", ItemCategory.Collectible, @"{}");


			AddItemInfo("GEAR_AccelerantKerosene", ItemCategory.Hidden, @"{""LiquidItem"": {""m_LiquidLitersProxy"": 1}}"); //Check!!
			AddItemInfo("GEAR_AccelerantMedium", ItemCategory.Hidden, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Boltcutters", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_CarBattery", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_CompressionBandage", ItemCategory.Hidden, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_Fireaxe", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_FishingLine", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_FlintAndSteel", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_LeatherStrips", ItemCategory.Hidden, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_PaperStack", ItemCategory.Hidden, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_PumpkinPie", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_Shovel", ItemCategory.Hidden, @"{}");

			/*
			AddItemInfo("GEAR_BloodyHammer", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_AstridBackPack", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_BookOpen", ItemCategory.Hidden, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_BowString", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_BowWood", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_ChurchHymn", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_ChurchNoteEp1", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_CollectibleNoteCommonReward", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_CollectibleNoteRareReward", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_DamCodeNote", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_DamControlRoomCodeNote", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_DamOfficeKey", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_EmergencyKitNote", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_FarmersAlmanac", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_FirstAidManual", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_HardCase", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_HikersBackPack", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_HunterJournalPage", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_KnifeScrapMetal", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_KnifeScrapMetal_Clean", ItemCategory.Materials, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_MapSnippetMt", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_MapToRailyard", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_MedicalSupplies", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_Morphine", ItemCategory.Hidden, @"{""StackableItem"": {""m_UnitsProxy"": 1}}");
			AddItemInfo("GEAR_MountainTownFarmKey", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_MountainTownFarmNote", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_MountainTownLockBoxKey", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_MountainTownMap", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_MountainTownStoreKey", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_OverpassBrochure", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_RicksJournal", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_RifleBlanks", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_RifleBullets", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_UtilitiesBill", ItemCategory.Hidden, @"{}");
			AddItemInfo("GEAR_WaterTowerNote", ItemCategory.Hidden, @"{}");*/
		}

	}
}
