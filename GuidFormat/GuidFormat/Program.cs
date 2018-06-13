using System;

namespace GuidFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] correspondingFormat = { 'N', 'n', 'D', 'd', 'B', 'b', 'P', 'p', 'X', 'x' };

            Console.WriteLine("Input guid's corresponding format (N, D, B, P or X) than press Enter");

            while (true)
            {
                var keyChar = (char)Console.Read();

                if (Array.Exists(correspondingFormat, el => el == keyChar))
                {
                    Console.WriteLine($"{GenerateGuid(keyChar)}");
                }
            }
        }

        private static string GenerateGuid(char format)
        {
            return Guid.NewGuid().ToString(format.ToString());
        }

    }
}
