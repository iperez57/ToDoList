using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListFunctions
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }
    public class TaskList<T> : UniqueList<T>
    {
        public int ItemListCompletedCount { get; set; }
        public bool IsCompleted { get; set; } = false;
        public string DueDate { get; set; } = null;
        public TaskPriority Priority { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }

        public TaskList()
        {
            DateCreated = DateTime.Today;
            DateModified = DateTime.Today;
            DateCreated.ToString("D");
            DateModified.ToString("D");
        }

        public void SetDueDate(int year, int month, int day)
        {
            DateTime dueDate = new DateTime(year, month, day);
            if (dueDate >= DateTime.Today)
            {
                DueDate = dueDate.ToString("D");
            }
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
