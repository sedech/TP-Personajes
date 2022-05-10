using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string Name, int Agility, int Magic, int Strength)
        {
            Nombre = Name;
            Agilidad = Agility;
            Magia = Magic;
            Fuerza = Strength;
        }
        public PersonajeDeMagia(string Name, int Agility, int Strength)
        {
            Nombre = Name;
            Agilidad = Agility;
            Magia = 60;
            Fuerza = Strength;
        }

        public override int CalcularDanio()
        {
            d = Fuerza + Agilidad + Magia * 4;
            return d;
        }

        public override void Atacar()
        {

            Console.WriteLine("$ {Nombre} hizo {d} decimal daño gracias a su magia");
        }

    }
}
