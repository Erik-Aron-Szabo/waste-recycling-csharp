using System.Linq;
using System.Collections.Generic;
using System;

namespace WasteRecycling
{
    public class Dustbin
    {
        public string Color { get; set; }
        public PaperGarbage[] PaperContent = new PaperGarbage[2]; 

        public PlasticGarbage[] PlasticContent = new PlasticGarbage[2];

        public Garbage[] HouseWasteContent = new Garbage[2];


        public Dustbin(string color)
        {   
            Color = color;
        }



        public void DisplayContents(Garbage[] houseWasteContent, PlasticGarbage[] plasticContent, PaperGarbage[] paperContent)
        {
            System.Console.WriteLine(Color + " Dustbin!");

            System.Console.WriteLine("House Waste Content: " + HouseWasteContent.Length + "item(s)");
            for (int i = 0; i < HouseWasteContent.Length; i++)
            {
                System.Console.WriteLine(HouseWasteContent[i]);
            }

            System.Console.WriteLine("Paper content: " + PaperContent.Length + " item(s)");
            for (int i = 0; i < PaperContent.Length; i++)
            {
                System.Console.WriteLine(PaperContent[i]);
            }

            System.Console.WriteLine("Plastic content: " + PlasticContent.Length + " item(s)");
            for (int i = 0; i < PlasticContent.Length; i++)
            {
                System.Console.WriteLine(PlasticContent[i]);
            }




        }

        public void ThrowOutGarbage(Garbage garbage)
        {
            
            // Plastic Garbage
            if (garbage is PlasticGarbage)
            {
                PlasticGarbage newgarbage1 = (PlasticGarbage)garbage;
                if (!newgarbage1.isCleaned())
                {
                    throw new DustbinContentException("exception!");
                }
                else {
                    PlasticGarbage[] newPlasticContent = 
                }

            } 

            //Paper Garbage
            if (garbage is PaperGarbage)
            {
                PaperGarbage newgarbage2 = (PaperGarbage)garbage;
                if (!newgarbage2.isSqueezed())
                {
                    throw new DustbinContentException("exception!");
                }
                else {
                    PaperGarbage[] newPaperContent = 
                }


            }



            
        }



        public void EmptyContents()
        {
            Array.Clear(PlasticContent, 1, PlasticContent.Length);
        }



    }
}
