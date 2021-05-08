using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;

using RGGame.Data;
using RGGame.Data.Instances;

namespace RGGame
{
    public class RenderObject
    {
        public Transform transform;
        public Instance linkedInstance;
        public Material material;

        public virtual void Render()
        {
            
        }


        //static functions
        public static RenderObject Create(Vector3Df pos)
        {
            RenderObject renderObject = new RenderObject();
            renderObject.transform = new Transform(pos);
            return renderObject;
        }
        public static RenderObject Create(Vector3Df pos, Instance linkIns)
        {
            RenderObject renderObject = new RenderObject();
            renderObject.transform = new Transform(pos);
            renderObject.linkedInstance = linkIns;
            return renderObject;
        }
        public static RenderObject Create(Vector3Df pos, Quaternion rotation, Instance linkIns)
        {
            RenderObject renderObject = new RenderObject();
            renderObject.transform = new Transform(pos, rotation);
            renderObject.linkedInstance = linkIns;
            return renderObject;
        }
        public static RenderObject Create(Vector3Df pos, Quaternion rotation, Vector3Df scale, Instance linkIns)
        {
            RenderObject renderObject = new RenderObject();
            renderObject.transform = new Transform(pos, rotation, scale);
            renderObject.linkedInstance = linkIns;
            return renderObject;
        }
    }
}
