using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        // Check if the matrix is empty
        if (matrix.Length == 0)
        {
            return new double[,] { }; // Return an empty matrix
        }

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Create a new matrix to store the transpose
        double[,] result = new double[columns, rows];

        // Populate the result matrix with transposed values
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }

        return result;
    }
}