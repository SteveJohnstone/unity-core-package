using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace SteveJstone
{
    [CreateAssetMenu(menuName ="SteveJstone/Scene Defaults")]
    public class SceneDefaults : ScriptableObject
    {
        [AssetsOnly]
        [SerializeField] private GameObject _cameraPrefab;
        [AssetsOnly]
        [SerializeField] private GameObject _postProcessingPrefab;
        [AssetsOnly]
        [SerializeField] private GameObject _eventPrefab;
        [AssetsOnly]
        [SerializeField] private GameObject _lightingPrefab;

        private static SceneDefaults _config;

        [MenuItem("GameObject/SteveJstone/Add Scene Defaults")]
        public static void Setup()
        {
            FetchConfig();

            PrefabUtility.InstantiatePrefab(_config._cameraPrefab);
            PrefabUtility.InstantiatePrefab(_config._postProcessingPrefab);
            PrefabUtility.InstantiatePrefab(_config._eventPrefab);
            PrefabUtility.InstantiatePrefab(_config._lightingPrefab);
        }

        private static void FetchConfig()
        {
            while (true)
            {
                if (_config != null) return;

                var path = GetConfigPath();

                if (path == null)
                {
                    AssetDatabase.CreateAsset(CreateInstance<SceneDefaults>(), $"Assets/{nameof(SceneDefaults)}.asset");
                    Debug.Log($"{nameof(SceneDefaults)}: A config file has been created at the root of your project.<b> You can move this anywhere you'd like.</b>");
                    continue;
                }

                _config = AssetDatabase.LoadAssetAtPath<SceneDefaults>(path);

                break;
            }
        }

        private static string GetConfigPath()
        {
            var paths = AssetDatabase.FindAssets(nameof(SceneDefaults)).Select(AssetDatabase.GUIDToAssetPath).Where(c => c.EndsWith(".asset")).ToList();
            if (paths.Count > 1) Debug.LogWarning($"{nameof(SceneDefaults)}: Multiple assets found. Using the first one.");
            return paths.FirstOrDefault();
        }
    }
}
