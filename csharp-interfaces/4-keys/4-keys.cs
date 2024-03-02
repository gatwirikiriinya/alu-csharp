using System;

public class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name, bool isCollected = false)
    {
        this.name = string.IsNullOrEmpty(name) ? "Key" : name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (!isCollected)
        {
            Console.WriteLine($"You pick up the {name}.");
            isCollected = true;
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
