// Project:         DetailedCityWalls mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2021 Cliffworms
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Hazelnut & Cliffworms

using System;
using UnityEngine;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Serialization;
using DaggerfallWorkshop.Game.Utility;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Utility.AssetInjection;

namespace DetailedCityWalls
{
    public class DetailedCityWallsMod : MonoBehaviour
    {
        private const string variantDaggerfall = "_daggerfall";
        private const string variantWayrest = "_wayrest";
        private const string variantSentinel = "_sentinel";
        private const string variantDwynnen = "_dwynnen";
        private const string variantAnticlere = "_anticlere";
        private const string variantTotambu = "_totambu";
        private const string variantMournoth = "_mournoth";
        private const string variantSatakalaam = "_satakalaam";
        private const string variantLainlyn = "_lainlyn";
        private const string variantKozanset = "_kozanset";
        private const string variantDragontail = "_dragontail";
        private const string variantEphesus = "_ephesus";
        private const string variantTigonus = "_tigonus";
        private const string variantAyasofya = "_ayasofya";
        private const string variantMyrkwasa = "_myrkwasa";
        private const string variantPothago = "_pothago";
        private const string variantKairou = "_kairou";
        private const string variantAbibonGora = "_abibongora";
        private const string variantAlikr = "_alikr";
        private const string variantBergama = "_bergama";
        private const string variantAntiphyllos = "_antiphyllos";
        private const string variantSantaki = "_santaki";
        private const string variantGavaudon = "_gavaudon";
        private const string variantMenevia = "_menevia";
        private const string variantWrothgaria = "_wrothgaria";
        private const string variantAlcaire = "_alcaire";
        private const string variantKoegria = "_koegria";
        private const string variantKambria = "_kambria";
        private const string variantBhoriane = "_bhoriane";
        private const string variantPhrygias = "_phrygias";
        private const string variantUrvaius = "_urvaius";
        private const string variantDaenia = "_daenia";
        private const string variantYkalon = "_ykalon";
        private const string variantNorthmoor = "_northmoor";
        private const string variantIlessanHills = "_ilessanhills";
        private const string variantShalgora = "_shalgora";
        private const string variantGlenpoint = "_glenpoint";
        private const string variantGlenumbraMoors = "_glenumbramoors";
        private const string variantTulune = "_tulune";


        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject(mod.Title);
            go.AddComponent<DetailedCityWallsMod>();
        }

        void Awake()
        {
            Debug.Log("Begin mod init: DetailedCityWalls");

            SaveLoadManager.OnLoad += SaveLoadManager_OnLoad;
            StartGameBehaviour.OnStartGame += StartGameBehaviour_OnStartGame;

            mod.IsReady = true;
            Debug.Log("Finished mod init: DetailedCityWalls");
        }


        public void StartGameBehaviour_OnStartGame(object sender, EventArgs e)
        {
            InitVariants();
        }

        void SaveLoadManager_OnLoad(SaveData_v1 saveData)
        {
            InitVariants();
        }

        void InitVariants()
        {
            // Daggerfall (1231) in region 17
            if (WorldDataVariants.GetBuildingVariant(17, 1231, "WALLAA00.RMB", 0) == null)
            {
                int locDaggerfall = WorldDataReplacement.MakeLocationKey(17, 1231);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantDaggerfall, locDaggerfall);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantDaggerfall, locDaggerfall);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantDaggerfall, locDaggerfall);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantDaggerfall, locDaggerfall);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantDaggerfall, locDaggerfall);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantDaggerfall, locDaggerfall);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantDaggerfall, locDaggerfall);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantDaggerfall, locDaggerfall);
            }
            // Wayrest (601) in region 23
            if (WorldDataVariants.GetBuildingVariant(23, 601, "WALLAA00.RMB", 0) == null)
            {
                int locWayrest = WorldDataReplacement.MakeLocationKey(23, 601);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantWayrest, locWayrest);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantWayrest, locWayrest);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantWayrest, locWayrest);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantWayrest, locWayrest);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantWayrest, locWayrest);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantWayrest, locWayrest);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantWayrest, locWayrest);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantWayrest, locWayrest);
            }            
            // Sentinel (6) in region 20
            if (WorldDataVariants.GetBuildingVariant(20, 6, "WALLAA00.RMB", 0) == null)
            {
                int locSentinel = WorldDataReplacement.MakeLocationKey(20, 6);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantSentinel, locSentinel);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantSentinel, locSentinel);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantSentinel, locSentinel);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantSentinel, locSentinel);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantSentinel, locSentinel);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantSentinel, locSentinel);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantSentinel, locSentinel);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantSentinel, locSentinel);
            }
            // Dwynnen (522) in region 5
            if (WorldDataVariants.GetBuildingVariant(5, 522, "WALLAA00.RMB", 0) == null)
            {
                int locDwynnen = WorldDataReplacement.MakeLocationKey(5, 522);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantDwynnen, locDwynnen);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantDwynnen, locDwynnen);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantDwynnen, locDwynnen);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantDwynnen, locDwynnen);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantDwynnen, locDwynnen);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantDwynnen, locDwynnen);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantDwynnen, locDwynnen);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantDwynnen, locDwynnen);
            }            
            // Anticlere (600) in region 21
            if (WorldDataVariants.GetBuildingVariant(21, 600, "WALLAA00.RMB", 0) == null)
            {
                int locAnticlere = WorldDataReplacement.MakeLocationKey(21, 600);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantAnticlere, locAnticlere);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantAnticlere, locAnticlere);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantAnticlere, locAnticlere);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantAnticlere, locAnticlere);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantAnticlere, locAnticlere);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantAnticlere, locAnticlere);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantAnticlere, locAnticlere);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantAnticlere, locAnticlere);
            }   
            // Totambu (633) in region 51
            if (WorldDataVariants.GetBuildingVariant(51, 633, "WALLAA00.RMB", 0) == null)
            {
                int locTotambu = WorldDataReplacement.MakeLocationKey(51, 633);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantTotambu, locTotambu);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantTotambu, locTotambu);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantTotambu, locTotambu);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantTotambu, locTotambu);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantTotambu, locTotambu);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantTotambu, locTotambu);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantTotambu, locTotambu);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantTotambu, locTotambu);
            }      
            // Mournoth (201) in region 52
            if (WorldDataVariants.GetBuildingVariant(52, 201, "WALLAA00.RMB", 0) == null)
            {
                int locMournoth = WorldDataReplacement.MakeLocationKey(52, 201);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantMournoth, locMournoth);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantMournoth, locMournoth);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantMournoth, locMournoth);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantMournoth, locMournoth);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantMournoth, locMournoth);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantMournoth, locMournoth);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantMournoth, locMournoth);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantMournoth, locMournoth);
            }   
            //  Satakalaam (90) in region 50
            if (WorldDataVariants.GetBuildingVariant(50, 90, "WALLAA00.RMB", 0) == null)
            {
                int locSatakalaam = WorldDataReplacement.MakeLocationKey(50, 90);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantSatakalaam, locSatakalaam);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantSatakalaam, locSatakalaam);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantSatakalaam, locSatakalaam);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantSatakalaam, locSatakalaam);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantSatakalaam, locSatakalaam);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantSatakalaam, locSatakalaam);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantSatakalaam, locSatakalaam);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantSatakalaam, locSatakalaam);
            }                
            //  Lainlyn (103) in region 22
            if (WorldDataVariants.GetBuildingVariant(22, 103, "WALLAA00.RMB", 0) == null)
            {
                int locLainlyn = WorldDataReplacement.MakeLocationKey(22, 103);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantLainlyn, locLainlyn);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantLainlyn, locLainlyn);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantLainlyn, locLainlyn);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantLainlyn, locLainlyn);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantLainlyn, locLainlyn);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantLainlyn, locLainlyn);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantLainlyn, locLainlyn);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantLainlyn, locLainlyn);
            }    
            //  Kozanset (31) in region 49
            if (WorldDataVariants.GetBuildingVariant(49, 31, "WALLAA00.RMB", 0) == null)
            {
                int locKozanset = WorldDataReplacement.MakeLocationKey(49, 31);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantKozanset, locKozanset);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantKozanset, locKozanset);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantKozanset, locKozanset);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantKozanset, locKozanset);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantKozanset, locKozanset);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantKozanset, locKozanset);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantKozanset, locKozanset);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantKozanset, locKozanset);
            } 
            //  Dragontail (853) in region 1
            if (WorldDataVariants.GetBuildingVariant(1, 853, "WALLAA00.RMB", 0) == null)
            {
                int locDragontail = WorldDataReplacement.MakeLocationKey(1, 853);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantDragontail, locDragontail);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantDragontail, locDragontail);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantDragontail, locDragontail);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantDragontail, locDragontail);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantDragontail, locDragontail);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantDragontail, locDragontail);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantDragontail, locDragontail);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantDragontail, locDragontail);
            }      
            //  Ephesus (205) in region 53
            if (WorldDataVariants.GetBuildingVariant(53, 205, "WALLAA00.RMB", 0) == null)
            {
                int locEphesus = WorldDataReplacement.MakeLocationKey(53, 205);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantEphesus, locEphesus);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantEphesus, locEphesus);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantEphesus, locEphesus);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantEphesus, locEphesus);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantEphesus, locEphesus);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantEphesus, locEphesus);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantEphesus, locEphesus);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantEphesus, locEphesus);
            }    
            //  Tigonus (54) in region 48
            if (WorldDataVariants.GetBuildingVariant(48, 54, "WALLAA00.RMB", 0) == null)
            {
                int locTigonus = WorldDataReplacement.MakeLocationKey(48, 54);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantTigonus, locTigonus);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantTigonus, locTigonus);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantTigonus, locTigonus);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantTigonus, locTigonus);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantTigonus, locTigonus);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantTigonus, locTigonus);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantTigonus, locTigonus);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantTigonus, locTigonus);
            }    
            //  Ayasofya (128) in region 47
            if (WorldDataVariants.GetBuildingVariant(47, 128, "WALLAA00.RMB", 0) == null)
            {
                int locAyasofya = WorldDataReplacement.MakeLocationKey(47, 128);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantAyasofya, locAyasofya);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantAyasofya, locAyasofya);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantAyasofya, locAyasofya);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantAyasofya, locAyasofya);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantAyasofya, locAyasofya);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantAyasofya, locAyasofya);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantAyasofya, locAyasofya);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantAyasofya, locAyasofya);
            }   
            //  Myrkwasa (57) in region 46
            if (WorldDataVariants.GetBuildingVariant(46, 57, "WALLAA00.RMB", 0) == null)
            {
                int locMyrkwasa = WorldDataReplacement.MakeLocationKey(46, 57);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantMyrkwasa, locMyrkwasa);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantMyrkwasa, locMyrkwasa);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantMyrkwasa, locMyrkwasa);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantMyrkwasa, locMyrkwasa);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantMyrkwasa, locMyrkwasa);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantMyrkwasa, locMyrkwasa);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantMyrkwasa, locMyrkwasa);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantMyrkwasa, locMyrkwasa);
            }        
            //  Pothago (6) in region 45
            if (WorldDataVariants.GetBuildingVariant(45, 6, "WALLAA00.RMB", 0) == null)
            {
                int locPothago = WorldDataReplacement.MakeLocationKey(45, 6);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantPothago, locPothago);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantPothago, locPothago);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantPothago, locPothago);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantPothago, locPothago);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantPothago, locPothago);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantPothago, locPothago);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantPothago, locPothago);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantPothago, locPothago);
            }      
            //  Kairou (97) in region 44
            if (WorldDataVariants.GetBuildingVariant(44, 97, "WALLAA00.RMB", 0) == null)
            {
                int locKairou = WorldDataReplacement.MakeLocationKey(44, 97);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantKairou, locKairou);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantKairou, locKairou);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantKairou, locKairou);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantKairou, locKairou);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantKairou, locKairou);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantKairou, locKairou);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantKairou, locKairou);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantKairou, locKairou);
            }    
            //  Abibon-Gora (78) in region 43
            if (WorldDataVariants.GetBuildingVariant(43, 78, "WALLAA00.RMB", 0) == null)
            {
                int locAbibonGora = WorldDataReplacement.MakeLocationKey(43, 78);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantAbibonGora, locAbibonGora);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantAbibonGora, locAbibonGora);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantAbibonGora, locAbibonGora);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantAbibonGora, locAbibonGora);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantAbibonGora, locAbibonGora);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantAbibonGora, locAbibonGora);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantAbibonGora, locAbibonGora);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantAbibonGora, locAbibonGora);
            }     
            //  Alik'ra (165) in region 0
            if (WorldDataVariants.GetBuildingVariant(0, 165, "WALLAA00.RMB", 0) == null)
            {
                int locAlikr = WorldDataReplacement.MakeLocationKey(0, 165);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantAlikr, locAlikr);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantAlikr, locAlikr);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantAlikr, locAlikr);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantAlikr, locAlikr);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantAlikr, locAlikr);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantAlikr, locAlikr);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantAlikr, locAlikr);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantAlikr, locAlikr);
            }                   
            //  Bergama (41) in region 56
            if (WorldDataVariants.GetBuildingVariant(56, 41, "WALLAA00.RMB", 0) == null)
            {
                int locBergama = WorldDataReplacement.MakeLocationKey(56, 41);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantBergama, locBergama);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantBergama, locBergama);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantBergama, locBergama);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantBergama, locBergama);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantBergama, locBergama);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantBergama, locBergama);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantBergama, locBergama);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantBergama, locBergama);
            }    
            //  Antiphyllos (39) in region 55
            if (WorldDataVariants.GetBuildingVariant(55, 39, "WALLAA00.RMB", 0) == null)
            {
                int locAntiphyllos = WorldDataReplacement.MakeLocationKey(55, 39);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantAntiphyllos, locAntiphyllos);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantAntiphyllos, locAntiphyllos);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantAntiphyllos, locAntiphyllos);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantAntiphyllos, locAntiphyllos);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantAntiphyllos, locAntiphyllos);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantAntiphyllos, locAntiphyllos);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantAntiphyllos, locAntiphyllos);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantAntiphyllos, locAntiphyllos);
            }   
            //  Santaki (26) in region 54
            if (WorldDataVariants.GetBuildingVariant(54, 26, "WALLAA00.RMB", 0) == null)
            {
                int locSantaki = WorldDataReplacement.MakeLocationKey(54, 26);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantSantaki, locSantaki);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantSantaki, locSantaki);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantSantaki, locSantaki);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantSantaki, locSantaki);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantSantaki, locSantaki);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantSantaki, locSantaki);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantSantaki, locSantaki);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantSantaki, locSantaki);
            }     
            //  Gavaudon (24) in region 57
            if (WorldDataVariants.GetBuildingVariant(57, 24, "WALLAA00.RMB", 0) == null)
            {
                int locGavaudon = WorldDataReplacement.MakeLocationKey(57, 24);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantGavaudon, locGavaudon);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantGavaudon, locGavaudon);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantGavaudon, locGavaudon);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantGavaudon, locGavaudon);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantGavaudon, locGavaudon);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantGavaudon, locGavaudon);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantGavaudon, locGavaudon);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantGavaudon, locGavaudon);
            }      
            //  Menevia (114) in region 33
            if (WorldDataVariants.GetBuildingVariant(33, 114, "WALLAA00.RMB", 0) == null)
            {
                int locMenevia = WorldDataReplacement.MakeLocationKey(33, 114);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantMenevia, locMenevia);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantMenevia, locMenevia);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantMenevia, locMenevia);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantMenevia, locMenevia);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantMenevia, locMenevia);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantMenevia, locMenevia);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantMenevia, locMenevia);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantMenevia, locMenevia);
            }      
            //  Wrothgaria (297) in region 16
            if (WorldDataVariants.GetBuildingVariant(16, 297, "WALLAA00.RMB", 0) == null)
            {
                int locWrothgaria = WorldDataReplacement.MakeLocationKey(16, 297);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantWrothgaria, locWrothgaria);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantWrothgaria, locWrothgaria);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantWrothgaria, locWrothgaria);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantWrothgaria, locWrothgaria);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantWrothgaria, locWrothgaria);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantWrothgaria, locWrothgaria);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantWrothgaria, locWrothgaria);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantWrothgaria, locWrothgaria);
            }   
            //  Alcaire (57) in region 34
            if (WorldDataVariants.GetBuildingVariant(34, 57, "WALLAA00.RMB", 0) == null)
            {
                int locAlcaire = WorldDataReplacement.MakeLocationKey(34, 57);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantAlcaire, locAlcaire);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantAlcaire, locAlcaire);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantAlcaire, locAlcaire);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantAlcaire, locAlcaire);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantAlcaire, locAlcaire);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantAlcaire, locAlcaire);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantAlcaire, locAlcaire);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantAlcaire, locAlcaire);
            }     
            //  Koegria (68) in region 35 
            if (WorldDataVariants.GetBuildingVariant(35, 68, "WALLAA00.RMB", 0) == null)
            {
                int locKoegria = WorldDataReplacement.MakeLocationKey(35, 68);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantKoegria, locKoegria);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantKoegria, locKoegria);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantKoegria, locKoegria);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantKoegria, locKoegria);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantKoegria, locKoegria);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantKoegria, locKoegria);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantKoegria, locKoegria);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantKoegria, locKoegria);
            }    
            //  Bhoriane (115) in region 36 
            if (WorldDataVariants.GetBuildingVariant(36, 115, "WALLAA00.RMB", 0) == null)
            {
                int locBhoriane = WorldDataReplacement.MakeLocationKey(36, 115);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantBhoriane, locBhoriane);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantBhoriane, locBhoriane);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantBhoriane, locBhoriane);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantBhoriane, locBhoriane);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantBhoriane, locBhoriane);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantBhoriane, locBhoriane);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantBhoriane, locBhoriane);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantBhoriane, locBhoriane);
            }   
            //  Kambria (70) in region 37 
            if (WorldDataVariants.GetBuildingVariant(37, 70, "WALLAA00.RMB", 0) == null)
            {
                int locKambria = WorldDataReplacement.MakeLocationKey(37, 70);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantKambria, locKambria);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantKambria, locKambria);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantKambria, locKambria);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantKambria, locKambria);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantKambria, locKambria);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantKambria, locKambria);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantKambria, locKambria);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantKambria, locKambria);
            }     
            //  Phrygias (167) in region 38
            if (WorldDataVariants.GetBuildingVariant(38, 167, "WALLAA00.RMB", 0) == null)
            {
                int locPhrygias = WorldDataReplacement.MakeLocationKey(38, 167);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantPhrygias, locPhrygias);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantPhrygias, locPhrygias);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantPhrygias, locPhrygias);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantPhrygias, locPhrygias);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantPhrygias, locPhrygias);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantPhrygias, locPhrygias);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantPhrygias, locPhrygias);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantPhrygias, locPhrygias);
            }        
            //  Urvaius (263) in region 39
            if (WorldDataVariants.GetBuildingVariant(39, 263, "WALLAA00.RMB", 0) == null)
            {
                int locUrvaius = WorldDataReplacement.MakeLocationKey(39, 263);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantUrvaius, locUrvaius);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantUrvaius, locUrvaius);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantUrvaius, locUrvaius);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantUrvaius, locUrvaius);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantUrvaius, locUrvaius);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantUrvaius, locUrvaius);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantUrvaius, locUrvaius);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantUrvaius, locUrvaius);
            }     
            //  Ykalon (357) in region 40
            if (WorldDataVariants.GetBuildingVariant(40, 357, "WALLAA00.RMB", 0) == null)
            {
                int locYkalon = WorldDataReplacement.MakeLocationKey(40, 357);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantYkalon, locYkalon);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantYkalon, locYkalon);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantYkalon, locYkalon);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantYkalon, locYkalon);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantYkalon, locYkalon);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantYkalon, locYkalon);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantYkalon, locYkalon);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantYkalon, locYkalon);
            }     
            //  Daenia (101) in region 41
            if (WorldDataVariants.GetBuildingVariant(41, 101, "WALLAA00.RMB", 0) == null)
            {
                int locDaenia = WorldDataReplacement.MakeLocationKey(41, 101);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantDaenia, locDaenia);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantDaenia, locDaenia);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantDaenia, locDaenia);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantDaenia, locDaenia);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantDaenia, locDaenia);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantDaenia, locDaenia);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantDaenia, locDaenia);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantDaenia, locDaenia);
            }  
            //  Shalgora (161) in region 42 
            if (WorldDataVariants.GetBuildingVariant(42, 161, "WALLAA00.RMB", 0) == null)
            {
                int locShalgora = WorldDataReplacement.MakeLocationKey(42, 161);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantShalgora, locShalgora);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantShalgora, locShalgora);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantShalgora, locShalgora);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantShalgora, locShalgora);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantShalgora, locShalgora);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantShalgora, locShalgora);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantShalgora, locShalgora);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantShalgora, locShalgora);
            }        
            //  Ilessan Hills (344) in region 60
            if (WorldDataVariants.GetBuildingVariant(60, 344, "WALLAA00.RMB", 0) == null)
            {
                int locIlessanHills = WorldDataReplacement.MakeLocationKey(60, 344);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantIlessanHills, locIlessanHills);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantIlessanHills, locIlessanHills);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantIlessanHills, locIlessanHills);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantIlessanHills, locIlessanHills);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantIlessanHills, locIlessanHills);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantIlessanHills, locIlessanHills);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantIlessanHills, locIlessanHills);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantIlessanHills, locIlessanHills);
            }   
            //  Northmoor (252) in region 32
            if (WorldDataVariants.GetBuildingVariant(32, 252, "WALLAA00.RMB", 0) == null)
            {
                int locNorthmoor = WorldDataReplacement.MakeLocationKey(32, 252);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantNorthmoor, locNorthmoor);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantNorthmoor, locNorthmoor);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantNorthmoor, locNorthmoor);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantNorthmoor, locNorthmoor);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantNorthmoor, locNorthmoor);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantNorthmoor, locNorthmoor);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantNorthmoor, locNorthmoor);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantNorthmoor, locNorthmoor);
            }  
            //  Glenpoint (181) in region 18
            if (WorldDataVariants.GetBuildingVariant(18, 181, "WALLAA00.RMB", 0) == null)
            {
                int locGlenpoint = WorldDataReplacement.MakeLocationKey(18, 181);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantGlenpoint, locGlenpoint);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantGlenpoint, locGlenpoint);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantGlenpoint, locGlenpoint);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantGlenpoint, locGlenpoint);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantGlenpoint, locGlenpoint);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantGlenpoint, locGlenpoint);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantGlenpoint, locGlenpoint);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantGlenpoint, locGlenpoint);
            }    
            //  Glenumbra Moors (94) in region 59
            if (WorldDataVariants.GetBuildingVariant(59, 94, "WALLAA00.RMB", 0) == null)
            {
                int locGlenumbraMoors = WorldDataReplacement.MakeLocationKey(59, 94);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantGlenumbraMoors, locGlenumbraMoors);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantGlenumbraMoors, locGlenumbraMoors);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantGlenumbraMoors, locGlenumbraMoors);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantGlenumbraMoors, locGlenumbraMoors);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantGlenumbraMoors, locGlenumbraMoors);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantGlenumbraMoors, locGlenumbraMoors);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantGlenumbraMoors, locGlenumbraMoors);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantGlenumbraMoors, locGlenumbraMoors);
            }     
            //  Tulune (59) in region 58
            if (WorldDataVariants.GetBuildingVariant(58, 59, "WALLAA00.RMB", 0) == null)
            {
                int locTulune = WorldDataReplacement.MakeLocationKey(58, 59);
                WorldDataVariants.SetBuildingVariant("WALLAA00.RMB", 0, variantTulune, locTulune);
                WorldDataVariants.SetBuildingVariant("WALLAA01.RMB", 0, variantTulune, locTulune);
                WorldDataVariants.SetBuildingVariant("WALLAA02.RMB", 0, variantTulune, locTulune);
                WorldDataVariants.SetBuildingVariant("WALLAA03.RMB", 0, variantTulune, locTulune);
                WorldDataVariants.SetBuildingVariant("WALLAA08.RMB", 0, variantTulune, locTulune);
                WorldDataVariants.SetBuildingVariant("WALLAA09.RMB", 3, variantTulune, locTulune);
                WorldDataVariants.SetBuildingVariant("WALLAA10.RMB", 0, variantTulune, locTulune);
                WorldDataVariants.SetBuildingVariant("WALLAA11.RMB", 0, variantTulune, locTulune);
            }                                                                                                                                                                                                                            
        }
    }
}
