using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class CMatrix
    {
        private double[,] matrix;
        private int rows;
        private int columns;
        static private int counter;
        
        public CMatrix()
        {
            counter++;
        }
        public CMatrix(int rows,int columns) //Конструктор принимающий количество строк и столбцов
        {
            matrix = new double[rows, columns];
            this.rows = rows;
            this.columns = columns;         
            counter++; //Увеличиваем количество созданных объектов
        }
        public CMatrix(double[,] matrix) //Конструктор принимающий двумерный массив в качестве матрицы
        {
            this.matrix = matrix;
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            counter++;
        }
        
        public double [,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }
        public int Columns
        {
            get { return columns; }
            set { columns = value; }
        }
        public static int Counter
        {
            get { return counter; }
        }
        public  double this[int i,int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }  //Индексатор

        public void DisplayMatrix()
        {
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                    Console.Write("{0}  ", this[i, j]);
                Console.Write("\n");
            }
            Console.WriteLine();
        }
        public void MinusRow(int k) //Отнимаем одну из строк от всех кроме нее самой
        {
            for (int i = 0; i < k; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] -= matrix[k, j];
            for (int i = k+1; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] -= matrix[k, j];


        }
        public static CMatrix operator +(CMatrix first, CMatrix second) //Переписываем оператор сложения для матриц
        {
            CMatrix mat = new CMatrix(first.Rows,first.Columns);
            for (int i = 0; i < mat.rows; i++)
                for (int j = 0; j < mat.columns; j++)
                    mat[i, j] = first[i, j]+second[i,j];
            return mat;
        }
        public static CMatrix operator -(CMatrix m, int k) //Переписываем оператор вычисления по заданию(отнимаем одну из строк от всех кроме нее самой)
        {
            CMatrix mat = new CMatrix(m.Rows,m.Columns);
            for (int i = 0; i < mat.rows; i++)
                for (int j = 0; j < mat.columns; j++)
                    mat[i, j] = m[i, j];

            for (int i = 0; i < k; i++)
                for (int j = 0; j < mat.columns; j++)
                    mat[i, j] -= mat[k, j];
            for (int i = k + 1; i < mat.rows; i++)
                for (int j = 0; j < mat.columns; j++)
                    mat[i, j] -= mat[k, j];
            return mat;
        }
        public static CMatrix operator *(CMatrix m, int t) //Оператор умножения матрицы на число
        {
            CMatrix mat = new CMatrix(m.Rows, m.Columns);
            for (int i = 0; i < mat.rows; i++)
                for (int j = 0; j < mat.columns; j++)
                    mat[i, j] = m[i, j]*t;
           
            return mat;
        }
        public static void DisplayCounter()
        {
            Console.WriteLine("Создано {0} объектов Matrix", counter);
        }
    }
}
