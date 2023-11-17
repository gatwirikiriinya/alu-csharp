using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Check if the matrix is not 2x2
        if (rows != 2 || columns != 2)
        {
            return new double[,] { { -1 } }; // Return -1 for invalid size
        }

        // Check if the shear factor is applied to either the X or Y direction but not both
        if (direction != 'x' && direction != 'y')
        {
            return new double[,] { { -1 } }; // Return -1 for invalid axis
        }

        double[,] result = new double[2, 2];

        if (direction == 'x')
        {
            // Shear in the X direction
            result[0, 0] = matrix[0, 0] + factor * matrix[1, 0];
            result[0, 1] = matrix[0, 1] + factor * matrix[1, 1];
            result[1, 0] = matrix[1, 0];
            result[1, 1] = matrix[1, 1];
        }
        else if (direction == 'y')
        {
            // Shear in the Y direction
            result[0, 0] = matrix[0, 0];
            result[0, 1] = matrix[0, 1];
            result[1, 0] = matrix[1, 0] + factor * matrix[0, 0];
            result[1, 1] = matrix[1, 1] + factor * matrix[0, 1];
        }

        return result;
    }

   
    // Helper method to print a matrix
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