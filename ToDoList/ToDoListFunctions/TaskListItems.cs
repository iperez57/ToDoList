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
        public decimal CompletionPercentage { get; set; }
        public string DueDate { get; set; } = null;
        public DateTime DueDateActual { get; set; }
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
                DueDateActual = dueDate;
                DueDate = dueDate.ToString("D");
            }
        }

        public void ListItemCompleted(TaskList<T> taskList, T item)
        {
            ItemListCompletedCount++;
            TaskCompletionPercentage(taskList);
            TaskIsCompleted(taskList);
        }

        public void ListItemIncompleted(TaskList<T> taskList, T item)
        {
            ItemListCompletedCount--;
            TaskCompletionPercentage(taskList);
            TaskIsCompleted(taskList);
        }

        public bool TaskIsCompleted(TaskList<T> taskList)
        {
            if (ItemListCompletedCount == taskList.Count)
            {
                return IsCompleted = true;
            }

            return IsCompleted = false;
        }

        public void TaskCompletionPercentage(TaskList<T> taskList)
        {
            decimal percentageCompleted = Math.Round((decimal)ItemListCompletedCount / taskList.Count * 100, 2);
            CompletionPercentage = percentageCompleted;
        }
    }

}
