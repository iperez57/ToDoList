namespace ToDoListFunctionsTest
{
    [TestClass]
    public sealed class FunctionsTest
    {
        //Step 1: Create the to do list
        //Step 2: Add a task
        //Step 3: Delete a task
        #region Task Management
        //Step 1
        [TestMethod]
        public void CreateNewToDoList()
        {
            UniqueList<string> toDoList = new UniqueList<string>();

            toDoList.Add("Task 1");
            Assert.IsNotNull(toDoList);
            //Verified that the list is not null (since an instance of the list is created, it would not be null)
        }
        //Step 2
        [TestMethod]
        public void AddATask()
        {
            UniqueList<string> toDoList = new UniqueList<string>();
            toDoList.Add("Task 1");
            Assert.AreEqual(1, toDoList.Count);
            //Verified that the list has one item in it

        }
        [TestMethod]
        public void CheckValueofAddedTaskisCorrect()
        {
            UniqueList<string> toDoList = new UniqueList<string>();
            toDoList.Add("Task 1");
            Assert.AreEqual("Task 1", toDoList[0]);

        }
        [TestMethod]
        public void CantAddDuplicateTasks()
        {
            UniqueList<string> toDoList = new UniqueList<string>();
            toDoList.Add("Task 1");
            toDoList.Add("Task 1");
            //Would need to create a method to check for duplicates after each .Add and to not add them
            Assert.AreEqual(1, toDoList.Count);
        }
        //Step 3
        [TestMethod]
        public void DeleteATaskByTaskString()
        {
            UniqueList<string> toDoList = new UniqueList<string>();
            toDoList.Add("Task 1");
            toDoList.Remove("Task 1");
            Assert.AreEqual(0, toDoList.Count);
        }
        [TestMethod]
        public void DeleteATaskByIndex()
        {
            UniqueList<string> toDoList = new UniqueList<string>();
            toDoList.Add("Task 1");
            toDoList.Add("Task 2");
            toDoList.Add("Task 3");
            toDoList.RemoveAt(1);
            Assert.AreEqual(2, toDoList.Count);
            Assert.AreEqual("Task 1", toDoList[0]);
            Assert.AreEqual("Task 3", toDoList[1]);
        }
        [TestMethod]
        public void EditATask()
        {
            UniqueList<string> toDoList = new UniqueList<string>();
            toDoList.Add("Task 1");
            toDoList[0] = "Task 2";
            Assert.AreEqual("Task 2", toDoList[0]);
        }
        #endregion
        //Step 1: Create the to do list
        //Step 2: Add a task
        //Step 3: Delete a task
        #region Task Status
        [TestMethod]
        public void MarkTaskAsComplete()
        {
            //Add a bool or method in the UniqueList class to mark the task is complete
        }
        [TestMethod]
        public void UnmarkTaskAsComplete()
        {
            //All Tasks should be incomplete by default, so this would be a method to unmark a task noted as complete (maybe use a reset to default method)
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
