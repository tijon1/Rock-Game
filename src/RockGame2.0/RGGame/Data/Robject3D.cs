using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;

using RGGame.Data.Instances;

namespace RGGame.Data
{
    public class RenderObject3D : IRenderObject
    {
        public MeshSceneNode sceneNode;

        public Model model;

        private Instance lInstance;
        public Instance linkedInstance 
        { 
            get
            {
                return lInstance;
            }
            set
            {
                lInstance = value;
            }
        }

        public void Setup(SceneManager smgr) 
        {
            sceneNode = smgr.AddMeshSceneNode(model.mesh);
        }
        public void Setup(SceneManager smgr, Mesh _mesh)
        {
            model.mesh = _mesh;
            sceneNode = smgr.AddMeshSceneNode(model.mesh);
        }
    }
}
