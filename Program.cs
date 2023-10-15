namespace ConsoleOne;

class Program
{
  static void Main(string[] args)
  {
    MyAction testAction = () => Console.WriteLine("Hello Test Action...");
    testAction += () => Console.WriteLine("Hello Test Action 2...");
    testAction.Invoke();
    MyTask.Run(() => Console.WriteLine("Hello Task..."));
  }
}

public delegate void MyAction();

public static class MyTask
{
  public static void Run(MyAction action)
  {
    Thread thread = new Thread(() => action());
    thread.Start();
  }
}