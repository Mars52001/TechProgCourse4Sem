using System.Text;

namespace CustomCrypt
{
    public class BinaryMethod
    {
        // Шифрование бинарным методом
        public static byte[] Encrypt(string str)
        {
            
            StringBuilder toRet = new StringBuilder(BitManager.ConvertByteArrayToBinary(BitManager.ConvertStrToByteArray(str, Encoding.UTF8))); // Управляемая строка

            // Шифрование
            for (int i = 1; i < toRet.Length; i++)
            {
                if (toRet[i] == toRet[i - 1])
                    toRet[i] = '1';
                else toRet[i] = '0';
            }
                        
            return BitManager.ConvertBinaryToByteArray(toRet.ToString());
        }

        public static string Decrypt(byte[] data)
        {
            StringBuilder toRet = new StringBuilder(BitManager.ConvertByteArrayToBinary(data)); // Управляемая строка

            // Расшифровка
            for (int i = toRet.Length - 1; i > 0; i--)
            {
                if (toRet[i] == toRet[i - 1])
                    toRet[i] = '1';
                else toRet[i] = '0';
            }

            return BitManager.ConvertByteArrayToStr(BitManager.ConvertBinaryToByteArray(toRet.ToString()), Encoding.UTF8);
        }
    }
}