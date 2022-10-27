using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CustomCrypt
{
    public class AES_256Method
    {
        // Генерация ключа
        public static string GenerateKey(int length)
        {
            Random rnd = new Random();

            var chars = "1!2@3#4$5%6^7&8*9(0)-_=+qQwWeErRtTyYuUiIoOpP[{]}\\|aAsSdDfFgGhHjJkKlL;:'\"zZxXcCvVbBnNmM,<.>/?".ToCharArray();

            string randomizedKey = "";

            for (int i = 0; i < length; i++)
            {
                randomizedKey += chars[rnd.Next(0, chars.Length)];
            }
            return randomizedKey;
        }

        public static byte[] Encrypt(string str, string key, string IV = "HR$2pIjHR$2pIj12")
        {
            if (str == null || str.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = BitManager.ConvertStrToByteArray(key, Encoding.UTF8);
                aesAlg.IV = BitManager.ConvertStrToByteArray(IV, Encoding.UTF8);

                // Реализация шифрования
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Потоки шифрования
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // Запись всех данных в поток
                            swEncrypt.Write(str);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        public static string Decrypt(byte[] encr, string key, string IV = "HR$2pIjHR$2pIj12")
        {
            if (encr == null || encr.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null; // Оригинальный текст, на возврат

            // AES объект
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = BitManager.ConvertStrToByteArray(key, Encoding.UTF8);
                aesAlg.IV = BitManager.ConvertStrToByteArray(IV, Encoding.UTF8);

                // Реализация дешифровки
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Потоки для дешифрования
                using (MemoryStream msDecrypt = new MemoryStream(encr))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}