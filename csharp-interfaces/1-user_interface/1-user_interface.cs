using System;
using System.Collections.Generic;
using System.Reflection;

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

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int Durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool IsCollected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Interact()
    {
        // Implement interaction behavior here
    }

    public void Break()
    {
        // Implement break behavior here
    }

    public void Collect()
    {
        // Implement collect behavior here
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
