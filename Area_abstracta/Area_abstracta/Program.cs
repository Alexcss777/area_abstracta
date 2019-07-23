using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_abstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            Clscalculo calculo = new Clscalculo();
            Console.WriteLine("area del cuadrado " + calculo.areacu);
            Console.WriteLine("area del circulo " + calculo.areac);
            Console.ReadKey();



        }
    }
}
