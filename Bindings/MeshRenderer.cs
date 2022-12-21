using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShibaEngineCore
{
    public class MeshRenderer : CoreComponent
    {
        private string modelPath = "";
        public string ModelPath { get { UpdateSelf(); return modelPath; } set { modelPath = value; UpdateExtern(); } }
        private string shader = "";
        public string Shader { get { UpdateSelf(); return shader; } set { shader = value; UpdateExtern(); } }
    }
}