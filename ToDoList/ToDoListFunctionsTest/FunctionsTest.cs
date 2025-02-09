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
        [TestMethod]
        public void CreateSingleNewTaskListinToDoList()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            toDoList.Add(cleanHouse);
            Assert.IsNotNull(cleanHouse);
            Assert.AreEqual(1, toDoList.Count);
        }
        [TestMethod]
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
            toDoList.Add(cleanHouse);
            Assert.AreEqual(0, cleanHouse.Count);
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
        #region Task Attributes
        [TestMethod]
        public void SetTaskPriority()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            TaskList<string> walkDogs= new TaskList<string>();
            TaskList<string> goToGym = new TaskList<string>();
            cleanHouse.Priority = TaskPriority.High;
            walkDogs.Priority = TaskPriority.Medium;
            goToGym.Priority = TaskPriority.Low;
            toDoList.Add(cleanHouse);
            toDoList.Add(walkDogs);
            toDoList.Add(goToGym);


            Assert.AreEqual(TaskPriority.High, cleanHouse.Priority);
            Assert.AreEqual(TaskPriority.Medium, walkDogs.Priority);
            Assert.AreEqual(TaskPriority.Low, goToGym.Priority);

            //We would need to add a priority attribute to the task
        }
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
        public void CreateTaskDueDate()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            toDoList.Add(cleanHouse);

            Assert.IsNull(cleanHouse.DueDate);
            //We would need to add a due date attribute to the task
        }
        [TestMethod]
        public void CheckInvalidDueDatesResulttoNull()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            cleanHouse.SetDueDate(2025, 02, 05);
            toDoList.Add(cleanHouse);
            Assert.AreEqual(null, cleanHouse.DueDate);
            //This should be a method in the due date attribute
        }
        #endregion
        #region Sorting and Searching Tasks
        [TestMethod]
        public void SortTaskByPriority()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            TaskList<string> walkDogs = new TaskList<string>();
            TaskList<string> goToGym = new TaskList<string>();
            TaskList<string> makeOrangeJuice = new TaskList<string>();
            cleanHouse.Priority = TaskPriority.Medium;
            walkDogs.Priority = TaskPriority.High;
            goToGym.Priority = TaskPriority.Low;
            makeOrangeJuice.Priority = TaskPriority.Medium;
            toDoList.Add(cleanHouse);
            toDoList.Add(walkDogs);
            toDoList.Add(goToGym);
            toDoList.Add(makeOrangeJuice);
            toDoList.SortByPriority(toDoList);

            Assert.AreEqual(TaskPriority.High, toDoList[0].Priority);
            Assert.AreEqual(TaskPriority.Medium, toDoList[1].Priority);
            Assert.AreEqual(TaskPriority.Medium, toDoList[2].Priority);
            Assert.AreEqual(TaskPriority.Low, toDoList[3].Priority);

            Assert.AreEqual(walkDogs, toDoList[0]);
            Assert.AreEqual(cleanHouse, toDoList[1]);
            Assert.AreEqual(makeOrangeJuice, toDoList[2]);
            Assert.AreEqual(goToGym, toDoList[3]);

        }
        [TestMethod]
        public void SortTaskByDueDate()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            TaskList<string> walkDogs = new TaskList<string>();
            TaskList<string> goToGym = new TaskList<string>();
            toDoList.Add(cleanHouse);
            toDoList.Add(walkDogs);
            toDoList.Add(goToGym);
            DateTime dateTime1 = DateTime.Today;
            int day1 = Convert.ToInt32(dateTime1.ToString("dd"));
            int month1 = Convert.ToInt32(dateTime1.ToString("MM"));
            int year1 = Convert.ToInt32(dateTime1.ToString("yyyy"));
            cleanHouse.SetDueDate(year1, month1, day1);
            DateTime dateTime2 = DateTime.Today.AddDays(10);
            int day2 = Convert.ToInt32(dateTime2.ToString("dd"));
            int month2 = Convert.ToInt32(dateTime2.ToString("MM"));
            int year2 = Convert.ToInt32(dateTime2.ToString("yyyy"));
            goToGym.SetDueDate(year2, month2, day2);
            DateTime dateTime3 = DateTime.Today.AddDays(7);
            int day3 = Convert.ToInt32(dateTime3.ToString("dd"));
            int month3 = Convert.ToInt32(dateTime3.ToString("MM"));
            int year3 = Convert.ToInt32(dateTime3.ToString("yyyy"));
            walkDogs.SetDueDate(year3, month3, day3);

            toDoList.SortByDueDate(toDoList);

            Assert.AreEqual(dateTime1, cleanHouse.DueDateActual);
            Assert.AreEqual(dateTime2, goToGym.DueDateActual);
            Assert.AreEqual(dateTime3, walkDogs.DueDateActual);

            Assert.AreEqual(cleanHouse, toDoList[0]);
            Assert.AreEqual(goToGym, toDoList[2]);
            Assert.AreEqual(walkDogs, toDoList[1]);


        }
        [TestMethod]
        public void CheckSortByCompletionStatusisCorrect()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            TaskList<string> walkDogs = new TaskList<string>();
            TaskList<string> goToGym = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Add("Sweep");
            cleanHouse.Add("Dust");
            toDoList.Add(cleanHouse);

            walkDogs.Add("Morning"); //listitems
            walkDogs.Add("Lunch");
            walkDogs.Add("Evening");
            toDoList.Add(walkDogs);

            goToGym.Add("Arms"); //listitems
            goToGym.Add("Chest");
            goToGym.Add("Back");
            toDoList.Add(goToGym);

            walkDogs.ListItemCompleted(walkDogs, "Morning");
            walkDogs.ListItemCompleted(walkDogs, "Lunch");
            walkDogs.ListItemCompleted(walkDogs, "Dinner");


            cleanHouse.ListItemCompleted(cleanHouse, "Mop");
            cleanHouse.ListItemCompleted(cleanHouse, "Dust");


            goToGym.ListItemCompleted(goToGym, "Back");

            toDoList.Add(cleanHouse);
            toDoList.Add(walkDogs);
            toDoList.Add(goToGym);
            toDoList.SortByCompletionStatus(toDoList);

            Assert.AreEqual(100.00M, walkDogs.CompletionPercentage);
            Assert.AreEqual(66.67M, cleanHouse.CompletionPercentage);
            Assert.AreEqual(33.33M, goToGym.CompletionPercentage);
        }
        [TestMethod]
        public void SortTaskByCompletionStatus()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            TaskList<string> walkDogs = new TaskList<string>();
            TaskList<string> goToGym = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Add("Sweep");
            cleanHouse.Add("Dust");
            toDoList.Add(cleanHouse);

            walkDogs.Add("Morning"); //listitems
            walkDogs.Add("Lunch");
            walkDogs.Add("Evening");
            toDoList.Add(walkDogs);

            goToGym.Add("Arms"); //listitems
            goToGym.Add("Chest");
            goToGym.Add("Back");
            toDoList.Add(goToGym);

            walkDogs.ListItemCompleted(walkDogs, "Morning");
            walkDogs.ListItemCompleted(walkDogs, "Lunch");
            walkDogs.ListItemCompleted(walkDogs, "Dinner");


            cleanHouse.ListItemCompleted(cleanHouse, "Mop");
            cleanHouse.ListItemCompleted(cleanHouse, "Dust");


            goToGym.ListItemCompleted(goToGym, "Back");

            toDoList.Add(cleanHouse);
            toDoList.Add(walkDogs);
            toDoList.Add(goToGym);
            toDoList.SortByCompletionStatus(toDoList);

            Assert.AreEqual(goToGym, toDoList[2]);
            Assert.AreEqual(cleanHouse, toDoList[1]);
            Assert.AreEqual(walkDogs, toDoList[0]);
        }
        [TestMethod]
        public void ToDoListContainsTask()
        {
            UniqueList<TaskList<string>> toDoList = new UniqueList<TaskList<string>>();
            TaskList<string> cleanHouse = new TaskList<string>();
            TaskList<string> walkDogs = new TaskList<string>();
            TaskList<string> goToGym = new TaskList<string>();
            cleanHouse.Add("Mop"); //listitems
            cleanHouse.Add("Sweep");
            cleanHouse.Add("Dust");
            toDoList.Add(cleanHouse);

            walkDogs.Add("Morning"); //listitems
            walkDogs.Add("Lunch");
            walkDogs.Add("Evening");
            toDoList.Add(walkDogs);

            goToGym.Add("Arms"); //listitems
            goToGym.Add("Chest");
            goToGym.Add("Back");
            toDoList.Add(goToGym);

            Assert.IsTrue(toDoList.Contains(cleanHouse));
            Assert.IsTrue(toDoList.Contains(walkDogs));
            Assert.IsTrue(toDoList.Contains(goToGym));
        }
        #endregion
    }
}