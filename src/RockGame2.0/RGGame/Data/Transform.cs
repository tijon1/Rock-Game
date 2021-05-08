using IrrlichtLime.Core;

namespace RGGame.Data
{
    /// <summary>
    /// Basic transform struct, it contains 3 variables. Position, rotation and scale.
    /// </summary>
    public struct Transform
    {
        public Vector3Df position;
        public Quaternion rotation;
        public Vector3Df scale;

        public Transform(Vector3Df pos)
        {
            position = pos;
            rotation = Quaternion.Identity;
            scale = new Vector3Df(1);
        }
        public Transform(Vector3Df pos, Quaternion rot)
        {
            position = pos;
            rotation = rot;
            scale = new Vector3Df(1);
        }
        public Transform(Vector3Df pos, Quaternion rot, Vector3Df sca)
        {
            position = pos;
            rotation = rot;
            scale = sca;
        }
    }
}
