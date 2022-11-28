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



        public static void SetTransform(uint entity, Transform transform)
        {
            SetTransform(entity, transform.Position, transform.Rotation, transform.Pivot, transform.Scale);
        }

        public static Transform GetTransform(uint entity)
        {
            GetTransform(entity, out var position, out var rotaition, out var pivot, out var scale);
            Transform transform = new Transform(entity, position, rotaition, pivot, scale);
            return transform;
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static uint[] FindComponentsInScene(string name);
        public static void AddComponent<T>(uint entity, T value) where T : Component
        {
            AddComponent(entity, typeof(T).Name, value);
        }
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddComponent(uint entity, string typeName, object value);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCoreComponent(uint entity, string name, object value);
        public static void SetCoreComponent<T>(uint entity, T value) where T : CoreComponent
        {
            SetCoreComponent(entity, typeof(T).Name, value);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static object GetCoreComponent(uint entity, string name);
        public static T GetCoreComponent<T>(uint entity) where T : CoreComponent
        {
            return GetCoreComponent(entity, typeof(T).Name) as T;
        }

        public static T GetComponent<T>(uint entity) where T : Component
        {
            return GetComponent(entity, typeof(T).Name) as T;
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static object GetComponent(uint entity, string name);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static object PrintMessage(string name);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static object PrintError(string name);
    }
}
