
namespace CryptoManager
{
    partial class CryptoManager
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageEncrypt = new System.Windows.Forms.TabPage();
            this.buttonGenerateKey = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBin = new System.Windows.Forms.TextBox();
            this.textBoxAES = new System.Windows.Forms.TextBox();
            this.tabPageDecrypt = new System.Windows.Forms.TabPage();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDecryptionPath = new System.Windows.Forms.TextBox();
            this.textBoxKeyDecrypt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSelectDecryption = new System.Windows.Forms.TextBox();
            this.buttonSelectDecrypt = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageEncrypt.SuspendLayout();
            this.tabPageDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(757, 40);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(102, 42);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(14, 45);
            this.textBoxSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.ReadOnly = true;
            this.textBoxSelect.Size = new System.Drawing.Size(735, 31);
            this.textBoxSelect.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEncrypt);
            this.tabControl.Controls.Add(this.tabPageDecrypt);
            this.tabControl.Location = new System.Drawing.Point(13, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(886, 474);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageEncrypt
            // 
            this.tabPageEncrypt.Controls.Add(this.buttonGenerateKey);
            this.tabPageEncrypt.Controls.Add(this.textBoxKey);
            this.tabPageEncrypt.Controls.Add(this.label4);
            this.tabPageEncrypt.Controls.Add(this.buttonEncrypt);
            this.tabPageEncrypt.Controls.Add(this.label3);
            this.tabPageEncrypt.Controls.Add(this.label2);
            this.tabPageEncrypt.Controls.Add(this.label1);
            this.tabPageEncrypt.Controls.Add(this.textBoxBin);
            this.tabPageEncrypt.Controls.Add(this.textBoxAES);
            this.tabPageEncrypt.Controls.Add(this.textBoxSelect);
            this.tabPageEncrypt.Controls.Add(this.buttonSelect);
            this.tabPageEncrypt.Location = new System.Drawing.Point(4, 34);
            this.tabPageEncrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEncrypt.Name = "tabPageEncrypt";
            this.tabPageEncrypt.Size = new System.Drawing.Size(878, 436);
            this.tabPageEncrypt.TabIndex = 0;
            this.tabPageEncrypt.Text = "Шифрование";
            this.tabPageEncrypt.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateKey
            // 
            this.buttonGenerateKey.Location = new System.Drawing.Point(699, 105);
            this.buttonGenerateKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGenerateKey.Name = "buttonGenerateKey";
            this.buttonGenerateKey.Size = new System.Drawing.Size(160, 42);
            this.buttonGenerateKey.TabIndex = 10;
            this.buttonGenerateKey.Text = "Сгенерировать";
            this.buttonGenerateKey.UseVisualStyleBackColor = true;
            this.buttonGenerateKey.Click += new System.EventHandler(this.buttonGenerateKey_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(14, 110);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(679, 31);
            this.textBoxKey.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ключ AES-256 шифрования";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Enabled = false;
            this.buttonEncrypt.Location = new System.Drawing.Point(343, 332);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(189, 76);
            this.buttonEncrypt.TabIndex = 7;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Путь к зашифрованному файлу бинарным методом";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Путь к зашифрованному файлу AES-256";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Путь к файлу";
            // 
            // textBoxBin
            // 
            this.textBoxBin.Location = new System.Drawing.Point(14, 264);
            this.textBoxBin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBin.Name = "textBoxBin";
            this.textBoxBin.ReadOnly = true;
            this.textBoxBin.Size = new System.Drawing.Size(844, 31);
            this.textBoxBin.TabIndex = 3;
            // 
            // textBoxAES
            // 
            this.textBoxAES.Location = new System.Drawing.Point(14, 182);
            this.textBoxAES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAES.Name = "textBoxAES";
            this.textBoxAES.ReadOnly = true;
            this.textBoxAES.Size = new System.Drawing.Size(844, 31);
            this.textBoxAES.TabIndex = 2;
            // 
            // tabPageDecrypt
            // 
            this.tabPageDecrypt.Controls.Add(this.buttonDecrypt);
            this.tabPageDecrypt.Controls.Add(this.label8);
            this.tabPageDecrypt.Controls.Add(this.textBoxDecryptionPath);
            this.tabPageDecrypt.Controls.Add(this.textBoxKeyDecrypt);
            this.tabPageDecrypt.Controls.Add(this.label7);
            this.tabPageDecrypt.Controls.Add(this.label6);
            this.tabPageDecrypt.Controls.Add(this.comboBox);
            this.tabPageDecrypt.Controls.Add(this.label5);
            this.tabPageDecrypt.Controls.Add(this.textBoxSelectDecryption);
            this.tabPageDecrypt.Controls.Add(this.buttonSelectDecrypt);
            this.tabPageDecrypt.Location = new System.Drawing.Point(4, 34);
            this.tabPageDecrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDecrypt.Name = "tabPageDecrypt";
            this.tabPageDecrypt.Size = new System.Drawing.Size(878, 436);
            this.tabPageDecrypt.TabIndex = 0;
            this.tabPageDecrypt.Text = "Дешифрование";
            this.tabPageDecrypt.UseVisualStyleBackColor = true;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.Location = new System.Drawing.Point(332, 267);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(189, 76);
            this.buttonDecrypt.TabIndex = 14;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Путь к расшифрованному файлу";
            // 
            // textBoxDecryptionPath
            // 
            this.textBoxDecryptionPath.Location = new System.Drawing.Point(19, 190);
            this.textBoxDecryptionPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDecryptionPath.Name = "textBoxDecryptionPath";
            this.textBoxDecryptionPath.ReadOnly = true;
            this.textBoxDecryptionPath.Size = new System.Drawing.Size(844, 31);
            this.textBoxDecryptionPath.TabIndex = 12;
            // 
            // textBoxKeyDecrypt
            // 
            this.textBoxKeyDecrypt.Location = new System.Drawing.Point(221, 117);
            this.textBoxKeyDecrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKeyDecrypt.Name = "textBoxKeyDecrypt";
            this.textBoxKeyDecrypt.Size = new System.Drawing.Size(641, 31);
            this.textBoxKeyDecrypt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ключ AES-256 шифрования";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Метод шифрования";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "AES",
            "Бинарный"});
            this.comboBox.Location = new System.Drawing.Point(19, 116);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(182, 33);
            this.comboBox.TabIndex = 8;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Путь к файлу";
            // 
            // textBoxSelectDecryption
            // 
            this.textBoxSelectDecryption.Location = new System.Drawing.Point(19, 47);
            this.textBoxSelectDecryption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSelectDecryption.Name = "textBoxSelectDecryption";
            this.textBoxSelectDecryption.ReadOnly = true;
            this.textBoxSelectDecryption.Size = new System.Drawing.Size(735, 31);
            this.textBoxSelectDecryption.TabIndex = 6;
            // 
            // buttonSelectDecrypt
            // 
            this.buttonSelectDecrypt.Location = new System.Drawing.Point(760, 41);
            this.buttonSelectDecrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectDecrypt.Name = "buttonSelectDecrypt";
            this.buttonSelectDecrypt.Size = new System.Drawing.Size(102, 42);
            this.buttonSelectDecrypt.TabIndex = 5;
            this.buttonSelectDecrypt.Text = "Выбрать";
            this.buttonSelectDecrypt.UseVisualStyleBackColor = true;
            this.buttonSelectDecrypt.Click += new System.EventHandler(this.buttonSelectDecrypt_Click);
            // 
            // CryptoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 500);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CryptoManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoManager";
            this.tabControl.ResumeLayout(false);
            this.tabPageEncrypt.ResumeLayout(false);
            this.tabPageEncrypt.PerformLayout();
            this.tabPageDecrypt.ResumeLayout(false);
            this.tabPageDecrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxSelect;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEncrypt;
        private System.Windows.Forms.TabPage tabPageDecrypt;
        private System.Windows.Forms.TextBox textBoxBin;
        private System.Windows.Forms.TextBox textBoxAES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonGenerateKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSelectDecrypt;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKeyDecrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDecryptionPath;
        private System.Windows.Forms.TextBox textBoxSelectDecryption;
    }
}

