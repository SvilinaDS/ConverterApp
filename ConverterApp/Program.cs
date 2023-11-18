using System;
using System;

public class Converter
{
    public static int Do(float x)
    {
        x = (float)Math.Round(x, 1);

        if (Math.Abs(x - 0) < float.Epsilon)
        {
            throw new ArgumentException("Input value cannot be zero.");
        }
        else if (x > 100.6f)
        {
            return 1000;
        }
        else if (x >= 0 && x <= 100.6f)
        {
            return (int)x;
        }
        else if (x < 0 && x >= -30.4f)
        {
            return (int)x - 5;
        }
        else if (x <= -30.5f)
        {
            return -2000;
        }

        throw new ArgumentException("Unhandled case for input value x: " + x);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            float input1 = 105.3f;
            int result1 = Converter.Do(input1);
            Console.WriteLine($"For x = {input1}, result = {result1}");

            float input2 = 45.6f;
            int result2 = Converter.Do(input2);
            Console.WriteLine($"For x = {input2}, result = {result2}");

            //Converter.Do(0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"ArgumentException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
