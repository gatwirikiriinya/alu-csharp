using System;
using System.Collections.Generic;

public static class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            if (obj.GetType().GetInterfaces().Contains(type))
            {
                if (type == typeof(IInteractive))
                    ((IInteractive)obj).Interact();
                else if (type == typeof(IBreakable))
                    ((IBreakable)obj).Break();
                else if (type == typeof(ICollectable))
                    ((ICollectable)obj).Collect();
            }
        }
    }
}
