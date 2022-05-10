

using TP2;

PersonajeDeAgilidad agil = new("persoagi", 2, 3, 4);
Console.WriteLine( agil.CalcularDanio());
Enemigo mono = new();
Turno.MoverFichas(mono);
Turno.MoverFichas(agil);