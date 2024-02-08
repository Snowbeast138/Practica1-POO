using System;

using static System.Console;

class Player
{
    private string name;

    private float health = 100;

    private float damage = 5;

    private bool gender = true;

    private float speed = 10;

    public void setGender()
    {
        WriteLine("Elige tu Genero:\nTrue=Hombre\nFalse-Mujer");
        bool flag = bool.TryParse(ReadLine(), out gender);
        do
        {
            WriteLine("Ese no es un genero, Introduce un Genero Valido:");
            flag = bool.TryParse(ReadLine(), out gender);
        }
        while (!flag);

        if (gender)
        {
            WriteLine("Okay :D eres un chico eh");
        }
        else
        {
            WriteLine("Okay eres una chica eh? :D");
        }
    }

    public void setName()
    {
        WriteLine("Introduce tu Nombre");
        name = ReadLine();
        WriteLine($"Bienvenido {name}");
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

    public void incressStats(float boost)
    {
        health *= boost;
        damage *= boost;
        speed *= boost;
    }

    public void showStats()
    {
        WriteLine($"|||  {name}  |||\nVIDA:{health}     DAÑO:{damage}   VELOCIDAD:{speed}");
        if(gender){
            WriteLine("Sexo:Hombre");
        }else{
            WriteLine("Sexo:Mujer");
        }
    }
}

class Wizard : Player
{
    public float boost = 1.1F;
    public void Fireball()
    {
        WriteLine($"Haz Lanzado una Bola de Fuego");
    }
}

class Knight : Player
{
    public float boost = 2.5F;

    public void Thrust()
    {
        WriteLine("Ha Dado una estocada");
    }
}

class Paladin : Player
{
    public float boost = 1.5F;
    public void Heal()
    {
        WriteLine("Se ah Curado");
    }
}

class Hunter : Player
{
    public float boost = 2F;

    public void AxeAttack()
    {
        WriteLine("A metido un Hachazo");
    }
}

class Program
{
    static void Main()
    {
        ChooiseFacction();
    }

    public static void ChooiseFacction()
    {
        int res;
        bool flag;
        do
        {
            WriteLine($"Selecciona tu Clase:\n1-Wizard\n2-Knight\n3-Paladin\n4-Hunter\n");
            flag = int.TryParse(ReadLine(), out res);
            if (res < 1 || res > 4)
            {
                flag = false;
            }
        }
        while (!flag);

        switch (res)
        {
            case 1:{
                Wizard wizard = new();
                wizard.setGender();
                wizard.setName();
                wizard.incressStats(wizard.boost);
                wizard.showStats();
            }break;
            case 2:{
                Knight knight = new();
                knight.setGender();
                knight.setName();
                knight.incressStats(knight.boost);
                knight.showStats();
            }break;
            case 3:{
                Paladin paladin = new();
                paladin.setGender();
                paladin.setName();
                paladin.incressStats(paladin.boost);
                paladin.showStats();
            }break;
            case 4:{
                Hunter hunter = new();
                hunter.setGender();
                hunter.setName();
                hunter.incressStats(hunter.boost);
                hunter.showStats();
            }break;
            default:
                {
                    WriteLine("");
                }break;
        }
    }
}
