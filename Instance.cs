using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    public class Instance
    {
        public uint entity = uint.MaxValue;
        public string name => GetName(entity);
        public void AddComponent<T>(T value) where T : Component
        {
            EngineCalls.AddComponent<T>(entity, value);
        }
        public T GetCoreComponent<T>() where T : CoreComponent
        {
            return Components.GetCoreComponent<T>(entity);
        }
        public T GetComponent<T>() where T : Component
        {
            return EngineCalls.GetComponent<T>(entity);
        }
        public T[] FindComponentsInChildren<T>() where T : Component
        {
            return EngineCalls.FindComponentsInChildren(entity, typeof(T).Name) as T[];
        }
        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern string GetName(uint entity);

    }
}
