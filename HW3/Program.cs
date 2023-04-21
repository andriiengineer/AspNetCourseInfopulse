public class Program
{
    public delegate void PrintString(string value);
    
    public static void Main(string[] args)
    {
        PrintString del = PrintGreen;
        del += PrintDarkYellow;
        del("You can see Green line and than Dark Yellow line! :/");
    }


    public static void PrintGreen(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
    }

    public static void PrintDarkYellow(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(message);
    }
}


