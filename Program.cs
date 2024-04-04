class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to your To Do List.");
      List<string> taskList = [];
      string option ="";

      while(option != "e")
      {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Enter 1 to add a task to your list?");
        Console.WriteLine("Enter 2 to remove a task from the list?");
        Console.WriteLine("Enter 3 to view the list.");
        Console.WriteLine("Enter e to exit the program.");

        option = Console.ReadLine();
        
        if (option == "1")
        {
          Console.WriteLine("Please enter the task you wish to add to the list.");
          string task = Console.ReadLine();
          taskList.Add(task);
          Console.WriteLine("Task has been added to your list.");
        }
        
      }
    }
}