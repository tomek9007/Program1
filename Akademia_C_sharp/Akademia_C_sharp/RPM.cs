using System;

namespace Akademia_C_sharp
{
    public class RPM : Car, IRPM             // dziedziczenie, interfejs

    {
        public int rounds_per_minute;
        public int tachometer()
        {
            Console.WriteLine("Dla jakiej predkosci chcesz sprawdzić obroty silnika? (km/h)");
            
            try
            {
                speed = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Prosze podac predkosc od 0 do 300 km/h");
                while (true)
                {
                    Console.Write("Podaj predkosc w km/h\n");
                    try
                    {
                        speed = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }

            }

            if (speed > 300)
            {
                Console.WriteLine("\nNo bez przesady!");
            }

            Console.WriteLine("\nDla którego biegu chcesz sprawdzić obroty silnika?");

            try
            {
                gear = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Prosze podac numer biegu jako cyfre");
                
                while (true)
                {
                    Console.Write("Podaj analizowany gear\n");
                    try
                    {
                        gear = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        continue;
                    }

                }

            }
            if (gear > 6)
            {
                Console.WriteLine("\nNie bede reagowal na glupie zaczepki, VW Polo ma tylko 5 biegow.");
                Console.WriteLine("Ale gdyby mialo " + gear + " to obroty bylyby rowne");
            }

            rounds_per_minute = speed * 100 / gear;
            Console.WriteLine("\n" + rounds_per_minute + 
            " obrotow na minute.\nWcisnij ENTER by powrocic do menu glownego");
            return rounds_per_minute;
        }

    }
}
