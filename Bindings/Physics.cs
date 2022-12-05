using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    public class Physics : CoreComponent
    {
        private Vector3 velocity;
        public Vector3 Velocity { get { UpdateSelf(); return velocity; } set { velocity = value; UpdateExtern(); } }


        private bool useGravity;
        public bool UseGravity { get { UpdateSelf(); return useGravity; } set { useGravity = value; UpdateExtern(); } }
        private float gravity;
        public float Gravity { get { UpdateSelf(); return gravity; } set { gravity = value; UpdateExtern(); } }
        private Vector3 gravityDirection;
        public Vector3 GravityDirection { get { UpdateSelf(); return gravityDirection; } set { gravityDirection = value; UpdateExtern(); } }


        private bool useDrag;
        public bool UseDrag { get { UpdateSelf(); return useDrag; } set { useDrag = value; UpdateExtern(); } }
        private float drag;
        public float Drag { get { UpdateSelf(); return drag; } set { drag = value; UpdateExtern(); } }
    }
}
