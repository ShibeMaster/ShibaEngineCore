using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    public class SpriteRenderer : CoreComponent
    {
        private string spritePath;
        public string SpritePath { get { UpdateSelf(); return spritePath; } set { spritePath = value; UpdateExtern(); } }
    }
}
