using System;
using System.Collections.Generic;
using System.Text;

namespace RGGame.Data.Instances
{
    public class GameInstance : Instance
    {
        public Transform transform;
        public RenderObject3D renderObject;

        public void SetRenderObject(IRenderObject ro)
        {
            renderObject = ro;
            ro.linkedInstance = this;
        }

        public virtual void Start()
        {
            if (renderObject != null)
            {
                renderObject.Setup(Global.smgr);
            }
        }

        public virtual void Update()
        {
            renderObject.sceneNode.Position = transform.position;
            renderObject.sceneNode.Rotation = transform.rotation;
            renderObject.sceneNode.Scale = transform.scale;
        }
    }
}
