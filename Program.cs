using System;

namespace Autori
{
    internal class Program
    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument.


        static void Main(string[] args)
        {
            System.Text.StringBuilder line = new System.Text.StringBuilder( Console.ReadLine()); string result = "";
            //line = line.Trim();
            result += line[0];
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '-') { result += line[i + 1]; }
            }
            System.Console.WriteLine(result);
        }


#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    }
}