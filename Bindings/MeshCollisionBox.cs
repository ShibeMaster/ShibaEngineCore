using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    public class MeshCollisionBox : CoreComponent
    {
        private string meshPath;
        public string MeshPath { get { UpdateSelf(); return meshPath; } set { meshPath = value; UpdateExtern(); } }
        private bool debugDraw;
        public bool DebugDraw { get { UpdateSelf(); return debugDraw; } set { debugDraw = value; UpdateExtern(); } }
    }
}
