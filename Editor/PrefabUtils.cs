using UnityEditor;
using UnityEngine;

namespace Lumpn.Undoing
{
    public static class PrefabUtils
    {
        public static void RevertObjectOverride(Object obj)
        {
            PrefabUtility.RevertObjectOverride(obj, InteractionMode.UserAction);
        }
    }
}
