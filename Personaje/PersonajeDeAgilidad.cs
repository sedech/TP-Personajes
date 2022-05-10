using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class PersonajeDeAgilidad: Personaje
    {
        public PersonajeDeAgilidad(string Name, int Agility, int Magic, int Strength)
        {
                Nombre = Name;
                Agilidad = Agility;
                Magia = Magic;
                Fuerza = Strength;
        }
        public override int CalcularDanio()
        {
            d = Fuerza / 2 * Agilidad * Magia / 2;
            return d;
        }
    }
}
