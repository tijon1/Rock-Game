using IrrlichtLime;
using IrrlichtLime.Video;
using System;
namespace RGGame
{
    internal class DeviceSettings : IrrlichtCreationParameters
    {
        public Color BackColor;

        public DeviceSettings(IntPtr hh, DriverType dt, byte aa, Color bc, bool vs)
        {
            WindowID = hh;
            DriverType = dt;
            AntiAliasing = aa;
            BackColor = bc;
            VSync = vs;
        }
    }

    internal class Game
    {
        private bool active;

        public void Initialize()
        {

        }
        public void Loop()
        {
            while (active)
            {
                Draw();
                Update();
            }
        }

        private void Draw()
        {

        }

        private void Update()
        {

        }
    }
}
