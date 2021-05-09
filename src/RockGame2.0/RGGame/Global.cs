using System;
using System.Collections.Generic;
using System.Text;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;
using IrrlichtLime.GUI;

using RGGame.Data;
using RGGame.Data.Instances;

namespace RGGame
{
    public static class Global
    {
        public static SceneManager smgr;
        public static GUIEnvironment gui;
        public static IrrlichtDevice device;
        public static VideoDriver videoDriver;
    }
}
