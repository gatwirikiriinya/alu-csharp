using System;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Check if the matrix is not 2D or 3D
        if (rows != 2 && rows != 3 && columns != 2 && columns != 3)
        {
            return -1; // Return -1 for matrices that are not 2D or 3D
        }

        // Check if the matrix is square (number of rows equals number of columns)
        if (rows != columns)
        {
            return -1; // Return -1 for non-square matrices
        }

        // Calculate determinant based on the dimension of the matrix
        if (rows == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else if (rows == 3)
        {
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                   matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                   matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }

        return -1; // Default case (should not be reached)
    }
}