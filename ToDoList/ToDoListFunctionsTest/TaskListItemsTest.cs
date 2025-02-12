using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListFunctions;

namespace ToDoListFunctionsTest
{
    [TestClass]
    public  class TaskListItemsTest
    {
        #region Task Attributes
        [TestMethod]
        public void SetTaskDueDate()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            toDoList.Add(cleanHouse);
            DateTime dateTime = DateTime.Today;
            int day = Convert.ToInt32(dateTime.ToString("dd"));
            int month = Convert.ToInt32(dateTime.ToString("MM"));
            int year = Convert.ToInt32(dateTime.ToString("yyyy"));
            cleanHouse.SetDueDate(year, month, day);
            string result = DateTime.Today.ToString("D");
            Assert.AreEqual(result, cleanHouse.DueDate);
        }
        [TestMethod]
        public void CreateTaskDueDateNul()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            toDoList.Add(cleanHouse);

            Assert.IsNull(cleanHouse.DueDate);
            //We would need to add a due date attribute to the task
        }
        #endregion

        #region Task Status
        [TestMethod]
        public void MarkListItemAsComplete()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Add("Sweep");
            cleanHouse.Add("Dust");
            toDoList.Add(cleanHouse);
            cleanHouse.ListItemCompleted(cleanHouse, "Mop");
            cleanHouse.ListItemCompleted(cleanHouse, "Sweep");
            Assert.AreEqual(2, cleanHouse.ItemListCompletedCount);

        }
        [TestMethod]
        public void UnmarkListItemAsComplete()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Add("Sweep");
            cleanHouse.Add("Dust");
            toDoList.Add(cleanHouse);

            cleanHouse.TaskIsCompleted(cleanHouse);
            Assert.AreEqual(false, cleanHouse.TaskIsCompleted(cleanHouse));
            cleanHouse.ListItemCompleted(cleanHouse, "Mop");
            cleanHouse.ListItemCompleted(cleanHouse, "Sweep");
            cleanHouse.ListItemCompleted(cleanHouse, "Dust");
            cleanHouse.ListItemIncompleted(cleanHouse, "Mop");
            Assert.AreEqual(false, cleanHouse.TaskIsCompleted(cleanHouse));
            Assert.AreEqual(2, cleanHouse.ItemListCompletedCount);
        }
        [TestMethod]
        public void MarkTaskAsComplete()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Add("Sweep");
            cleanHouse.Add("Dust");
            toDoList.Add(cleanHouse);

            cleanHouse.TaskIsCompleted(cleanHouse);
            Assert.AreEqual(false, cleanHouse.TaskIsCompleted(cleanHouse));
            cleanHouse.ListItemCompleted(cleanHouse, "Mop");
            cleanHouse.ListItemCompleted(cleanHouse, "Sweep");
            cleanHouse.ListItemCompleted(cleanHouse, "Dust");
            Assert.AreEqual(true, cleanHouse.TaskIsCompleted(cleanHouse));
            Assert.AreEqual(3, cleanHouse.ItemListCompletedCount);

        }
        #endregion
    }
}
