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
using TvsDumbPanel.Libraries;


namespace TvsDumbPanel.Mods
{
    internal class Banapuchin
    {
        public static void JoystickFly()
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                float leftStickX = ControllerInput.instance.GetAxis(ControllerInput.StickTypes.LeftStickAxis).x;
                float leftStickY = ControllerInput.instance.GetAxis(ControllerInput.StickTypes.LeftStickAxis).y;
                float rightStickY = ControllerInput.instance.GetAxis(ControllerInput.StickTypes.RightStickAxis).y;

                Vector3 inputs = new Vector3(leftStickX, leftStickY, rightStickY);
                Vector3 forward = Il2CppLocomotion.Player.Instance.playerCam.transform.forward;
                Vector3 right = Il2CppLocomotion.Player.Instance.playerCam.transform.right;

                forward.y = 0f;
                right.y = 0f;

                Vector3 velo = inputs.x * right + inputs.y * forward + inputs.z * Vector3.up;
                velo *= 15f;
                Il2CppLocomotion.Player.Instance.playerRigidbody.velocity = velo;
                Il2CppLocomotion.Player.Instance.playerRigidbody.AddForce(-Physics.gravity * Il2CppLocomotion.Player.Instance.playerRigidbody.mass);
            }
           



        }



    }
}