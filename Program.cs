using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikacja_na_akademie
{
    public class Samochod                           //1 klasa
    {
        protected int bieg;                         //enkapsulacja
        protected int predkosc;                     //enkapsulacja
        protected int masa=2500;
    }

    public interface ICisnienie                     //1 interfejs
    {
        int nacisk_kola();
    }

   
    public class Polo:Samochod, ICisnienie                    //2 klasa //polimorfizm //interfejs
    {
        int cisnienie;
        
        public int nacisk_kola()
        {
            masa = masa+70*0;
            cisnienie = 10*masa / 4;
            Console.WriteLine("\nNacisk pojedynczego kola na nawierzchnie wynosi "+cisnienie + " N");
            Console.WriteLine("Wcisnij ENTER by powrocic do menu glownego");
            return cisnienie;
        }
    }

    public class Polo1 : Samochod, ICisnienie
    {
        protected int cisnienie;                    

        public int nacisk_kola()
        {
            masa = masa+70*1;
            cisnienie = 10*masa / 4;
            Console.WriteLine("\nNacisk pojedynczego kola na nawierzchnie wynosi " + cisnienie + " N");
            Console.WriteLine("Wcisnij ENTER by powrocic do menu glownego");
            return cisnienie;
        }


    }

    public class Polo2 : Samochod, ICisnienie
    {
        protected int cisnienie;

        public int nacisk_kola()
        {
             masa = masa + 70 * 2;
            cisnienie = 10*masa / 4;
            Console.WriteLine("\nNacisk pojedynczego kola na nawierzchnie wynosi " + cisnienie + " N");
            Console.WriteLine("Wcisnij ENTER by powrocic do menu glownego");
            return cisnienie;
        }
  

    }

    public class Polo3 : Samochod, ICisnienie
    {
        protected int cisnienie;

        public int nacisk_kola()
        {
            masa = masa + 70 * 3;
            cisnienie = 10*masa / 4;
            Console.WriteLine("\nNacisk pojedynczego kola na nawierzchnie wynosi " + cisnienie + " N");
            Console.WriteLine("Wcisnij ENTER by powrocic do menu glownego");
            return cisnienie;
        }
       

    }

 enum wybor                           // enum
        {
            OBROTY_SILNIKA=1,
            NACISK_KOLA_NA_NAWIERZCHNIE,
            AUTORZY,
            WYJSCIE
    }
    


   

    public class Zegary : Samochod              // dziedziczenie
    {
        public int obroty;
        public int obrotosciomierz()
        {
            Console.WriteLine("Dla jakiej predkosci chcesz sprawdzić obroty silnika? (km/h)");

        

            try
            {
                predkosc = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Prosze podac predkosc od 0 do 300 km/h");
                while (true)
                {
                    Console.Write("Podaj predkosc w km/h\n");
                    try
                    {
                        predkosc = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }

            }

            if (predkosc > 300)
            {
                Console.WriteLine("\nNo bez przesady!");
            }
            
            Console.WriteLine("\nDla którego biegu chcesz sprawdzić obroty silnika?");
            
            try
            {
                bieg = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Prosze podac numer biegu jako cyfre");
                while (true)
                {
                    Console.Write("Podaj analizowany bieg\n");
                    try
                    {
                        bieg = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                    
                }
                
            }
            if (bieg > 6)
            {
                Console.WriteLine("\nNie bede reagowal na glupie zaczepki, VW Polo ma tylko 5 biegow.");
                Console.WriteLine("Ale gdyby mialo "+bieg+" to obroty bylyby rowne");
            }

            obroty = predkosc*100 / bieg;
            Console.WriteLine("\n"+obroty+" obrotow na minute.\nWcisnij ENTER by powrocic do menu glownego");
            return obroty;
        }

    }

    public class Autor
    {
        private string imie;                    //enkapsulacja
        public string Imie 
        {
            get { return imie; }                //propercje
            set { imie = value; }               //propercje
        }

    }

    public class main_class

    {
        static void Main(string[] args)
        {
            
        int opcja;
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
                    opcja = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Powinna być podana cyfra od 1 do 4");
                    while (true)
                    {
                        Console.Write("Podaj cyfre");
                        try
                        {
                            opcja = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            continue;
                        }
                    }

                }
              


                switch (opcja)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("OBROTY SILNIKA\n");
                            Zegary Ford = new Zegary();
                            Ford.obrotosciomierz();
                            break;
                        }

                    case 2:
                        Console.WriteLine("NACISK KOLA NA NAWIERZCHNIE\n");
                        {
                            Console.Clear();
                            int pasazer;
                            Console.WriteLine("Ilu pasazerow znajduje sie w samochodzie (0-3)?");
                            
                            try
                            {
                                pasazer = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Powinna być podana cyfra od 0 do 3");
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

                            if (pasazer == 0)
                            {
                                Polo nacisk = new Polo();
                                nacisk.nacisk_kola();
                            }
                            else
                                if (pasazer == 1)
                            {
                                Polo1 nacisk = new Polo1();
                                nacisk.nacisk_kola();
                            }
                            else
                                     if (pasazer == 2)
                            {
                                Polo2 nacisk = new Polo2();
                                nacisk.nacisk_kola();
                            }
                            else if (pasazer == 3)
                            {
                                Polo3 nacisk = new Polo3();
                                nacisk.nacisk_kola();
                            }
                            else
                                Console.WriteLine("Auto nie nadaje sie do przewozenia takiej ilosci pasazerow \nWcisnij ENTER by powrocic do menu glownego");

                            break;
                        }
                    case 3:
                        Console.WriteLine("AUTOR\n");
                        {
                            Console.Clear();
                            Autor p1 = new Autor();
                            p1.Imie = "Tomasz Wojcik"; // użycie akcesora set
                            Console.WriteLine(p1.Imie); // użycie akcesora get
                           
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