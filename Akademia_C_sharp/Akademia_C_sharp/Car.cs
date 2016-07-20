using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia_C_sharp
{
    public class Car : ICar                            //1 klasa
    {
        protected int gear;                         //enkapsulacja
        protected int speed;                        //enkapsulacja
        protected int weight = 2500;
        protected int pressure;
        

        public virtual int wheel_pressure(int pasazer)
        {
            weight = weight + 70 * 0;
            pressure = 10 * weight / 4;
            Console.WriteLine("\nNacisk pojedynczego kola na nawierzchnie wynosi " + pressure + " N");
            Console.WriteLine("Wcisnij ENTER by powrocic do menu glownego");
            return pressure;
        }
    }
}
