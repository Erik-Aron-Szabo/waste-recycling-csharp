namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool Cleaned { get; set; }


        public bool isCleaned()
        {
            return this.Cleaned;
        }

        public PlasticGarbage(string name, bool cleaned) : base(name)
        {
            Cleaned = cleaned;
        }


        public void Clean()
        {
            Cleaned = true;
        }
    }
}
