using System;
using System.Numerics;

namespace ShibaEngineCore
{
    public class Light : CoreComponent
    {
        private Vector3 colour;
        public Vector3 Colour { get { UpdateSelf(); return colour; } set { colour = value; UpdateExtern(); } }
    }
}
