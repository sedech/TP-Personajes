using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Enemigo: IMoverse
    {
        public  int vida  { get; set; }
        public int nivel { get; set; }

        public void MoverseEjeX()
        {
            Console.WriteLine("El enemigo se va mover en Eje X");
        }

        public void MoverseEjeY()
        {
            Console.WriteLine("El enemigo se va mover en Eje Y");
        }
    }
}
