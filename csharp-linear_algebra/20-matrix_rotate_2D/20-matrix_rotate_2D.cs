using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Check if the matrix is not square
        if (rows != columns)
        {
            return new double[,] { { -1 } }; // Return -1 for invalid size
        }

        double[,] result = new double[rows, columns];

        // Calculate rotation based on the angle
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Apply rotation to each element in the matrix
                result[i, j] = matrix[i, j] * cosTheta - matrix[i, j] * sinTheta;
            }
        }

        return result;
    }

    public static void Main()
    {
        double[,] squareMatrix = {
            {1, 2},
            {3, 4}
        };

        double[,] invalidMatrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        double angle = Math.PI / 4; // 45 degrees in radians

        double[,] result1 = Rotate2D(squareMatrix, angle);
        double[,] result2 = Rotate2D(invalidMatrix, angle);

        Console.WriteLine("Result 1 (Rotate by 45 degrees):");
        PrintMatrix(result1);

        Console.WriteLine("Result 2 (Invalid matrix):");
        PrintMatrix(result2);
    }

    private static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}