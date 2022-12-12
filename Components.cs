using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ShibaEngineCore
{
    public static class Components
    {

        /// <summary>
        /// Updates the external core component, should be called from the core component bindings when a property is set
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern static void UpdateExternCoreComponent(uint entity, string name, object value);
        public static void UpdateExternCoreComponent<T>(uint entity, T value) where T : CoreComponent
        {
            UpdateExternCoreComponent(entity, typeof(T).Name, value);
        }


        /// <summary>
        /// Updating a core component on the scripting side to the latest values on the external side, should be called from a core component binding when the get property is called
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern static void UpdateCoreComponent(uint entity, string name);
        public static void UpdateCoreComponent<T>(uint entity) where T : CoreComponent
        {
            UpdateCoreComponent(entity, typeof(T).Name);
        }


        /// <summary>
        /// Getting a reference to the core component from the external side
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern static object GetCoreComponent(uint entity, string name);
        public static T GetCoreComponent<T>(uint entity) where T : CoreComponent
        {
            return GetCoreComponent(entity, typeof(T).Name) as T;
        }

        public static Instance GetInstance(uint entity)
        {
            return GetEntityInstance(entity) as Instance;
        }
        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern static object GetEntityInstance(uint entity);
    }
    public class Component
    {
        public uint entity;
        public Transform transform;
        public Instance instance;
        private void Initialize()
        {
            System.Console.WriteLine("initialized");
            transform = Components.GetCoreComponent<Transform>(entity);
            instance = Components.GetInstance(entity);
        }
        public virtual void Start() { }
        public virtual void Update() { }
    }
    /// <summary>
    /// This is the class that all of the bindings for core components should inherit from
    /// </summary>
    public class CoreComponent
    {
        public uint entity;
        public void UpdateSelf()
        {
            Components.UpdateCoreComponent(entity, GetType().Name);
        }
        public void UpdateExtern()
        {
            Components.UpdateExternCoreComponent(entity, GetType().Name, this);
        }
    }
}
