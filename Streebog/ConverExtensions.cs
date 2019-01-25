using System;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    /// <summary>
    /// Дополнительные методы для каста
    /// </summary>
    public static class ConvertExtensions
    {
        /// <summary>
        /// Выполняет преобразование строки в ее 16-ричный вид
        /// </summary>
        /// <param name="input">Входная строка</param>
        public static string ToHexString(this string str)
        {
            var sb = new StringBuilder();
            var bytes = Encoding.GetEncoding(1251).GetBytes(str);
            foreach (var i in bytes)
            {
                sb.Append(i.ToString("X2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Выполняется преобразование массива байт в hex строку
        /// </summary>
        /// <param name="input">Входная строка</param>
        public static string ToHexString(this byte[] input)
        {
            return BitConverter.ToString(input.Reverse().ToArray()).Replace("-", "").ToLower();
        }

        /// <summary>
        /// Выполняет преобразование hex строки в массив байт
        /// </summary>
        /// <param name="input">Входная строка</param>
        public static byte[] ToByteArray(this string input)
        {
            byte[] bytes = new byte[input.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(input.Substring((bytes.Length - i - 1) * 2, 2), 16);
            }
            return bytes;
        }
    }
}
