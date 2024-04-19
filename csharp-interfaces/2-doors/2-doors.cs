using System;
using System.Collections.Generic;

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int Durability { get; set; }
    void Break();
}

public interface ICollectable
{
    bool IsCollected { get; set; }
    void Collect();
}

public class Door : Base, IInteractive
{
    public Door(string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

public abstract class Base
{
    public string? name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}
