using System.Runtime.CompilerServices;

namespace ConsoleOne;

public class Global
{
  [ModuleInitializer]
  public static void Init()
  {
    Console.WriteLine($"Global Interval for Threads is : {GlobalVars.IntervalForThreads}");
  }
}

public class Singleton
{
  public static readonly Lazy<Singleton> Instance = new(() => new Singleton());
  private const int IntervalForThreads = 1;
  public static int GetIntervalForThreads() => IntervalForThreads;
}

public static class GlobalVars
{
  public const double IntervalForThreads = .1;
  public const double IntervalForCounter = 5;
}

public static class RegExpPatterns
{
  public const string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
  public const string FileNameWindowsPattern = "";
}
