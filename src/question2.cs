using System;

class patternPrinter
{
    static void Main(string[] args)
    {
        int size = 6;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                // First and last rows are all '&'
                // First and last cols are '&', middle is '*'
                // The diagonal (row == col) is '&', rest are '*'
                if (row == 0 || row == size - 1 || row == col)
                    Console.Write("& ");
                else
                    Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
