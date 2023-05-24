using System;
using System.Collections.Generic;

class Task {
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string name, string description, DateTime dueDate) {
        Name = name;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false;
    }

    public void DisplayDetails() {
        Console.WriteLine("Task: " + Name);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("Due Date: " + DueDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Status: " + (IsCompleted ? "Completed" : "Incomplete"));
        Console.WriteLine();
    }
}

class TaskManager {
    private List<Task> tasks;

    public TaskManager() {
        tasks = new List<Task>();
    }

    public void AddTask(Task task) {
        tasks.Add(task);
    }

    public void RemoveTask(Task task) {
        tasks.Remove(task);
    }

    public void DisplayTasks() {
        Console.WriteLine("All Tasks:");
        foreach (Task task in tasks) {
            task.DisplayDetails();
        }
    }

    public void CompleteTask(Task task) {
        task.IsCompleted = true;
        Console.WriteLine("Task '" + task.Name + "' marked as completed.");
    }
}

class Program {
    static void Main(string[] args) {
        TaskManager taskManager = new TaskManager();

        Task task1 = new Task("Finish project", "Complete the remaining tasks", new DateTime(2023, 6, 30));
        taskManager.AddTask(task1);

        Task task2 = new Task("Prepare presentation", "Create slides for the presentation", new DateTime(2023, 6, 25));
        taskManager.AddTask(task2);

        Task task3 = new Task("Review code", "Review team member's code", new DateTime(2023, 6, 28));
        taskManager.AddTask(task3);

        taskManager.DisplayTasks();

        Console.WriteLine("Completing task: " + task2.Name);
        taskManager.CompleteTask(task2);

        Console.WriteLine("Updated Task List:");
        taskManager.DisplayTasks();
    }
}
