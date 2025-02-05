using System;
using System.Collections.Generic;

//Created a new class that inherits from List<T>
//Making this new class will allow us to add new methods to the List<T> class that do not retain duplicate items
//Originally had it as just UniqueList but then we didn't have access to the List<T> methods (.Add, Remove, etc.)
//I did ask copilot for help with this. Let's try to speed up our development process and use copilot to help us

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
