#if UNITY_EDITOR && UNITY_INPUT_SYSTEM_PROJECT_WIDE_ACTIONS

using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Editor
{
    class ProjectWideActionsAssetPostprocessor : AssetPostprocessor
    {
        static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths, bool didDomainReload)
        {
            if (ArrayHelpers.Contains(importedAssets, ProjectWideActionsAsset.kAssetPath))
            {
                ProjectWideActionsAsset.CreateRoslynAdditionalFile();
            }
        }
    }

    internal static class ProjectWideActionsAsset
    {
        internal const string kTemplateAssetPath = "Packages/com.unity.inputsystem/InputSystem/Editor/ProjectWideActions/ProjectWideActionsTemplate.json";
        internal const string kAssetPath = "ProjectSettings/InputManager.asset";
        internal const string kAssetName = InputSystem.kProjectWideActionsAssetName;

        const string kAdditionalFilePath = "ProjectSettings/actions.InputSystemActionsAPIGenerator.additionalfile"; // Copy of asset that is fed to the SourceGenerator

#if UNITY_INCLUDE_TESTS
        internal static InputActionAsset testAsset  { get; set; }
#endif

        [InitializeOnLoadMethod]
        internal static void InstallProjectWideActions()
        {
            GetOrCreate();
        }

        internal static InputActionAsset GetOrCreate()
        {
#if UNITY_INCLUDE_TESTS
            if (testAsset != null) return testAsset;
#endif

            var objects = AssetDatabase.LoadAllAssetsAtPath(kAssetPath);
            if (objects != null)
            {
                var inputActionsAsset = objects.FirstOrDefault(o => o != null && o.name == kAssetName) as InputActionAsset;
                if (inputActionsAsset != null)
                    return inputActionsAsset;
            }

            return CreateNewActionAsset();
        }

        private static InputActionAsset CreateNewActionAsset()
        {
            var json = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, kTemplateAssetPath));

            var asset = ScriptableObject.CreateInstance<InputActionAsset>();
            asset.LoadFromJson(json);
            asset.name = kAssetName;

            AssetDatabase.AddObjectToAsset(asset, kAssetPath);

            // Make sure all the elements in the asset have GUIDs and that they are indeed unique.
            var maps = asset.actionMaps;
            foreach (var map in maps)
            {
                // Make sure action map has GUID.
                if (string.IsNullOrEmpty(map.m_Id) || asset.actionMaps.Count(x => x.m_Id == map.m_Id) > 1)
                    map.GenerateId();

                // Make sure all actions have GUIDs.
                foreach (var action in map.actions)
                {
                    var actionId = action.m_Id;
                    if (string.IsNullOrEmpty(actionId) || asset.actionMaps.Sum(m => m.actions.Count(a => a.m_Id == actionId)) > 1)
                        action.GenerateId();
                }

                // Make sure all bindings have GUIDs.
                for (var i = 0; i < map.m_Bindings.LengthSafe(); ++i)
                {
                    var bindingId = map.m_Bindings[i].m_Id;
                    if (string.IsNullOrEmpty(bindingId) || asset.actionMaps.Sum(m => m.bindings.Count(b => b.m_Id == bindingId)) > 1)
                        map.m_Bindings[i].GenerateId();
                }
            }

            // Create sub-asset for each action. This is so that users can select individual input actions from the asset when they're
            // trying to assign to a field that accepts only one action.
            foreach (var map in maps)
            {
                foreach (var action in map.actions)
                {
                    var actionReference = ScriptableObject.CreateInstance<InputActionReference>();
                    actionReference.Set(action);
                    AssetDatabase.AddObjectToAsset(actionReference, asset);
                }
            }

            AssetDatabase.SaveAssets();

            return asset;
        }

        // Writes the current project wide actions (`InputSystem.actions`) content to a file
        // the Roslyn source generator will be able to read. This file is automatically generated
        // and is created in the root of the User's Assets directory.
        internal static void CreateRoslynAdditionalFile()
        {
            try
            {
                // @TODO: Needs to serialize a YAML file (hopefully with just a InputActionAsset).

                //var assetJson = InputSystem.actions.ToJson();
                //var existingJson = File.Exists(kAdditionalFilePath) ? File.ReadAllText(kAdditionalFilePath) : "";
                //if (assetJson != existingJson)
                //{
                //    File.WriteAllText(kAdditionalFilePath, assetJson);
                //    AssetDatabase.ImportAsset(kAdditionalFilePath); // Invoke importer and therefore source generator
                //}
            }
            catch (Exception exception)
            {
                Debug.LogError($"InputSystem could not save actions additional file: '{kAdditionalFilePath}' ({exception})");
            }
        }

        internal static void DeleteRoslynAdditionalFile()
        {
            try
            {
                AssetDatabase.DeleteAsset(kAdditionalFilePath);
            }
            catch (Exception exception)
            {
                Debug.LogError($"InputSystem could not delete actions additional file: '{kAdditionalFilePath}' ({exception})");
            }
        }
    }
}
#endif
