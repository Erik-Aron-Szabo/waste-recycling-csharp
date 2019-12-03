using System.Linq;
using System.Collections.Generic;
using System;

namespace WasteRecycling
{
    public class Dustbin
    {
        public string Color { get; set; }
        public PaperGarbage[] PaperContent = new PaperGarbage[4]; 

        public PlasticGarbage[] PlasticContent = new PlasticGarbage[4];

        public Garbage[] HouseWasteContent = new {"cookies", "wine", "toys"};


        public void DisplayContents(Garbage[] houseWasteContent, PlasticGarbage[] plasticContent, PaperGarbage[] paperContent)
        {
            System.Console.WriteLine(Color + " Dustbin!");

            System.Console.WriteLine("House Waste Content: " + HouseWasteContent.Length + "item(s)");
            houseWasteContent.ForEach(Console.WriteLine);





        }


    }
}
