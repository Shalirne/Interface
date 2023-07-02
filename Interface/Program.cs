using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var a = new Quadcopter();
            a.Charge();
            a.GetComponents();
            a.GetInfo();
        }
    }

}
    
