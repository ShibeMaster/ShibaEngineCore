using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    /// <summary>
    /// must only be applied to static classes
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class BehaviourAttribute : Attribute
    {
        public bool hasInterval;
        public float interval;
        public BehaviourAttribute(float interval = -0.1f)
        {
            this.interval = interval;
            hasInterval = interval > 0;
        }
    }
    public struct BehaviourData
    {
        public Type type;
        public float interval;
        public bool hasInterval;
    }
    public static class BehaviourManager
    {
        public static BehaviourData[] behaviours;
        public static void LoadBehaviours(Assembly assembly)
        {
            List<BehaviourData> behaviours = new List<BehaviourData>();
            foreach (var i in assembly.GetTypes())
            {
                if(i.IsAbstract && i.IsSealed && i.GetCustomAttribute(typeof(BehaviourAttribute)) != null)
                {
                    BehaviourData data = new();
                    BehaviourAttribute attrib = (BehaviourAttribute)i.GetCustomAttribute(typeof(BehaviourAttribute));
                    data.hasInterval = attrib.hasInterval;
                    data.interval = attrib.interval;
                    data.type = i;
                    behaviours.Add(data);
                }
            }
            BehaviourManager.behaviours = behaviours.ToArray();
        }
        public static int GetBehaviourCount()
        {
            return behaviours.Length;
        }
        public static string GetBehaviourName(int index)
        {
            return behaviours[index].type.Name;
        }
        public static string GetBehaviourNamespace(int index)
        {
            return behaviours[index].type.Namespace == null ? "" : behaviours[index].type.Namespace;
        }
        public static float GetBehaviourInterval(int index)
        {
            return behaviours[index].hasInterval ? behaviours[index].interval : 0.0f;
        }
    }
    
}
