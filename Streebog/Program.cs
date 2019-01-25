using System;

namespace Streebog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение для получения хэш-кода:");
            string message = Console.ReadLine();
            string hash256 = Streebog.GetHashCode(message, 256);
            string hash512 = Streebog.GetHashCode(message, 512);
            Console.WriteLine($"256-битный хэш-код:\n{hash256}");
            Console.WriteLine($"512-битный хэш-код:\n{hash512}");
        }
    }
}
