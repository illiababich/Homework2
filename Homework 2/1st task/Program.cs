using System;

namespace _1st_task
{
    class SquareMatrix
    {
        public readonly int Size;
        public int[] diagonal;
        
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

        public void PrintArray()
        {
            if (Size == 0)
            {
                Console.WriteLine("No items in the array");
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
                Console.WriteLine("No items on the diagonal");
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

        public static void Indexer()
        {

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
            return base.Equals(obj);
        }

        public int GetSize()
        {
            return Size;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

    static class ExtensionOperation
    { 
        public static SquareMatrix Add(this SquareMatrix squareMatrix, SquareMatrix FirstMatrix, SquareMatrix SecondMatrix)
        {
            int getSize = FirstMatrix.GetSize() + SecondMatrix.GetSize();
            var result = new SquareMatrix(getSize);
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            SquareMatrix a = new(Size:4, 49, 234, 3566, 4);
            a.PrintArray();
            Console.WriteLine(a.Track());
            Console.WriteLine(a.ToString());
        }
    }
}
