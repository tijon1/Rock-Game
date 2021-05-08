using System;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;
using IrrlichtLime.GUI;

namespace RGEG
{
    class Program
    {
        static void Main(string[] args)
        {
			IrrlichtDevice device = IrrlichtDevice.CreateDevice(
DriverType.OpenGL, new Dimension2Di(640, 480), 16, false, false, false);

			device.SetWindowCaption("testing irrlicht engine lol");

			VideoDriver driver = device.VideoDriver;
			SceneManager smgr = device.SceneManager;
			GUIEnvironment gui = device.GUIEnvironment;

			gui.AddStaticText("Hello World! This is the Irrlicht Software renderer!",
				new Recti(10, 10, 260, 22), true);

			smgr.AddCameraSceneNode(null, new Vector3Df(0, 30, -40), new Vector3Df(0, 5, 0));

			while (device.Run())
			{
				driver.BeginScene(ClearBufferFlag.All, new Color(100, 101, 140));

				smgr.DrawAll();
				gui.DrawAll();

				driver.EndScene();
			}

			device.Drop();
		}
    }
}
