using System;
using System.Text;
using System.Linq;

namespace CustomCrypt
{
    public class BitManager
    {
        // Конвертация строки в массив байтов
        public static byte[] ConvertStrToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }

        // Конвертация массива байтов в бинарную строку
        public static string ConvertByteArrayToBinary(Byte[] data)
        {
            return string.Join("", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

        // Конвертация массива байтов в строку
        public static string ConvertByteArrayToStr(byte[] data, Encoding encoding)
        {
            return encoding.GetString(data);
        }

        // Конвертация бинарной строки в массив байтов
        public static byte[] ConvertBinaryToByteArray(string str)
        {
            int bytesNum = str.Length / 8; // Число байтов
            byte[] toRet = new byte[bytesNum]; // Массив байтов на возврат
            for (int i = 0; i < bytesNum; i++)
            {
                toRet[i] = Convert.ToByte(str.Substring(8 * i, 8), 2);
            }

            return toRet;
        }

        public static string ProByteArrayToString(byte[] data)
        {
            string str = "";

            for (int i = 0; i < data.Length; i++)
            {
                if (i == data.Length - 1)
                    str += data[i];
                else
                    str += data[i] + ";";
            }

            return str;
        }

        public static byte[] ProStringToByteArray(string str)
        {
            string[] mass = str.Split(';');
            byte[] data = new byte[mass.Length];

            for (int i = 0; i < mass.Length; i++)
                data[i] = byte.Parse(mass[i]);

            return data;
        }
    }
}