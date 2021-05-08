namespace RGGame.Data.Instances
{
    public class GroupInstance : Instance
    {
        public Instance primaryInstance;
        public void Ungroup()
        {
            foreach (Instance i in children)
            {
                i.SetParent(parent);

            }
        }

    }
}
