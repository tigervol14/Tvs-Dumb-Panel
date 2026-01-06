using Il2Cpp;
using Il2CppCapuchinPlayFab;
using Il2CppDissonance.Integrations.Offline;
using Il2CppFusion;
using Il2CppMono.Security.Protocol.Ntlm;
using Il2CppPhoton.Voice;
using Il2CppPhoton.Voice.Fusion;
using Il2CppPhoton.Voice.Unity;
using Il2CppPhoton.Voice.Unity.UtilityScripts;
using Il2CppPlayFab;
using Il2CppPlayFab.ClientModels;
using Il2CppPlayFab.ProgressionModels;
using Il2CppSteamworks;
using Il2CppTMPro;
using Il2CppVLB;
using Il2CppVLB_Samples;
using MelonLoader;
using MelonLoader.Utils;
using TvsDumbPanel.Classes;
using TvsDumbPanel.Menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.XR;
using static TvsDumbPanel.Menu.Main;


namespace TvsDumbPanel.Mods
{
    internal class Fun
    {
        public static void Size2() 
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppLocomotion.Player.Instance.scale = 2f;
            }
                
        }

        public static void Size1half() 
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppLocomotion.Player.Instance.scale = 1.5f;
            }
        }

        public static void SizeNormal() 
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppLocomotion.Player.Instance.scale = 1f;
            }
        }
        public static void SizeABitSmall() 
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppLocomotion.Player.Instance.scale = 0.75f;
            }
        }

        public static void Smol() 
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppLocomotion.Player.Instance.scale = 0.5f;
            }
        }

        public static void pixel()
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppLocomotion.Player.Instance.scale = 0.25f;
            }
        }

        public static void Nuke()
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppMod.BombManager.Instance.LaunchMissile(true);
            }
        }
        public static void Missle()
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppMod.BombManager.Instance.LaunchMissile(false);
            }
        }

        public static void OGZeroGOn()
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                GameObject.Find("Global/Levels/Zero Core/Zero G Trigger").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/MapMesh").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/TopRedZone").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/ScienceRoom").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G").GetComponent<MeshRenderer>().enabled = false;
                GameObject.Find("Global/Levels/Zero Core/Zero G").GetComponent<MeshCollider>().enabled = false;
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (1)").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (2)").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (3)").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (4)").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (5)").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (6)").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (7)").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (8)").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (9)").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/Zero Gravity Music").SetActive(true);
            }
            else
            {
                GameObject.Find("Global/Levels/Zero Core/Zero G Trigger").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/MapMesh").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/TopRedZone").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/ScienceRoom").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G").GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("Global/Levels/Zero Core/Zero G").GetComponent<MeshCollider>().enabled = true;
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (1)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (2)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (3)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (4)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (5)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (6)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (7)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (8)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (9)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/Zero Gravity Music").SetActive(true);
            }
           
        }

        public static void OGZeroGOff()
        {
                GameObject.Find("Global/Levels/Zero Core/Zero G Trigger").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/MapMesh").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/TopRedZone").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/ScienceRoom").SetActive(false);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G").GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("Global/Levels/Zero Core/Zero G").GetComponent<MeshCollider>().enabled = true;
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (1)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (2)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (3)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (4)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (5)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (6)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (7)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (8)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/ZeroGProps/DirtPile (9)").SetActive(true);
                GameObject.Find("Global/Levels/Zero Core/Zero G/Zero Gravity Music").SetActive(true);

        }
    }
}