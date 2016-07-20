using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia_C_sharp
{
    public class Polo : Car, IPolo                //2 klasa //polimorfizm //interfejs

    {
        private int area;
        private int area_contact;

        

        public override int wheel_pressure(int passenger)
        {
            pressure_correction();
            weight = weight + 70 * passenger;
            pressure = 10 * weight / 4 + area_contact;
            Console.WriteLine("\nNacisk pojedynczego kola na nawierzchnie wynosi " + pressure + " N");
            Console.WriteLine("Wcisnij ENTER by powrocic do menu glownego");
            return pressure;
        }

        public int contact()
        {

            int contact_width = 15;
            int contact_length = 15;

            return area = contact_width * contact_length;   // powierzchnia styku koła z nawierzchnia przy 200 kPa
        }

        public int pressure_correction()
        {
            int pumping;

            Console.WriteLine("Jak mocno napompowano opony?");
            Console.WriteLine("(prawidlowe cisnienie powinno zawierać się między 200-300 kPa,");
            Console.WriteLine("jednak program moze obliczyc cisnienie dla dowolnych wartosci");
            try
            {
                pumping = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)                                                        // wyjatek
            {
                Console.WriteLine(ex.Message+"Prosze podac cisnienie jako liczbe");     
                while (true)
                {
                    try
                    {
                        pumping = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                       continue;
                    }
                }
            }
            


            area_contact = area - (pumping - 200) * 50 / 100;

            return area_contact;
        }

    }

}


           
