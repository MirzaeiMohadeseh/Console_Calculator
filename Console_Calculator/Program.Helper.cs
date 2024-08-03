using static System.Console;
partial class Program
{
    private static void SectionTitile(string title)
    {
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkCyan;
        WriteLine($"*** {title} ***");
        ForegroundColor = previousColor;
    }
    private static void ResultTitle(string title)
    {
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"{title}");
        ForegroundColor = previousColor;
    }
}