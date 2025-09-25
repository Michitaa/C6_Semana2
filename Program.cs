using System;

class Program
{
    static void Main(string[] args)
    {
        var heroe = new Jugador("Aragorn");
        var orco = new Enemigo("Grúb");

        // Usar los métodos polimórficos
        heroe.Atacar(orco); // Salida: Aragorn lanza un hechizo a Grúb.
        orco.Atacar(heroe); // Salida: Grúb gruñe y muerde a Aragorn.

        Console.ReadKey();
    }
}