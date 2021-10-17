using Microsoft.Extensions.Configuration;
using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    InitializationOfRandomValues(out int minimumGeneratedNumber, out int maximumGenerationNumber);

                    Console.Write("Enter rows => ");
                    var rows = Convert.ToInt32(Console.ReadLine());

                    if (rows <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Parameter input error  ");
                    }

                    Console.Write("Ente colums => ");
                    var colums = Convert.ToInt32(Console.ReadLine());

                    if (colums <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Parameter input error ");
                    }

                    var matrix = new MatrixTrace(rows, colums, minimumGeneratedNumber, maximumGenerationNumber);

                    Console.WriteLine(new string('-', 20));
                    matrix.PrintMatrixDiagonal();

                    Console.WriteLine(new string('-', 20));
                    var result = matrix.GetSquareMatrixTrace();
                    Console.WriteLine($"Summa => {result}");


                    Console.WriteLine("To exit press Enter or continue press any key and push Enter");

                    var exit = Convert.ToString(Console.ReadLine());

                    if (string.IsNullOrWhiteSpace(exit))
                    {
                        Console.WriteLine("Exit");
                        Console.ReadLine();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                    Console.WriteLine("Press enter to repeat");
                    Console.ReadLine();
                }
            }
        }

        static void InitializationOfRandomValues(out int minimumGeneratedNumber, out int maximumGenerationNumber)
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("config.json", optional: true, reloadOnChange: true)
                    .Build();

            minimumGeneratedNumber = Convert.ToInt32(configuration["one_position"]);
            maximumGenerationNumber = Convert.ToInt32(configuration["two_position"]);
        }
    }
}
