using Akademia_C_sharp;
using System;
using System.Collections.Generic;


namespace aplikacja_na_akademie
{
   

    enum choose                         // enum
    {
        ROUND_PER_MINUTE = 1,
        PRESSURE_ON_SURFACE,
        CREDITS,
        EXIT
    }

    
    
    
    public class main_class

    {
        static void Main(string[] args)
        {

            int option;
            for (;;)
            {
                Console.WriteLine("Program wykonuje zaawansowane obliczenia cech mechaniczno-fizycznych ");
                Console.WriteLine("samochodu Volkswagen Polo 1,4 TDI, rocznik 2000");
                Console.WriteLine("Prawdopodobnie program będzie integralną częścią nowego Need for Speed.");
                Console.WriteLine("Prosze wybrac wlasciwa opcje za pomoca odpowiedniego numeru");
                Console.WriteLine("i zatwierdzic klawiszem ENTER \n");

                List<string> menu = new List<string> { };       //kolekcje
                menu.Add("\t\tMENU GLOWNE");
                menu.Add("\t\t***********");
                menu.Add("\t\t1 - OBROTY SILNIKA");
                menu.Add("\t\t2 - NACISK KOLA NA NAWIERZCHNIE");
                menu.Add("\t\t3 - AUTORZY");
                menu.Add("\t\t4 - WYJSCIE");

                foreach (string wybor in menu)                  //kolekcje
                {
                    Console.WriteLine(wybor);
                }
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Powinna być podana cyfra od 1 do 4");
                    while (true)
                    {
                        Console.Write("Podaj cyfre");
                        try
                        {
                            option = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            continue;
                        }
                    }

                }

                

                switch (option)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("OBROTY SILNIKA\n");
                            RPM Ford = new RPM();
                            Ford.tachometer();
                            break;
                        }

                    case 2:
                        Console.WriteLine("NACISK KOLA NA NAWIERZCHNIE\n");
                        {
                            Console.Clear();
                            int pasazer;
                            Console.WriteLine("Ilu pasazerow znajduje sie w samochodzie (0-4)?");

                            try
                            {
                                pasazer = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Powinna być podana cyfra od 0 do 4");
                                while (true)
                                {
                                    Console.Write("Podaj cyfre");
                                    try
                                    {
                                        pasazer = int.Parse(Console.ReadLine());
                                        break;
                                    }
                                    catch
                                    {
                                        continue;
                                    }
                                }

                            }

                            if (pasazer >= 0 && pasazer <=4)
                            {
                                Polo nacisk = new Polo();
                                nacisk.wheel_pressure(pasazer);
                            }
                            
                            else
                                Console.WriteLine("Auto nie nadaje sie do przewozenia takiej ilosci pasazerow \nWcisnij ENTER by powrocic do menu glownego");

                            break;
                        }
                    case 3:
                        Console.WriteLine("AUTOR\n");
                        {
                            Console.Clear();
                            Credits p1 = new Credits();
                            p1.Name = "Tomasz Wojcik"; // użycie akcesora set
                            Console.WriteLine(p1.Name); // użycie akcesora get

                            break;
                        }
                    case 4: System.Environment.Exit(0); break;
                    default: Console.WriteLine("Nie ma takiej opcji!"); break;
                }
                Console.ReadKey();
                Console.Clear();
            }



        }
    }
}