using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    public static class EngineCalls
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void GetTransform(uint entity, out Vector3 position, out Vector3 rotation, out Vector3 pivot, out Vector3 scale);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetTransform(uint entity, Vector3 position, Vector3 rotation, Vector3 pivot, Vector3 scale);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static uint CreateEntity();


        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static uint[] FindComponentsInScene(string name);
        public static void AddComponent<T>(uint entity, T value) where T : Component
        {
            AddComponent(entity, typeof(T).Name, value);
        }
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddComponent(uint entity, string typeName, object value);

        public static T GetComponent<T>(uint entity) where T : Component
        {
            return GetComponent(entity, typeof(T).Name) as T;
        }
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static object[] FindComponentsInChildren(uint entity, string type);


        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static object GetComponent(uint entity, string name);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static object PrintMessage(string name);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static object PrintError(string name);
    }
}
