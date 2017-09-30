namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_13A
{
    using System;

    public class Program
    {
        // Returning a reference
        static public ref byte FindFirstRedEyePixel(byte[] image)
        {
            // Do fancy image detection perhaps with machine learning.
            for (int counter = 0; counter < image.Length; counter++)
            {
                if (image[counter] == (byte)ConsoleColor.Red)
                {
                    return ref image[counter];
                }
            }
            throw new InvalidOperationException("No pixels are red.");
        }
        public static void Main()
        {
            byte[] image = null;
            // Load image.
            // ...
            // Obtain a reference to the first red pixel.
            ref byte redPixel = ref FindFirstRedEyePixel(image);
            // Update it to be Black.
            redPixel = (byte)ConsoleColor.Black;
            System.Console.WriteLine((ConsoleColor)image[redPixel]);
        }
    }
}