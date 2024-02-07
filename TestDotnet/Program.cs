using System;

using static System.Console;

class Player
{
    private string name;

    private int health = 100;

    private int damage = 5;

    private bool gender = true;

    private int speed = 10;

    public void setGender()
    {
        bool flag = bool.TryParse(ReadLine(), out gender);
        do
        {
            WriteLine("Ese no es un genero, Introduce un Genero Valido:");
            flag = bool.TryParse(ReadLine(), out gender);
        }
        while (!flag);
        
        if (gender)
        {
            WriteLine("AHHH Un Tioooo!!!");
        }
        else
        {
            WriteLine("Seguro que eres una chica ? ,':B");
        }
    }

    public void setName()
    {
        name = ReadLine();
    }

    public void Walk()
    {
        WriteLine($"{name} esta caminando");
    }

    public void setDefaultStats()
    {
        health = 100;
        damage = 5;
        speed = 10;
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player();
        player.setGender();
    }

    void ChooiseFacction(Player player)
    {
        WriteLine($"Selecciona tu Clase: 1-Wizard\n2-Knight\n3-Paladin\n4-Hunter\n");
    }
}
