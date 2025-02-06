using ToDoListFunctions;

namespace ToDoListFunctionsTest
{
    [TestClass]
    public sealed class FunctionsTest
    {
        #region Task Management
        [TestMethod]
        public void CreateNewToDoList()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            toDoList.Add(cleanHouse);
            Assert.IsNotNull(toDoList);
            Assert.IsNotNull(cleanHouse);
        }
        public void CreateSingleNewTaskListinToDoList()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            toDoList.Add(cleanHouse);
            Assert.IsNotNull(cleanHouse);
            Assert.AreEqual(1, toDoList.Count);
        }
        public void CreateMultipleNewTaskListinToDoList()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            TaskList<string> payBills = new TaskList<string>();
            toDoList.Add(cleanHouse);
            toDoList.Add(payBills);
            Assert.IsNotNull(payBills);
            Assert.IsNotNull(cleanHouse);
        }
        //Step 2
        [TestMethod]
        public void AddAListItemsToATaskList()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Add("Sweep");
            cleanHouse.Add("Dust");
            toDoList.Add(cleanHouse);
            Assert.AreEqual(3, cleanHouse.Count);
        }
        [TestMethod]
        public void CheckValueofAddedTaskListisCorrect()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            TaskList<string> payBills = new TaskList<string>();
            toDoList.Add(cleanHouse);
            toDoList.Add(payBills);
            Assert.AreEqual(toDoList[1], payBills);
            Assert.AreEqual(toDoList[0], cleanHouse);

        }
        [TestMethod]
        public void CheckValueofAddedListItemisCorrect()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Add("Sweep");
            cleanHouse.Add("Dust");
            toDoList.Add(cleanHouse);
            Assert.AreEqual(cleanHouse[0], "Mop");
            Assert.AreEqual(cleanHouse[1], "Sweep");
            Assert.AreEqual(cleanHouse[2], "Dust");
        }
        [TestMethod]
        public void CantAddDuplicateListItems()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Add("Mop");
            cleanHouse.Add("Dust");
            toDoList.Add(cleanHouse);
            Assert.AreEqual(2, cleanHouse.Count);
            Assert.AreEqual(cleanHouse[0], "Mop");
            Assert.AreEqual(cleanHouse[1], "Dust");
        }
        [TestMethod]
        public void DeleteAListItemByString()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Remove("Mop");
            Assert.AreEqual(0, toDoList.Count);
        }
        [TestMethod]
        public void DeleteAListItemByIndex()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Add("Sweep");
            cleanHouse.Add("Dust");
            toDoList.Add(cleanHouse);
            cleanHouse.RemoveAt(0);
            Assert.AreEqual(2, cleanHouse.Count);
            Assert.AreEqual(cleanHouse[0], "Sweep");
            Assert.AreEqual(cleanHouse[1], "Dust");
        }
        [TestMethod]
        public void EditAListItem()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            toDoList.Add(cleanHouse);
            Assert.AreEqual(cleanHouse[0], "Mop");
            cleanHouse[0] = "Sweep";
            Assert.AreEqual(cleanHouse[0], "Sweep");
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
            cleanHouse.ListItemCompleted("Mop");
            cleanHouse.ListItemCompleted("Sweep");
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
            cleanHouse.ListItemCompleted("Mop");
            cleanHouse.ListItemCompleted("Sweep");
            cleanHouse.ListItemCompleted("Dust");
            cleanHouse.ListItemIncompleted("Mop");
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
            cleanHouse.ListItemCompleted("Mop");
            cleanHouse.ListItemCompleted("Sweep");
            cleanHouse.ListItemCompleted("Dust");
            Assert.AreEqual(true, cleanHouse.TaskIsCompleted(cleanHouse));
            Assert.AreEqual(3, cleanHouse.ItemListCompletedCount);

        }
        #endregion
        #region Task Attributes
        [TestMethod]
        public void SetTaskPriority()
        {
            //We would need to add a priority attribute to the task
        }
        [TestMethod]
        public void SetTaskDueDate()
        {
            //We would need to add a due date attribute to the task
        }
        [TestMethod]
        public void CheckInvalidDueDates()
        {
            //This should be a method in the due date attribute
        }
        #endregion
        #region Sorting and Searching Tasks
        [TestMethod]
        public void SortTaskByPriority()
        {
            //Easy to create this method
        }
        [TestMethod]
        public void SortTaskByDueDate()
        {
            //Also easy to create but would you want it to be sorted by due dates and priority at this step or a new test to check for both
        }
        [TestMethod]
        public void SortTaskByCompletionStatus()
        {
            //Easy to create this method
        }
        [TestMethod]
        public void SearchForATask()
        {
            //Can use .Contains or IndexOf here :)
        }
        #endregion
        #region Viewing Tasks
        [TestMethod]
        public void ViewAllTasks()
        {
            //Just have to print out List
        }
        #endregion
    }
}

//todo list: fix task management test cases, finish test task attributes tomorrow