using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    static class Scene
    {
        public static uint CreateEntity()
        {
            return EngineCalls.CreateEntity();
        }
        public static uint[] FindComponentsInScene<T>() where T : Component
        {
            return EngineCalls.FindComponentsInScene(typeof(T).Name);
        }
    }
}
