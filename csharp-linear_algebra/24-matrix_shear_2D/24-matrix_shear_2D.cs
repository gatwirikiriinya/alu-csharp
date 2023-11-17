using System;

public class MatrixTransformation
{
    public static double[,] ShearX(double[,] matrix, double shx)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = matrix[i, j];
                double y = i; 
                result[i, j] = x + shx * y;
            }
        }

        return result;
    }

    public static double[,] ShearY(double[,] matrix, double shy)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = j; 
                double y = matrix[i, j];
                result[i, j] = shy * x + y;
            }
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        double[,] matrix = {
            { 1, 2 },
            { 3, 4 }
        };

        double shearFactorX = 2; // Shear X-axis
        double shearFactorY = 2; // Shear Y-axis

        double[,] shearedMatrixX = MatrixTransformation.ShearX(matrix, shearFactorX);
        double[,] shearedMatrixY = MatrixTransformation.ShearY(matrix, shearFactorY);

        Console.WriteLine("Sheared Matrix along X:");
        for (int i = 0; i < shearedMatrixX.GetLength(0); i++)
        {
            for (int j = 0; j < shearedMatrixX.GetLength(1); j++)
            {
                Console.Write($"{shearedMatrixX[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Sheared Matrix along Y:");
        for (int i = 0; i < shearedMatrixY.GetLength(0); i++)
        {
            for (int j = 0; j < shearedMatrixY.GetLength(1); j++)
            {
                Console.Write($"{shearedMatrixY[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
