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

public class Decoration : Base, IInteractive, IBreakable
{
    public bool IsQuestItem { get; private set; }
    public int Durability { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        IsQuestItem = isQuestItem;
        this.name = name;
        Durability = durability > 0 ? durability : throw new Exception("Durability must be greater than 0");
    }

    public void Interact()
    {
        if (Durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (IsQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    public void Break()
    {
        Durability--;

        if (Durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (Durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

public class Key : Base, ICollectable
{
    public bool IsCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        IsCollected = isCollected;
    }

    public void Collect()
    {
        if (!IsCollected)
        {
            IsCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

public class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            if (obj is IInteractive interactive && type == typeof(IInteractive))
            {
                interactive.Interact();
            }
            else if (obj is IBreakable breakable && type == typeof(IBreakable))
            {
                breakable.Break();
            }
            else if (obj is ICollectable collectable && type == typeof(ICollectable))
            {
                collectable.Collect();
            }
        }
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
