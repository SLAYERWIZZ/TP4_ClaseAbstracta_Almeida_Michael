using System;

abstract class Animal
{
    public abstract void animalSound();
}

class Cerdo : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("El cerdo dice: oink oink");
    }
}

class Perro : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("El perro dice: guau guau");
    }
}

class Gato : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("El gato dice: miau miau");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cerdo miCerdo = new Cerdo();
        miCerdo.animalSound();

        Perro miPerro = new Perro();
        miPerro.animalSound();

        Gato miGato = new Gato();
        miGato.animalSound();
    }
}
