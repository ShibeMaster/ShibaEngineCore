using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    public class Camera : CoreComponent
    {
        public float yaw;
        public float Yaw { get { UpdateSelf(); return yaw; } set { yaw = value; UpdateExtern(); } }

        public float pitch;
        public float Pitch { get { UpdateSelf(); return pitch; } set { pitch = value; UpdateExtern(); } }

        public float speed;
        public float Speed { get { UpdateSelf(); return speed; } set { speed = value; UpdateExtern(); } }

        public float sensitivity;
        public float Sensitivity { get { UpdateSelf(); return sensitivity; } set { sensitivity = value; UpdateExtern(); } }

    }
}
