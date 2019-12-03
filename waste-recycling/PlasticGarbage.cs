namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool Cleaned { get; set; }



        public PlasticGarbage(string name, bool cleaned)
        {
            Name = name; //Name is from Garbage class
            Cleaned = cleaned;
        }


        public void Clean()
        {
            Cleaned = true;
        }
    }
}
