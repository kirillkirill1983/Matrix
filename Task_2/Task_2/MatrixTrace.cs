using System;


namespace Task_2
{
    /// <summary>
    /// class for determining the trace matrix of two types square and rectangular
    /// </summary>
    public class MatrixTrace
    {
        private readonly int[,] _matrix;


        public int[,] Array { get { return _matrix; } }


        /// <summary>
        /// Сreate matrix rows=rows and colums=colums and print monitor 
        /// </summary>
        /// <param name="rows"></param>
        /// <param name = "colums" ></ param >
        /// 
        public MatrixTrace(int rows, int colums, int start, int end)
        {
            if (rows <= 0 || colums <= 0)
            {
                throw new ArgumentOutOfRangeException("Parameter input error ");
            }

            _matrix = CreateMatrix(rows, colums, start, end);

        }

        public MatrixTrace(int[,] matrixTest)
        {
            if (matrixTest.GetLength(0)<=0 || matrixTest.GetLength(0) <= 0)
            {
                throw new ArgumentOutOfRangeException("Parameter input error ");
            }
            _matrix = matrixTest;
        }
        /// <summary>
        /// Displaying matrix elements to 
        /// the console and highlighting the main diagonal of the matrix
        /// </summary>
        public void PrintMatrixDiagonal()
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{_matrix[i, j]} \t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"{_matrix[i, j]} \t");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        /// <summary>
        /// The sum of the elements of the main diagonal of the matrix
        /// </summary>
        public int GetSquareMatrixTrace()
        {
            int sumaElementov = 0;

            for (int i = 0; i < Math.Min(_matrix.GetLength(0), _matrix.GetLength(1)); i++)
            {
                sumaElementov += _matrix[i, i];
            }
            return sumaElementov;
        }

        private int[,] CreateMatrix(int rows, int colums, int star, int end)
        {
            var matrixs = new int[rows, colums];
            var random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrixs[i, j] = random.Next(star, end+1);
                }
            }

            return matrixs;
        }
    }
}
