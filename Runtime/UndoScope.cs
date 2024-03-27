using UnityEngine;
using IDisposable = System.IDisposable;

namespace Lumpn.Undoing
{
    public sealed class UndoScope : IDisposable
    {
        public UndoScope(string groupName)
        {
        }

        public static void Record(Object obj)
        {
        }

        void IDisposable.Dispose()
        {
        }
    }
}
