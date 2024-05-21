using UnityEngine;
using IDisposable = System.IDisposable;

namespace Lumpn.Utilities
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
