using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;

using RGGame.Data;
using RGGame.Data.Instances;

namespace RGGame
{
    public interface IRenderObject
    {
        Instance linkedInstance
        {
            get;
            set;
        }

        public void Setup(SceneManager smgr);
    }
}
