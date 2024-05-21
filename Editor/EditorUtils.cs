using UnityEditor;
using UnityEngine;

namespace Lumpn.Utilities
{
    public static class EditorUtils
    {
        public static void SetDirty(Object obj)
        {
            EditorUtility.SetDirty(obj);
        }
    }
}
