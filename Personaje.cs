using System;

public class Personaje
{
    // 1 Constructor
    public Personaje(string nombre)
    {
        Nombre = nombre;
    }

    // 1 Parámetro y 1 Método
    public virtual void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre}.");
    }

    public string Nombre { get; }
}

// Clase que Hereda de Personaje
public class Jugador : Personaje
{
    // Constructor con herencia
    public Jugador(string nombre) : base(nombre)
    {
    }

    // Polimorfismo: sobrescribe el método Atacar
    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} lanza un hechizo a {objetivo.Nombre}.");
    }
}

// Clase de un enemigo, también hereda de Personaje
public class Enemigo : Personaje
{
    // Constructor con herencia
    public Enemigo(string nombre) : base(nombre)
    {
    }

    // Polimorfismo: sobrescribe el método Atacar
    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} gruñe y muerde a {objetivo.Nombre}.");
    }
}