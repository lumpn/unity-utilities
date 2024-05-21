using UnityEditor;
using UnityEngine;
using IDisposable = System.IDisposable;

namespace Lumpn.Utilities
{
    public sealed class UndoScope : IDisposable
    {
        private readonly int groupId;

        public UndoScope(string groupName)
        {
            Undo.IncrementCurrentGroup();
            Undo.SetCurrentGroupName(groupName);
            groupId = Undo.GetCurrentGroup();
        }

        public static void Record(Object obj)
        {
            Undo.RecordObject(obj, obj.name);
        }

        void IDisposable.Dispose()
        {
            Undo.CollapseUndoOperations(groupId);
        }
    }
}
