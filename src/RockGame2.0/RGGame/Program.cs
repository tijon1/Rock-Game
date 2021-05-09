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

            device.SetWindowCaption("Rockplanets DEBUG MODE");

            VideoDriver driver = device.VideoDriver;
            SceneManager smgr = device.SceneManager;
            GUIEnvironment gui = device.GUIEnvironment;

            CameraSceneNode cam = smgr.AddCameraSceneNode();
            cam.Target = new Vector3Df(0);

            SceneNodeAnimator anim = smgr.CreateFlyCircleAnimator(new Vector3Df(0, 15, 0), 30.0f);
            cam.AddAnimator(anim);
            anim.Drop();

            Material material = new Material();
            material.DiffuseColor = new Color(5, 8, 30);
            material.Lighting = false;

            SceneNode cube = smgr.AddCubeSceneNode(20f);
            cube.SetMaterialFlag(MaterialFlag.Lighting, false);
            cube.SetMaterial(0,material);



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
