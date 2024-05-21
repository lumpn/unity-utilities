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
    }
}
