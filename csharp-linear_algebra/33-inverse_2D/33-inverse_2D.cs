using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Check if the matrix is not 2x2
        if (rows != 2 || columns != 2)
        {
            return new double[,] { { -1 } }; // Return -1 for invalid size
        }

        // Calculate the determinant of the 2D matrix
        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        // Check if the matrix is non-invertible (determinant is zero)
        if (determinant == 0)
        {
            return new double[,] { { -1 } }; // Return -1 for non-invertible matrix
        }

        // Calculate the inverse of the 2D matrix
        double[,] result = new double[2, 2];
        double inverseDeterminant = 1 / determinant;

        result[0, 0] = matrix[1, 1] * inverseDeterminant;
        result[0, 1] = -matrix[0, 1] * inverseDeterminant;
        result[1, 0] = -matrix[1, 0] * inverseDeterminant;
        result[1, 1] = matrix[0, 0] * inverseDeterminant;

        return result;
    }


}
