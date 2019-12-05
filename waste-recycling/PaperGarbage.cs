namespace WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public bool Squeezed { get; set; }

        public PaperGarbage(string name, bool squeezed) : base(name)
        {
            Squeezed = squeezed;
        }

        public void Squeez()
        {
            Squeezed = true;
        }

        public bool isSqueezed()
        {
            return this.Squeezed;
        }

    }
}
