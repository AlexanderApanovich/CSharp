using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{

    class Program
    {
        static void Main(string[] args)
        {
            CMatrix.DisplayCounter();

            CMatrix matrix,K;

            matrix = new CMatrix(4, 4);
            K = new CMatrix(4, 4);
            CMatrix.DisplayCounter();

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = i;
                    K[i, j] = j;
                }

            matrix.DisplayMatrix();
            K.DisplayMatrix();
            
            (matrix - 3).DisplayMatrix();
            matrix.DisplayMatrix();

            Console.ReadKey();
        }
    }
}
