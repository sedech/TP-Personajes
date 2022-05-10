using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
        public class PersonajeDeFuerza: Personaje
        {
            public PersonajeDeFuerza(string Name, int Agility, int Magic)
            {
                Nombre = Name;
                Fuerza = 100;
                Agilidad = Agility;
                Magia = Magic;  
            }
            public override int CalcularDanio()
            { 
                 d = Fuerza * 20 + Agilidad * 10 + Magia * 30 ;
                return d;
            }
        }
}
