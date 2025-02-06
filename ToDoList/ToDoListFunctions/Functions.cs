using System;
using System.Collections.Generic;

public class UniqueList<T> : List<T>
{
    public new bool Add(T item)
    {
        if (this.Contains(item))
        {
            return false; // Item is a duplicate, do not add
        }
        else
        {
            base.Add(item); // Call the base class's Add method
            return true; // Item added successfully
        }
    }

}