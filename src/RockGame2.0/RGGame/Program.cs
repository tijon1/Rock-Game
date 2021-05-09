using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.GUI;
using IrrlichtLime.Scene;
using IrrlichtLime.Video;
using System.Reflection;

namespace RGGame
{

    public class Program
    {
        private static void Main()
        {
            IrrlichtDevice device = IrrlichtDevice.CreateDevice(
            DriverType.OpenGL, new Dimension2Di(640, 480), 16, false, false, false);

            Global.device = device;

            Global.device.SetWindowCaption("Rockplanets DEBUG MODE");

            VideoDriver driver = Global.device.VideoDriver;
            SceneManager smgr = Global.device.SceneManager;
            GUIEnvironment gui = Global.device.GUIEnvironment;

            CameraSceneNode cam = smgr.AddCameraSceneNode();
            cam.Target = new Vector3Df(0);

            SceneNodeAnimator anim = smgr.CreateFlyCircleAnimator(new Vector3Df(0, 15, 0), 30.0f);
            cam.AddAnimator(anim);
            anim.Drop();

            

            while (device.Run())
            {
                driver.BeginScene(ClearBufferFlag.All, new Color(235, 235, 235));

                smgr.DrawAll();
                gui.DrawAll();

                driver.EndScene();
            }

            device.Drop();
        }
    }
}
