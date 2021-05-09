using System;
using System.Collections.Generic;
using System.Text;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.GUI;
using IrrlichtLime.Scene;
using IrrlichtLime.Video;

namespace RGGame.Data
{
    public class Model
    {
        public Mesh mesh;
        public void LoadMesh(string path, SceneManager smgr)
        {
            mesh = smgr.GetMesh(path);
        }
    }
}
