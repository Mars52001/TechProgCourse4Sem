using System;
using System.Windows.Forms;

namespace CryptoManager
{
    public partial class DecryptionResult : Form
    {
        public DecryptionResult(string time)
        {
            InitializeComponent();
            labelDecrypt.Text = time;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
