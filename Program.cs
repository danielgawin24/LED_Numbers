using Microsoft.VisualBasic;

namespace LED_Numbers;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        char[] charNums = input.ToCharArray();

        int[] numbers = Array.ConvertAll<char, int>(charNums, c => (int)char.GetNumericValue(c));

        string[] UpRow = new string[]   {" _ ", "   " ," _ ", " _ ", "   ", " _ ", " _ ", " _ ", " _ ", " _ "};
        string[] midRow = new string[]  {"| |", "  |", " _|", " _|", "|_|", "|_ ", "|_ ", "  |", "|_|", "|_|"};
        string[] downRow = new string[] {"|_|", "  |", "|_ ", " _|", "  |", " _|", "|_|", "  |", "|_|", "  |"};

        foreach (char x in numbers)
        {
            Console.Write(UpRow[x]);
        }
        Console.WriteLine();
        foreach (char x in numbers)
        {
            Console.Write(midRow[x]);
        }
        Console.WriteLine();
        foreach (char x in numbers)
        {
            Console.Write(downRow[x]);
        }

    }
}

