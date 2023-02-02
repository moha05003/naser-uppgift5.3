using System;
namespace Uppgift5_3
{
    class program
    {
        static void Main()
        {
            string[] frågor = new string[4];
            frågor[0] = ("Vilket är världens största land?");
            frågor[1] = ("Vad är 5*10?");
            frågor[2] = ("När började andra världskriget?");
            frågor[3] = ("Vem är den rikaste personen i världen");
            string[] Svar = new string[4];
            Svar[0] = ("Rysslan");
            Svar[1] = ("50");
            Svar[2] = ("1939");
            Svar[3] = ("Elon Mask");
            Console.WriteLine("Välj vilken typ av fråga du vill ha");
            Console.WriteLine("1.Geografi");
            Console.WriteLine("2.Matte");
            Console.WriteLine("3.Historia");
            Console.WriteLine("4.vänliga frågor");
            string x = Console.ReadLine();
            int y = int.Parse(x);

            Console.WriteLine(frågor[y - 1]);
            string z = Console.ReadLine();
            if (z == Svar[y - 1])
            {
                Console.WriteLine("Du har rätt!");
            }
            else
            {
                Console.WriteLine("Du har fel");
            }


        }
    }
}

