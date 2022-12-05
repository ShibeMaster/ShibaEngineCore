using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    /// <summary>
    /// Transformation of the entity
    /// </summary>
    public class Transform : CoreComponent
    {
        private Vector3 position;
        public Vector3 Position { get { UpdateSelf(); return position; } set { position = value; UpdateExtern(); } }

        private Vector3 rotation;
        public Vector3 Rotation { get { UpdateSelf(); return rotation; } set { rotation = value; UpdateExtern(); } }

        private Vector3 pivot;
        public Vector3 Pivot { get { UpdateSelf(); return pivot; } set { pivot = value; UpdateExtern(); } }

        private Vector3 scale;
        public Vector3 Scale { get { UpdateSelf(); return scale; } set { scale = value; UpdateExtern(); } }
    }
}
