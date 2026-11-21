using System;
using System.Collections;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(freecam.Core), "freecam", "1.0.0", "Yakou", "https://github.com/TheFool77777/freecam")]
[assembly: MelonGame("gogh Japan", "gogh")]
[assembly: MelonPriority(100)]

namespace freecam
{
    public class Core : MelonMod
    {
        private const string ROOT_PATH = "SceneContext/RoomObjectParent";
        private const string SEARCH_KEYWORD = "P_RoomBase";
        private static readonly string[] SUB_PATH_PARTS = new string[3] { "RoomParameters", "BoundingBoxes", "WholeRoomBoundingBox" };
        private static readonly Vector3 NEW_SCALE = new Vector3(10f, 10f, 10f);
        private static readonly Vector3 NEW_LOCAL_POS = new Vector3(0f, -3f, 0f);

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            if (sceneName == "S_RoomScene" || sceneName == "S_RoomMultiScene")
            {
                MelonCoroutines.Start(DelayedModify());
            }
        }

        private static IEnumerator DelayedModify()
        {
            yield return new WaitForSeconds(2f);

            if (TryModifyWholeRoom())
            {
                MelonLogger.Msg("✅ WholeRoomBoundingBox modified successfully!");
                yield break;
            }

            MelonLogger.Warning("❌ First attempt failed, retrying in 2 seconds...");
            yield return new WaitForSeconds(2f);

            if (TryModifyWholeRoom())
            {
                MelonLogger.Msg("✅ WholeRoomBoundingBox modified successfully on retry!");
            }
            else
            {
                MelonLogger.Error("❌ freecam failed after retry.");
            }
        }

        private static bool TryModifyWholeRoom()
        {
            try
            {
                ModifyWholeRoom();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static void ModifyWholeRoom()
        {
            GameObject obj = GameObject.Find(ROOT_PATH);
            if (obj == null)
            {
                throw new Exception("Root GameObject 'SceneContext/RoomObjectParent' not found!");
            }

            Transform transform = obj.transform;
            Stack<Transform> stack = new Stack<Transform>();
            stack.Push(transform);
            Transform targetRoot = null;

            while (stack.Count > 0)
            {
                Transform current = stack.Pop();
                if (current.name.Contains(SEARCH_KEYWORD))
                {
                    targetRoot = current;
                    break;
                }

                for (int i = current.childCount - 1; i >= 0; i--)
                {
                    stack.Push(current.GetChild(i));
                }
            }

            if (targetRoot == null)
            {
                string children = "";
                for (int i = 0; i < transform.childCount; i++)
                {
                    children = children + "'" + transform.GetChild(i).name + "' ";
                }
                throw new Exception("No object with 'P_RoomBase' in name! Root children: " + children);
            }

            Transform target = targetRoot;
            for (int i = 0; i < SUB_PATH_PARTS.Length; i++)
            {
                target = target.Find(SUB_PATH_PARTS[i]);
                if (target == null)
                {
                    throw new Exception("Missing in path: " + SUB_PATH_PARTS[i]);
                }
            }

            target.SetLocalPositionAndRotation(NEW_LOCAL_POS, target.localRotation);
            target.localScale = NEW_SCALE;

            string fullPath = target.name;
            Transform parent = target.parent;
            while (parent != null)
            {
                fullPath = parent.name + "/" + fullPath;
                parent = parent.parent;
            }

            MelonLogger.Msg("Target: " + target.name);
            MelonLogger.Msg("Path: " + fullPath);
            MelonLogger.Msg($"Scale: {target.localScale}");
            MelonLogger.Msg($"LocalPos: {target.localPosition}");
        }
    }
}
