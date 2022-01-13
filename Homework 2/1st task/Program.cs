using System;

namespace _1st_task
{
    class SquareMatrix
    {
        public readonly int Size;
        public int[] diagonal;
        public int i_index;
        public int j_index;
        
        public SquareMatrix(int Size, params int[] array)
        {
            if (array.Length != Size)
            {
                Console.WriteLine("wrong value");
                this.Size = 0;
            }
            else
            {
                this.Size = Size;
                diagonal = new int[Size];
                for (int i = 0; i < Size; i++)
                {
                    diagonal[i] = array[i];
                }
            }
        }

        public void PrintDiagonal()
        {
            if (Size == 0)
            {
                Console.WriteLine("No items on the diagonal!");
            }
            else
            {
                foreach (var item in diagonal)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        public int Track()
        {
            int sum = 0;
            if (Size == 0)
            {
                Console.WriteLine("No items on the diagonal!");
                return 0;
            }
            else
            {
                foreach (int item in diagonal)
                {
                    sum += item;
                }
                return sum;
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i != j)
                {
                    return 0;
                }
                if (i < 0 || i >= Size || j < 0 || j >= Size)
                {
                    throw new System.Exception("Indexes out of bounds.");
                }
                return diagonal[i];
            }
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < diagonal.Length; i++)
            {
                if (diagonal[i] < 10)
                {
                    char character = (char)(diagonal[i] - 240);
                    output += character;
                }
                else
                {
                    int NumberOfDigits = (int)System.Math.Log10(diagonal[i]) + 1;
                    int[] number = new int[NumberOfDigits];
                    int temp1;
                    int temp2 = diagonal[i];
                    for (int j = 0; j < NumberOfDigits; j++)
                    {
                        temp1 = temp2 % 10;
                        number[NumberOfDigits - 1 - j] = temp1;
                        temp2 /= 10;
                    }
                    foreach (var item in number)
                    {
                        output += (char)(item - 240);
                    }
                }
                output += " ";
            }
            output = output.Remove(output.Length - 1);
            return output;
        }

        public override bool Equals(object obj)
        {
            var temp = obj as SquareMatrix;

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            if (this.diagonal.Length != temp.diagonal.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < temp.diagonal.Length; i++)
                {
                    if (temp.diagonal[i] != this.diagonal[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

    static class ExtensionOperation
    { 
        public static SquareMatrix Add(this SquareMatrix squareMatrix, SquareMatrix SecondMatrix)
        {
            int getSize = squareMatrix.Size + SecondMatrix.Size;
            int[] newDiagonal = new int[getSize];
            for (int i = 0; i < squareMatrix.Size; i++)
            {
                newDiagonal[i] = squareMatrix.diagonal[i];
            }
            for (int i = 0; i < SecondMatrix.Size; i++)
            {
                newDiagonal[i + squareMatrix.Size] = SecondMatrix.diagonal[i];
            }

            var result = new SquareMatrix(getSize, newDiagonal);
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            SquareMatrix first_matrix = new(Size:4, 49, 234, 3566, 4);
            first_matrix.PrintDiagonal();
            Console.WriteLine(first_matrix.Track());
            Console.WriteLine(first_matrix.ToString());
            SquareMatrix second_matrix = new(Size:5, 38, 44, 12, 3, 5);
            second_matrix.PrintDiagonal();
            SquareMatrix third_matrix = first_matrix.Add(second_matrix);
            third_matrix.PrintDiagonal();
            Console.WriteLine(third_matrix.Equals(third_matrix));
            SquareMatrix fourth_matrix = new(Size:5, 38, 44, 12, 3, 6);
            Console.WriteLine(fourth_matrix.Equals(second_matrix));

            Console.WriteLine(first_matrix[2, 0]);
            Console.WriteLine(first_matrix[1, 1]);
        }
    }
}
