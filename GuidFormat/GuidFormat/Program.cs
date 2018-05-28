using System;

namespace GuidFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] correspondingFormat = { "N", "D", "B", "P", "X" };

            Console.WriteLine("Input guid's corresponding format (N, D, B, P or X) than press Enter");
            var input = Console.ReadLine().ToUpper();

            if (input != null && input.Length == 1 && Array.Exists(correspondingFormat, el => el == input))
            {
                Console.WriteLine($"New GUID: {GenerateGuid(input)}");
            }
            else
            {
                Console.WriteLine("Invalid format");
            }

            Console.ReadKey();
        }

        private static string GenerateGuid(string format)
        {
            return Guid.NewGuid().ToString(format);
        }

    }
}
