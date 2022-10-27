using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoManager
{
    public partial class EncryptionResult : Form
    {
        public EncryptionResult(string aes, string bin)
        {
            InitializeComponent();
            labelAES.Text = aes;
            labelBin.Text = bin;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
