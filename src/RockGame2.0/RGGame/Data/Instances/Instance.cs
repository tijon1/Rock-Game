using System.Collections.Generic;

namespace RGGame.Data.Instances
{
    public class Instance
    {
        public string name;
        public List<Instance> children;
        public Instance parent;
        public RenderObject renderObject;
        public Instance FindInstance(string name)
        {
            return children.Find(item => item.name == name);
        }

        public void SetChild(Instance child)
        {
            child.SetParent(this);
        }

        public void SetParent(Instance _parent)
        {
            if (parent != null)
            {
                parent.children.Remove(this);
            }
            parent = _parent;
            parent.children.Add(this);
        }

        public virtual void Draw()
        {
            if (renderObject != null)
            {
                renderObject.Render();
            }
        }

        public virtual void Update()
        {

        }

    }
}
