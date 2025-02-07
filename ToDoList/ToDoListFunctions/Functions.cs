using System;
using System.Collections.Generic;
using ToDoListFunctions;

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

    public void SortByPriority(UniqueList<TaskList<string>> toDoList)
    {
        for (int i = 0; i < toDoList.Count; i++)
        {
            for (int j = i + 1; j < toDoList.Count; j++) // j should start at i+1
            {
                if (toDoList[i].Priority < toDoList[j].Priority)
                {
                    var placeholder = toDoList[i];
                    toDoList[i] = toDoList[j];
                    toDoList[j] = placeholder;
                }
            }
        }
    }

    public void SortByDueDate(UniqueList<TaskList<string>> toDoList)
    {
        for (int i = 0; i < toDoList.Count; i++)
        {
            for (int j = i + 1; j < toDoList.Count; j++) // j should start at i+1
            {
                if (toDoList[i].DueDateActual > toDoList[j].DueDateActual)
                {
                    var placeholder = toDoList[i];
                    toDoList[i] = toDoList[j];
                    toDoList[j] = placeholder;
                }
            }
        }
    }

}