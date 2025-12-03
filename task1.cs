using System;

class Program
{
    static void Swap<T>(ref T x, ref T y) where T : struct
    {
        T temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {
        int i1 = 5;
        int i2 = 10;
        double d1 = 2.3;
        double d2 = 9.5;
        bool b1 = true;
        bool b2 = false;

        Console.WriteLine("До обмена:");
        Console.WriteLine($"int: {i1}, {i2}");
        Console.WriteLine($"double: {d1}, {d2}");
        Console.WriteLine($"bool: {b1}, {b2}");

        Swap(ref i1, ref i2);
        Swap(ref d1, ref d2);
        Swap(ref b1, ref b2);

        Console.WriteLine("\nПосле обмена:");
        Console.WriteLine($"int: {i1}, {i2}");
        Console.WriteLine($"double: {d1}, {d2}");
        Console.WriteLine($"bool: {b1}, {b2}");

        Console.ReadLine();
    }
}
