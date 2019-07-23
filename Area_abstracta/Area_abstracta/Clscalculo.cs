using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_abstracta
{
    public class Clscalculo : ClsArea
    {

       public Clscalculo()
        {
            areac = 0;
            areacu = 0;
            lado = 0;
            radio = 0;
            rad = string.Empty;
            lad = string.Empty;

            Console.WriteLine("ingresa el lado del cuadrado");
            lad= Console.ReadLine();
            lado = Convert.ToDouble(lad);
            Console.WriteLine("ingresa el radio del circulo");
            rad = Console.ReadLine();
            radio = Convert.ToDouble(rad);
            areac = 3.1416 * Math.Pow(radio, 2);
            areacu = lado * 4;





        }






        public override double areacu {get; set;}
        public override double areac { get; set; }

        public override double lado { get; set; }
        public override double radio { get; set; }
        public override string rad { get; set; }
        public override string lad { get; set; }









    }
}
