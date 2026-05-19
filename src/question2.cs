using System;

class PatternPrinter
{
    public static void Run()
    {
        int size = 6;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (row == 0 || row == size - 1 || row == col)
                    Console.Write("& ");
                else
                    Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
