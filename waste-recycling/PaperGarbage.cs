namespace WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public bool Squeezed { get; set; }

        public PaperGarbage(string name, bool squeezed)
        {
            Name = name;
            Squeezed = squeezed;
        }

        public void Squeez()
        {
            Squeezed = true;
        }


    }
}
