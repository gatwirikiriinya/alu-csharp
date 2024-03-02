using System;

public class Door : Base, IInteractive
{
    public Door(string name)
    {
        this.name = string.IsNullOrEmpty(name) ? "Door" : name;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
