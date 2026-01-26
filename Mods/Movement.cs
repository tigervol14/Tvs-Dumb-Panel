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
    internal class Movement
    {
        public static float climbDragOriginal;
        public static bool setOriginalClimbDrag = false;

        public static GameObject platl = null;
        public static GameObject platr = null;

        public static void WorldScale(GameObject obj, Vector3 targetWorldScale)
        {
            Vector3 parentScale = obj.transform.parent.lossyScale;
            obj.transform.localScale = new Vector3(targetWorldScale.x / parentScale.x, targetWorldScale.y / parentScale.y, targetWorldScale.z / parentScale.z);
        }

        public static void FixStickyColliders(GameObject platform)
        {
            System.Random rand = new();
            Vector3[] localPositions = new Vector3[]
            {
                new Vector3(0, 1f, 0),
                new Vector3(0, -1f, 0),
                new Vector3(1f, 0, 0),
                new Vector3(-1f, 0, 0),
                new Vector3(0, 0, 1f),
                new Vector3(0, 0, -1)
            };
            Quaternion[] localRotations = new Quaternion[]
            {
                Quaternion.Euler(90, 0, 0),
                Quaternion.Euler(-90, 0, 0),
                Quaternion.Euler(0, -90, 0),
                Quaternion.Euler(0, 90, 0),
                Quaternion.identity,
                Quaternion.Euler(0, 180, 0)
            };
            for (int i = 0; i < localPositions.Length; i++)
            {
                GameObject side = GameObject.CreatePrimitive(PrimitiveType.Cube);
                float size = 0.13f;
                side.transform.SetParent(platform.transform);
                side.transform.position = localPositions[i] * (size / 2);
                side.transform.rotation = localRotations[i];
                WorldScale(side, new Vector3(size, size, 0.01f));
                side.GetComponent<Renderer>().enabled = true;
                side.GetComponent<Renderer>().material.color = new Color32((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), 128);
                platform.GetComponent<Collider>().enabled = false;
                platform.GetComponent<Renderer>().enabled = false;
            }
        }


        // someguylol is actually a fucking life saver

        public static void Platforms()
        {

            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                if (Controls.LGrip())
                {
                    if (platl == null)
                    {
                        //platl = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        //platl.layer = LayerMask.NameToLayer("Grabable");
                        //platl.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                        Il2CppLocomotion.Player.Instance.playerRigidbody.velocity = Vector3.zero;
                        platl = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        platl.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                        FixStickyColliders(platl);

                        platl.transform.position = Il2CppLocomotion.Player.Instance.LeftCollider.transform.position;
                        platl.transform.rotation = Il2CppLocomotion.Player.Instance.LeftCollider.transform.rotation;

                        ColorChanger colorChanger = platl.AddComponent<ColorChanger>();
                        colorChanger.Start();
                    }

                }
                else
                {
                    if (platl != null)
                    {
                        UnityEngine.Object.Destroy(platl);
                        platl = null;
                    }
                }


                if (Controls.RGrip())
                {
                    if (platr == null)
                    {
                        //platr = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        //platr.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                        //platr.layer = LayerMask.NameToLayer("Grabable");
                        Il2CppLocomotion.Player.Instance.playerRigidbody.velocity = Vector3.zero;
                        platr = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        platr.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                        FixStickyColliders(platr);

                        platr.transform.position = Il2CppLocomotion.Player.Instance.RightCollider.transform.position; // - Vector3.down * 0.05f;
                        platr.transform.rotation = Il2CppLocomotion.Player.Instance.RightCollider.transform.rotation;

                        ColorChanger colorChanger = platr.AddComponent<ColorChanger>();
                        colorChanger.Start();
                    }

                }
                else
                {
                    if (platr != null)
                    {
                        UnityEngine.Object.Destroy(platr);
                        platr = null;
                    }
                }
            }
            

            
        }


        public static void SpeedBoostOn()
        {

            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                if (!setOriginalClimbDrag)
                {
                    setOriginalClimbDrag = true;
                    climbDragOriginal = Il2CppLocomotion.Player.Instance.climbDrag;
                }
                Il2CppLocomotion.Player.Instance.climbDrag = 1f;
            }
            else
            {
                climbDragOriginal = Il2CppLocomotion.Player.Instance.climbDrag;
            }

        }
        public static void SpeedBoostOff()
        {
            Il2CppLocomotion.Player.Instance.climbDrag = climbDragOriginal;
        }


        public static void ZeroGravOn()
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppLocomotion.Player.Instance.playerRigidbody.useGravity = false;
            }
            else
            {
                Il2CppLocomotion.Player.Instance.playerRigidbody.useGravity = true;
            }
            
        }
        public static void ZeroGravOff()
        {
            Il2CppLocomotion.Player.Instance.playerRigidbody.useGravity = true;
        }

        public static void Fly()
        {
            if (Controls.XButton())
            {
                if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
                {
                    Il2CppLocomotion.Player.Instance.transform.position += Il2CppLocomotion.Player.Instance.LeftHand.transform.forward * 0.5f;
                    Il2CppLocomotion.Player.Instance.playerRigidbody.velocity = Vector3.zero;
                }
                 
            }
            
        }

        public static void UpsideDownOn()
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppLocomotion.Player.Instance.transform.Rotate(Vector3.right, 180, Space.Self);
            }
            else
            {
                Il2CppLocomotion.Player.Instance.transform.Rotate(Vector3.right, -180, Space.Self);
            }
        }
        public static void UpsideDownOff()
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {
                Il2CppLocomotion.Player.Instance.transform.Rotate(Vector3.right, -180, Space.Self);
            }
            else
            {
                Il2CppLocomotion.Player.Instance.transform.Rotate(Vector3.right, 180, Space.Self);
            }
        }


        public static void Noclip()
        {
            if (CaputillaMelonLoader.CaputillaHub.InModdedRoom)
            {

                if (Controls.AButton())
                {
                    MeshCollider[] meshColliders = Resources.FindObjectsOfTypeAll<MeshCollider>();
                    foreach (MeshCollider MeshCol in meshColliders)
                    {
                        MeshCol.enabled = false;
                    }
                }
                else
                {
                    MeshCollider[] meshColliders = Resources.FindObjectsOfTypeAll<MeshCollider>();
                    foreach (MeshCollider MeshCol in meshColliders)
                    {
                        MeshCol.enabled = true;
                    }
                }

                if (Controls.LGrip())
                {
                    if (platl == null)
                    {
                        //platl = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        //platl.layer = LayerMask.NameToLayer("Grabable");
                        //platl.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                        Il2CppLocomotion.Player.Instance.playerRigidbody.velocity = Vector3.zero;
                        platl = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        platl.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                        FixStickyColliders(platl);

                        platl.transform.position = Il2CppLocomotion.Player.Instance.LeftCollider.transform.position;
                        platl.transform.rotation = Il2CppLocomotion.Player.Instance.LeftCollider.transform.rotation;

                        ColorChanger colorChanger = platl.AddComponent<ColorChanger>();
                        colorChanger.Start();
                    }

                }
                else
                {
                    if (platl != null)
                    {
                        UnityEngine.Object.Destroy(platl);
                        platl = null;
                    }
                }

                if (Controls.RGrip())
                {
                    if (platr == null)
                    {
                        //platr = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        //platr.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                        //platr.layer = LayerMask.NameToLayer("Grabable");
                        Il2CppLocomotion.Player.Instance.playerRigidbody.velocity = Vector3.zero;
                        platr = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        platr.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                        FixStickyColliders(platr);

                        platr.transform.position = Il2CppLocomotion.Player.Instance.RightCollider.transform.position; // - Vector3.down * 0.05f;
                        platr.transform.rotation = Il2CppLocomotion.Player.Instance.RightCollider.transform.rotation;

                        ColorChanger colorChanger = platr.AddComponent<ColorChanger>();
                        colorChanger.Start();
                    }

                }
                else
                {
                    if (platr != null)
                    {
                        UnityEngine.Object.Destroy(platr);
                        platr = null;
                    }
                }
            }

        }
    }
}