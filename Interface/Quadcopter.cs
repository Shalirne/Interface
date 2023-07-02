using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };
        public List<string> GetComponents()
        {

            return components;
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public string GetInfo()
        {
            Console.WriteLine("Я работаю");
            return "Я робот";
        }
    }
}
