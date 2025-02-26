using UnityEditor;
using UnityEngine;

namespace Lumpn.Utilities
{
    public static class PrefabUtils
    {
        public static void RevertObjectOverride(Object obj)
        {
            PrefabUtility.RevertObjectOverride(obj, InteractionMode.UserAction);
        }

        public static Object InstantiatePrefab(Object assetComponentOrGameObject, Transform parent = null)
        {
            return PrefabUtility.InstantiatePrefab(assetComponentOrGameObject, parent);
        }
    }
}
