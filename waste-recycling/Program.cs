namespace WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Dustbin Dustbin1 = new Dustbin("red"); // letrehoz peldany
            PaperGarbage tissue = new PaperGarbage("used tissue", false);

            PaperGarbage[] tissues = new PaperGarbage[0];

            PaperGarbage[] upgradedTissues = new PaperGarbage[tissues.Length+1];
            for (int i = 0; i < tissues.Length; i++)
            {
                upgradedTissues[i] = tissues[i];
            }
            upgradedTissues[upgradedTissues.Length-1] = tissue;
            tissues = upgradedTissues;

            Garbage[] rottenTomatoes = new Garbage[0];
            Garbage rottenTomato = new Garbage("rotten tomato");
            Garbage[] upgradedTomatoes = new Garbage[rottenTomatoes.Length+1];
            for (int i = 0; i < rottenTomatoes.Length; i++)
            {
                upgradedTomatoes[i] = rottenTomatoes[i];
            }
            upgradedTomatoes[upgradedTomatoes.Length-1] = rottenTomato;
            rottenTomatoes = upgradedTomatoes;

            PlasticGarbage milkJug = new PlasticGarbage("plastic milk jug", false);

            if (!milkJug.Cleaned)
            {
                milkJug.Clean();
            }
            PlasticGarbage[] jugs = new PlasticGarbage[0];
            PlasticGarbage[] upgradedJugs = new PlasticGarbage[jugs.Length+1];
            for (int i = 0; i < jugs.Length; i++)
            {
                upgradedJugs[i] = jugs[i];
            }
            upgradedJugs[upgradedJugs.Length-1] = milkJug;
            jugs = upgradedJugs;


            Dustbin1.DisplayContents(rottenTomatoes, jugs, tissues);

            Dustbin1.EmptyContents();

        }
    }
}
