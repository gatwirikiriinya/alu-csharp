using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is 2D or 3D
        if (vector.Length == 2 || vector.Length == 3)
        {
            // Calculate the magnitude
            double magnitude = 0;
            foreach (double component in vector)
            {
                magnitude += Math.Pow(component, 2);
            }
            magnitude = Math.Sqrt(magnitude);

            // Round to the nearest hundredth
            magnitude = Math.Round(magnitude, 2);

            return magnitude;
        }
        else
        {
            // Return -1 for vectors that are not 2D or 3D
            return -1;
        }
    }

    
}