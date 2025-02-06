using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListFunctions
{
    public class TaskList<T> : UniqueList<T>
    {
        public int ItemListCompletedCount { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime? DueDate { get; set; } = null;
        public string Priority { get; set; }
        public DateTime DateModified { get; set; } = DateTime.Now;
        public string DateCreated { get; set; }

        public TaskList()
        {
            DateCreated = DateTime.Now.ToString("MM/dd/yyyy");
        }
        public int ListItemCompleted(T item)
        {
            return ItemListCompletedCount++;
        }

        public int ListItemIncompleted(T item)
        {
            return ItemListCompletedCount--;
        }

        public bool TaskIsCompleted(TaskList<T> taskList)
        {
            if (ItemListCompletedCount == taskList.Count)
            {
                return IsCompleted = true;
            }

            return IsCompleted = false;
        }
    }

}
