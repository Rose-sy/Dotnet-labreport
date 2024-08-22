using System;

class MatrixMultiplication
{
    static void Main(string[] args)
    {
        // Input for the first matrix
        Console.WriteLine("Enter the number of rows and columns for the first matrix (rows columns):");
        string[] dimensions1 = Console.ReadLine().Split();
        if (dimensions1.Length != 2 || !int.TryParse(dimensions1[0], out int rows1) || !int.TryParse(dimensions1[1], out int cols1))
        {
            Console.WriteLine("Invalid input for matrix dimensions.");
            return;
        }

        int[,] matrix1 = new int[rows1, cols1];
        Console.WriteLine("Enter the elements of the first matrix:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                if (!int.TryParse(Console.ReadLine(), out matrix1[i, j]))
                {
                    Console.WriteLine("Invalid input for matrix elements.");
                    return;
                }
            }
        }

        // Input for the second matrix
        Console.WriteLine("Enter the number of rows and columns for the second matrix (rows columns):");
        string[] dimensions2 = Console.ReadLine().Split();
        if (dimensions2.Length != 2 || !int.TryParse(dimensions2[0], out int rows2) || !int.TryParse(dimensions2[1], out int cols2))
        {
            Console.WriteLine("Invalid input for matrix dimensions.");
            return;
        }

        if (cols1 != rows2)
        {
            Console.WriteLine("Matrix multiplication is not possible. The number of columns in the first matrix must equal the number of rows in the second matrix.");
            return;
        }

        int[,] matrix2 = new int[rows2, cols2];
        Console.WriteLine("Enter the elements of the second matrix:");
        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                if (!int.TryParse(Console.ReadLine(), out matrix2[i, j]))
                {
                    Console.WriteLine("Invalid input for matrix elements.");
                    return;
                }
            }
        }

        // Matrix multiplication
        int[,] result = new int[rows1, cols2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        // Display the result
        Console.WriteLine("Resultant matrix after multiplication:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
