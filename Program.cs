using System;

namespace ConsoleTriviant
{
    class Program

    {
        static int Score = 0; // aantal vragen goed
        static string Vraag = "In welk jaar overleed de zanger Michael Jackson?";
        static string[] Antwoorden = { "1990", "2005", "2009", "2008" };
        static int JuisteAntwoord = 1; // index van array met juiste antwoorden
        static void Main(string[] args)




        
        {
            Console.WriteLine("Welkom bij Triviant!");
            Console.WriteLine("Je zal een vraag zien op het scherm");
            Console.WriteLine("Je ziet 4 antwoorden");
            Console.WriteLine("Kies het juiste antwoord en je zal het resultaat zien. Starten? Druk op enter :)");
            Console.ReadLine();
            showVraag(1);
            showAntwoorden();
            try
            {
                int Antwoord = int.Parse(Console.ReadLine());

                switch (checkAntwoord(Antwoord))
                {
                    case 1:
                        Console.WriteLine("Goed gedaan!");
                        Score++;
                        break;
                    case 0:
                        Console.WriteLine("Dat is helaas niet het juiste antwoord. Het antwoord is " + Antwoorden[JuisteAntwoord]);
                        break;
                    case 99:
                        Console.WriteLine("Dit is geen geldige invoer.");
                        break;

                }




            }

            catch (Exception e)
           
            {
                Console.WriteLine(e.Message);
            }




            Console.ReadLine();


        }
        static void showVraag(int Nr)
        {
            Console.WriteLine("Vraag " + Nr + " : ");
            Console.WriteLine(Vraag);
            Console.WriteLine("");

        }

        static void showAntwoorden()
        {

            int teller = 0;
            foreach (string antwoord in Antwoorden)
            {
                teller++;
                Console.WriteLine((teller) + ". " + antwoord);

            }

            Console.WriteLine("");
            Console.WriteLine("type uw keuze in : 1, 2, 3 of 4");


        }

        static int checkAntwoord(int Antw)
        {
          if (Antw == JuisteAntwoord + 1)
            {
                return 1;
            }
          else if (Antw > 4)
            {
                return 99;
            }
          else
            {
                return 0;
            }








        }
    }
}
