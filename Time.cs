using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    public static class Time
    {
        public static float deltaTime = 0f;
        public static float currentTime = 0f;

        public static void UpdateTime(float deltaTime, float currentTime)
        {
            Time.deltaTime = deltaTime;
            Time.currentTime = currentTime;
        }

    }
}
