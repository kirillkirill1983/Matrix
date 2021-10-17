using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_2;

namespace TestTask_2
{
    [TestClass]
    public class TestMatrixTrace
    {
        [TestMethod]
        public void TestMatrix_result_Suma()
        {
            var matrix = new MatrixTrace(3, 3,0,100);
            int expectedOutput = matrix.Array[0,0] + matrix.Array[1, 1] + matrix.Array[2, 2];
            int actualOutput = matrix.GetSquareMatrixTrace();
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMatrix_result_Suma_Init_matrix_3_3()
        {
            var inputMatrix  = new[,] { {1,2,3}, { 4, 5, 6 }, { 7, 8, 9 } };
            var matrix = new MatrixTrace(inputMatrix);
            int result = 15;
            var actualOutput = matrix.GetSquareMatrixTrace();
            Assert.AreEqual(result, actualOutput);
        }

        [TestMethod]
        public void TestMatrix_result_Suma_Init_matrix_1_1()
        {
            var inputMatrix = new[,] {{ 1}};
            var matrix = new MatrixTrace(inputMatrix);
            int result = 1;
            var actualOutput = matrix.GetSquareMatrixTrace();
            Assert.AreEqual(result, actualOutput);
        }

        [TestMethod]
        public void TestMatrix_result_Suma_Init_matrix_2_3()
        {
            var inputMatrix = new[,] { { 1, 2 }, { 3,4 }, { 5,6 } };
            var matrix = new MatrixTrace(inputMatrix);
            int result = 5;
            var actualOutput = matrix.GetSquareMatrixTrace();
            Assert.AreEqual(result, actualOutput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Parameter_input_error_Init_matrix_Zero_Zero()
        {
            int[,] inputMatrix = new int[0,0] ;
            new MatrixTrace(inputMatrix);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Parameter_input_error_colums ()
        {
            new MatrixTrace(2, -1, 0, 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Parameter_input_error_rows()
        {
            new MatrixTrace(-1, 2,0,100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Parameter_input_error_zero()
        {
            new MatrixTrace(0,0,0,100);
        }
    }
}
