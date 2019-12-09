using System.Linq;
using System.Collections.Generic;
using System;

namespace WasteRecycling
{
    public class Dustbin
    {
        public string Color { get; set; }
        public PaperGarbage[] PaperContent = new PaperGarbage[0]; 

        public PlasticGarbage[] PlasticContent = new PlasticGarbage[0];

        public Garbage[] HouseWasteContent = new Garbage[0];


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
                if (!(newgarbage1.isCleaned()))
                {
                    throw new DustbinContentException("exception!");
                }
                else {
                    PlasticGarbage[] Temp = new PlasticGarbage[PlasticContent.Length+1];
                    for (int i = 0; i < PlasticContent.Length; i++)
                    {
                        Temp[i] = newgarbage1;

                    }
                    Temp[Temp.Length-1] = newgarbage1;
                    PlasticContent = Temp;
                }

            } 

            //Paper Garbage
            else if (garbage is PaperGarbage)
            {
                PaperGarbage newgarbage2 = (PaperGarbage)garbage;
                if (!(newgarbage2.isSqueezed()))
                {
                    throw new DustbinContentException("exception!");
                }
                else {
                    PaperGarbage[] Temp = new PaperGarbage[PaperContent.Length+1];
                    for (int i = 0; i < PaperContent.Length; i++)
                    {
                        Temp[i] = newgarbage2;

                    }
                    Temp[Temp.Length-1] = newgarbage2;
                    PaperContent = Temp;
                }


            }

            else if (garbage is Garbage)
            {
                Garbage newgarbage3 = (Garbage)garbage;
                Garbage[] Temp = new Garbage[HouseWasteContent.Length+1];
                for (int i = 0; i < HouseWasteContent.Length; i++)
                    {
                        Temp[i] = HouseWasteContent[i];
                    }
                Temp[Temp.Length-1] = newgarbage3;
                HouseWasteContent = Temp;



            }
            
            else if (!(garbage is Garbage) && !(garbage is PaperGarbage) && !(garbage is Garbage))
            {
                throw new DustbinContentException("exception!");
            }


            
        }



        public void EmptyContents()
        {
            PlasticContent = new PlasticGarbage[0];
            PaperContent = new PaperGarbage[0];
            HouseWasteContent = new Garbage[0];

        }



    }
}
