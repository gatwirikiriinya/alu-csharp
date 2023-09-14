using System;

public class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0); // Get the number of rows
        int cols = myMatrix.GetLength(1); // Get the number of columns

        int[,] squaredMatrix = new int[rows, cols]; // Create a new matrix for squared values

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int originalValue = myMatrix[row, col];
                int squaredValue = originalValue * originalValue; // Compute the square value
                squaredMatrix[row, col] = squaredValue; // Store it in the new matrix
            }
        }

        return squaredMatrix;
    }
}
