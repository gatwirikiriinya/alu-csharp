using System;

public class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }
    public int durability { get; set; }

    public Decoration(string name, int durability = 1, bool isQuestItem = false)
    {
        this.name = string.IsNullOrEmpty(name) ? "Decoration" : name;
        this.durability = durability <= 0 ? 1 : durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    public void Break()
    {
        if (durability > 0)
        {
            durability--;
            if (durability > 0)
                Console.WriteLine($"You hit the {name}. It cracks.");
            else
                Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
