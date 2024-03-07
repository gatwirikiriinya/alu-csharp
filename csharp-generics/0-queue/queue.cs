using System;

/// <summary>
/// Represents a generic queue class.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Checks the type of elements stored in the queue.
    /// </summary>
    /// <returns>The type of elements stored in the queue.</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
