using System;

namespace _1st_task
{
    class Program
    {
        static void Main()
        {
            SquareMatrix first_matrix = new(Size:4, 49, 234, 3566, 4);
            first_matrix.PrintDiagonal();
            Console.WriteLine(first_matrix.Track());
            Console.WriteLine(first_matrix.ToString());
            Console.WriteLine(first_matrix[2, 0]);
            Console.WriteLine(first_matrix[1, 1]);
            Console.WriteLine(first_matrix[12345, -76]);
            SquareMatrix second_matrix = new(Size:5, 38, 44, 12, 3, 5);
            second_matrix.PrintDiagonal();
            SquareMatrix third_matrix = first_matrix.Add(second_matrix);
            third_matrix.PrintDiagonal();
            Console.WriteLine(third_matrix.Equals(third_matrix));
            SquareMatrix fourth_matrix = new(Size:5, 38, 44, 12, 3, 6);
            Console.WriteLine(fourth_matrix.Equals(second_matrix));
        }
    }
}
