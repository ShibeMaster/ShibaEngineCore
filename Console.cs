using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    public class Console
    {
        public static void LogMessage(string message)
        {
            ShibaEngineCore.EngineCalls.PrintMessage(message);
        }
        public static void LogError(string message)
        {
            ShibaEngineCore.EngineCalls.PrintError(message);
        }
    }
}
