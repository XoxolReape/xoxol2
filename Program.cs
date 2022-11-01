internal class Program
{
    static void Main()
    {
        Console.WriteLine("//Пианино\n Выберите октаву: F6 - шестая\n, Выберите октаву F7 - седьмая\n");
        ConsoleKeyInfo octava = Console.ReadKey();
        oct(octava);
    }
    static void oct(ConsoleKeyInfo octava)
    {
        int[] six = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
        int[] seven = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
        if (octava.Key == ConsoleKey.F6)
        {
            Console.WriteLine("Вы выбрали 6 октаву");
            oct(six, octava);
        }
        if (octava.Key == ConsoleKey.F7)
        {
            Console.WriteLine("Вы выбрали 7 октаву");
            oct(seven, octava);
        }
    }
    static void oct(int[] six, object octava)
    {
        while (true)
        {
            ConsoleKeyInfo a = Console.ReadKey();
            if (a.Key == ConsoleKey.A)
            {
                Console.Beep(six[0], 500);
            }
            if (a.Key == ConsoleKey.B)
            {
                Console.Beep(six[1], 500);
            }
            if (a.Key == ConsoleKey.C)
            {
                Console.Beep(six[2], 500);
            }
            if (a.Key == ConsoleKey.D)
            {
                Console.Beep(six[3], 500);
            }
            if (a.Key == ConsoleKey.F)
            {
                Console.Beep(six[4], 500);
            }
            if (a.Key == ConsoleKey.H)
            {
                Console.Beep(six[5], 500);
            }
            if (a.Key == ConsoleKey.J)
            {
                Console.Beep(six[6], 500);
            }
            if (a.Key == ConsoleKey.K)
            {
                Console.Beep(six[7], 500);
            }
            if (a.Key == ConsoleKey.L)
            {
                Console.Beep(six[8], 500);
            }
            if (a.Key == ConsoleKey.Z)
            {
                Console.Beep(six[9], 500);
            }
            if (a.Key == ConsoleKey.X)
            {
                Console.Beep(six[10], 500);
            }
            if (a.Key == ConsoleKey.C)
            {
                Console.Beep(six[11], 500);
            }
            if (a.Key == ConsoleKey.Escape)
            {
                break;
            }
            Console.Clear();
        }
    }
}