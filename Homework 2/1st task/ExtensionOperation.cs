using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_task
{
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
}
