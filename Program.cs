using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;
using System.Threading;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int tank_length=5;
            Tank[] T34=new Tank[tank_length];
            Tank[] pantera=new Tank[tank_length];

           
            for (int i = 0; i < tank_length; i++)
            {
                Tank t = new Tank("T34");
                Thread.Sleep(50); //без  этого метода у танков параметры одинаковые и постоянно  ничья происходит
                Tank p = new Tank("Pantera");
                T34[i] = t;
                pantera[i] = p;     
            }

            for (int i = 0; i < tank_length; i++)
            {
                Console.Write($"Battle №{i+1}: ");
                int result=-2;
                result = T34[i] * pantera[i];
                if (result == -1)
                    Console.WriteLine($"танк {T34[i].Name} победил танк {pantera[i].Name}");
                else if (result == 0)
                    Console.WriteLine("ничья");
                else
                    Console.WriteLine($"танк {pantera[i].Name} победил танк {T34[i].Name}");

            }
             
            
            Console.Read();
         
        }
    }
}
