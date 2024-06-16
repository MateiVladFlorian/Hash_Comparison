using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash_Comparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            test_ok.Visible = false;
            test_fail.Visible = false;
        }

        private void BTN1()
        {
            HashDialog hd = new HashDialog();

            if (hd.ShowDialog() == DialogResult.Cancel && Utils.getStatus() == 1)
            {
                computedHash.Text = Utils.getHash();
                compareHash.Enabled = false;

                if (Utils.getHash().ToUpper().CompareTo(inputHash.Text.ToUpper()) == 0)
                {
                    test_ok.Visible = true;
                    test_fail.Visible = false;
                }
                else
                {
                    test_fail.Visible = true;
                    test_ok.Visible = false;
                }
            }
        }

        private void compareHash_Click(object sender, EventArgs e)
        {
            if (inputHash.Text.Length > 0)
            {
                BTN1();
            }
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            var opd = new OpenFileDialog();
            opd.Title = "Select file";
            opd.DefaultExt = "*.*";
            opd.Filter = "All files(*.*)|*.*";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                Utils.setFile(opd.FileName);
                compareHash.Enabled = true;
            }
        }
    }
}
