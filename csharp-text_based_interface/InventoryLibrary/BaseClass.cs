using System;

public class BaseClass {

    public string? id;
    public DateTime date_created;
    public DateTime date_updated;

    public BaseClass()
    {
        id = Guid.NewGuid().ToString();
        date_created = DateTime.Now;
        date_updated = date_created;
    }
}
