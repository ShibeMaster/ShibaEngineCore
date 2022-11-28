using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ShibaEngineCore
{

    public class Component
    {
        public uint entity;
        public Transform Transform
        {
            get { return EngineCalls.GetTransform(entity); }
            set { EngineCalls.SetTransform(entity, value); }
        }
        public virtual void Start() { }
        public virtual void Update() { }

        public void AddComponent<T>(T value) where T : Component
        {
            EngineCalls.AddComponent<T>(entity, value);
        }
        public T GetComponent<T>() where T : Component
        {
            return EngineCalls.GetComponent<T>(entity);
        }
    }
    public class CoreComponent
    {
        public uint entity;
    }
    public class Physics : CoreComponent
    {
        private Vector3 velocity;
        public Vector3 Velocity { get { return EngineCalls.GetCoreComponent<Physics>(entity).velocity; } set { velocity = value; EngineCalls.SetCoreComponent<Physics>(entity, this); } }


        private bool useGravity;
        public bool UseGravity { get { return EngineCalls.GetCoreComponent<Physics>(entity).useGravity; } set { useGravity = value; EngineCalls.SetCoreComponent<Physics>(entity, this); } }
        private float gravity;
        public float Gravity { get { return EngineCalls.GetCoreComponent<Physics>(entity).gravity;} set { gravity = value; EngineCalls.SetCoreComponent<Physics>(entity, this);  } }
        private Vector3 gravityDirection;
        public Vector3 GravityDirection { get { return EngineCalls.GetCoreComponent<Physics>(entity).gravityDirection; } set { gravityDirection = value; EngineCalls.SetCoreComponent<Physics>(entity, this); } }


        private bool useDrag;
        public bool UseDrag { get { return EngineCalls.GetCoreComponent<Physics>(entity).useDrag; } set { useDrag = value; EngineCalls.SetCoreComponent<Physics>(entity, this); } }
        private float drag;
        public float Drag { get { return EngineCalls.GetCoreComponent<Physics>(entity).drag; } set { drag = value; EngineCalls.SetCoreComponent<Physics>(entity, this); } }
    }
    public class MeshCollisionBox : CoreComponent
    {
        private Vector3 min;
        public Vector3 Min { get { return EngineCalls.GetCoreComponent<MeshCollisionBox>(entity).min; } set { min = value; EngineCalls.SetCoreComponent<MeshCollisionBox>(entity, this); } }

        private Vector3 max;
        public Vector3 Max { get { return EngineCalls.GetCoreComponent<MeshCollisionBox>(entity).max; } set { max = value; EngineCalls.SetCoreComponent<MeshCollisionBox>(entity, this); } }

    }
    public class MeshRenderer : CoreComponent
    {
        private string modelPath = "";
        public string ModelPath { get { return EngineCalls.GetCoreComponent<MeshRenderer>(entity).modelPath; } set { modelPath = value; EngineCalls.SetCoreComponent<MeshRenderer>(entity, this); } }
    }
    public class Transform
    {
        public uint entity;

        public Transform(uint entity, Vector3 pos, Vector3 rot, Vector3 piv, Vector3 sca)
        {
            this.entity = entity;
            this.pos = pos;
            this.rot = rot;
            this.piv = piv;
            this.sca = sca;
        }
        private Vector3 pos;
        public Vector3 Position { get { return pos; } set { pos = value; EngineCalls.SetTransform(entity, this); } }

        private Vector3 rot;
        public Vector3 Rotation { get { return rot; } set { rot = value;  EngineCalls.SetTransform(entity, this); } }
        private Vector3 piv;
        public Vector3 Pivot { get { return piv; } set { piv = value;  EngineCalls.SetTransform(entity, this); } }
        private Vector3 sca;
        public Vector3 Scale { get { return sca; } set { sca = value;  EngineCalls.SetTransform(entity, this); } }
    }
}
