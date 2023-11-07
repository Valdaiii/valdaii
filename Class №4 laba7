using System;

public class TaskScheduler<TTask, TPriority>
{
    private PriorityQueue<TTask, TPriority> taskQueue = new PriorityQueue<TTask, TPriority>();
    private TaskExecution executionDelegate;

    public delegate void TaskExecution(TTask task);

    public TaskScheduler(TaskExecution executionDelegate)
    {
        this.executionDelegate = executionDelegate;
    }

    public void AddTask(TTask task, TPriority priority)
    {
        taskQueue.Enqueue(task, priority);
    }

    public void ExecuteNext()
    {
        if (taskQueue.Count > 0)
        {
            var nextTask = taskQueue.Dequeue();
            executionDelegate(nextTask);
        }
        else
        {
            Console.WriteLine("Черга завдань порожня.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskScheduler<string, int> taskScheduler = new TaskScheduler<string, int>(ExecuteTask);

        while (true)
        {
            Console.WriteLine("Введіть завдання (або 'exit' для виходу):");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }

            Console.WriteLine("Введіть пріоритет завдання:");
            if (int.TryParse(Console.ReadLine(), out int priority))
            {
                taskScheduler.AddTask(input, priority);
            }
            else
            {
                Console.WriteLine("Невірний формат пріоритету. Завдання не додано.");
            }
        }

        while (true)
        {
            Console.WriteLine("Виконати наступне завдання? (y/n)");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                taskScheduler.ExecuteNext();
            }
            else if (input.ToLower() == "n")
            {
                break;
            }
        }
    }

    static void ExecuteTask(string task)
    {
        Console.WriteLine($"Виконано завдання: {task}");
    }
}
