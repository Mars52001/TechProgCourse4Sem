using System;
using System.IO;
using System.Windows.Forms;
using CustomCrypt;
using Timer = CustomCrypt.Timer; // Переопределение класса таймера

namespace CryptoManager
{

    public partial class CryptoManager : Form
    {   
        // Переменные для шифрования
        string encryptPath; // Путь к исходному файлу
        string encryptPathAES; // Путь к файлу для AES шифрования
        string encryptPathBinary; // Путь к файлу для бинарного шифрования
        string[] file; // Сам файл

        double encryptTimeAES;
        double encryptTimeBin;

        // Переменные для расшифрования
        string decryptionPath; // Путь к исходному файлу 
        string decryptionPathSave; // Путь к расшифрованному файлу
        string[] decryptFile; // Сам файл

        double decryptionTime;

        public CryptoManager()
        {
            InitializeComponent();
            comboBox.Text = "AES";
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            // Получение информации о расположении файла, выбранного пользователем
            using (OpenFileDialog fDiag = new OpenFileDialog())
            {
                fDiag.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Мои документы пользователя
                fDiag.RestoreDirectory = true;

                if (fDiag.ShowDialog() == DialogResult.OK)
                {
                    encryptPath = fDiag.FileName;
                    textBoxSelect.Text = encryptPath;

                    string path = Path.GetDirectoryName(encryptPath); // Название директории
                    string name = Path.GetFileName(encryptPath); // Название файла
                    string[] fullName = Path.GetFileName(encryptPath).Split('.'); // Название файла

                    encryptPathAES = path + @"\" + fullName[0] + "AES." + fullName[1];
                    encryptPathBinary = path + @"\" + fullName[0] + "Bin." + fullName[1];

                    textBoxAES.Text = encryptPathAES;
                    textBoxBin.Text = encryptPathBinary;

                    buttonEncrypt.Enabled = true;
                    file = File.ReadAllLines(encryptPath);
                }
            }
        }

        // Генерация ключа
        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            textBoxKey.Text = AES_256Method.GenerateKey(32);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxKey.TextLength == 32 || textBoxKey == null)
            {
                string[] fileAES = new string[file.Length];
                string[] fileBin = new string[file.Length];
                Timer AES = new Timer(); // Таймер AES-256 шифрования
                Timer Bin = new Timer(); // Таймер бинарного шифрования

                // Aes
                AES.Start();
                for (int i = 0; i < file.Length; i++)
                    fileAES[i] = BitManager.ProByteArrayToString(AES_256Method.Encrypt(file[i], textBoxKey.Text));
                AES.End();
                encryptTimeAES = Math.Round(AES.subTime, 6);
                
                // Бинарный метод
                Bin.Start();
                for (int i = 0; i < file.Length; i++)
                    fileBin[i] = BitManager.ProByteArrayToString(BinaryMethod.Encrypt(file[i]));
                Bin.End();
                encryptTimeBin = Math.Round(Bin.subTime, 6);
                
                File.WriteAllLines(encryptPathAES, fileAES);
                File.WriteAllLines(encryptPathBinary, fileBin);

                EncryptionResult result = new EncryptionResult(encryptTimeAES.ToString(), encryptTimeBin.ToString());
                result.ShowDialog();
            }
            else
                MessageBox.Show("Неправильный размер ключа шифрования или его не существует", "Ошибка", MessageBoxButtons.OK);        
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox.Text)
            {
                case "AES":
                    textBoxKeyDecrypt.Enabled = true;
                    break;

                case "Бинарный":
                    textBoxKeyDecrypt.Enabled = false;
                    break;
            }
        }

        private void buttonSelectDecrypt_Click(object sender, EventArgs e)
        {
            // Получение информации о расположении файла, выбранного пользователем
            using (OpenFileDialog fDiag = new OpenFileDialog())
            {
                fDiag.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Мои документы пользователя
                fDiag.RestoreDirectory = true;

                if (fDiag.ShowDialog() == DialogResult.OK)
                {
                    decryptionPath = fDiag.FileName;
                    textBoxSelectDecryption.Text = encryptPath;

                    string path = Path.GetDirectoryName(decryptionPath); // Название директории
                    string name = Path.GetFileName(decryptionPath); // Название файла
                    string[] fullName = Path.GetFileName(decryptionPath).Split('.'); // Название файла

                    decryptionPathSave = path + @"\" + fullName[0] + "Decrypted." + fullName[1];

                    textBoxDecryptionPath.Text = decryptionPathSave;

                    buttonDecrypt.Enabled = true;
                    decryptFile = File.ReadAllLines(decryptionPath);
                }
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (comboBox.Text == "AES")
            {
                if (textBoxKeyDecrypt.TextLength == 32 || textBoxKeyDecrypt == null)
                {
                    string[] fileAES = new string[decryptFile.Length];
                    Timer AES = new Timer(); // Таймер AES-256 расшифрования

                    // Aes
                    AES.Start();
                    for (int i = 0; i < file.Length; i++)
                        fileAES[i] = AES_256Method.Decrypt(BitManager.ProStringToByteArray(decryptFile[i]), textBoxKeyDecrypt.Text);
                    AES.End();
                    decryptionTime  = Math.Round(AES.subTime, 6);

                    File.WriteAllLines(decryptionPathSave, fileAES);

                    DecryptionResult result = new DecryptionResult(decryptionTime.ToString());
                    result.ShowDialog();
                }
                else
                    MessageBox.Show("Неправильный размер ключа шифрования или его не существует", "Ошибка", MessageBoxButtons.OK);
            }
            else if (comboBox.Text == "Бинарный")
            {
                string[] fileBin = new string[decryptFile.Length];
                Timer Bin = new Timer(); // Таймер бинарного расшифрования

                // Aes
                Bin.Start();
                for (int i = 0; i < file.Length; i++)
                    fileBin[i] = BinaryMethod.Decrypt(BitManager.ProStringToByteArray(decryptFile[i]));
                Bin.End();
                decryptionTime = Math.Round(Bin.subTime, 6);

                File.WriteAllLines(decryptionPathSave, fileBin);

                DecryptionResult result = new DecryptionResult(decryptionTime.ToString());
                result.ShowDialog();
            }
        }
    }
}
