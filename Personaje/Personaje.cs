using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public abstract class Personaje: IMoverse
    {
        public string Nombre="";
        public int Fuerza;
        public int Agilidad;
        public int Magia;
        public int d;
        public string mensaje = "";

        public abstract int CalcularDanio();
        
        public virtual void Atacar() 
        {
        }

        public void MoverseEjeX()
        {
            Console.WriteLine("El personaje se mueve en eje x");
        }

        public void MoverseEjeY()
        {
            Console.WriteLine("El personaje se mueve en eje y");
        }
    }
}
