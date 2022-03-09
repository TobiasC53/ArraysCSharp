using System;

namespace ArraysCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Note = 0;
            int AnzahlSchüler = 0;
            double Notenschnitt = 0;
            string name = "TobiasC53";

            Console.WriteLine("Wie viele Schüler sind in ihrer Klasse?");
            AnzahlSchüler = Convert.ToInt32(Console.ReadLine());

            string[] namen = new string[AnzahlSchüler];

            int[] noten = new int[AnzahlSchüler];

            for (int AnzahlS = 0; AnzahlS < AnzahlSchüler; AnzahlS++)
            {

                bool flag = false;
                do
                {
                    Console.WriteLine("Schüler Name {0}", AnzahlS + 1);
                    name = Console.ReadLine();

                    namen[AnzahlS] = name;

                    Console.WriteLine("{0}'s Note:", name);
                    Note = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (Note > 0 && Note <= 6)
                    {
                        noten[AnzahlS] = Note;
                        Notenschnitt = Notenschnitt + Note;
                        flag = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Die Note {0} existiert nicht bitte versuche es noch einmal", Note);
                        AnzahlSchüler = 0;
                        flag = false;
                    }
                } while (flag==false);


            }



            for (int Ausgabe = 0; Ausgabe < AnzahlSchüler; Ausgabe++)
            {
                Console.WriteLine(namen[Ausgabe] + "|" + "\tNote:" + "|" + noten[Ausgabe]);

            }
            Console.WriteLine("Der Notendurchschnitt beträgt:{0:F2}", Notenschnitt / AnzahlSchüler);






        }
    }
}
