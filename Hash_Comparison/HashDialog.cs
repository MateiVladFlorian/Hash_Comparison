using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

#pragma warning disable

namespace Hash_Comparison
{
    public partial class HashDialog : Form
    {
        BackgroundWorker bw;
        private int index;

        public HashDialog()
        {
            InitializeComponent();
            box.SelectedIndex = 0;
            bar.Maximum = File.ReadAllBytes(Utils.getPath()).Length;

            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;

            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.ProgressChanged += Bw_ProgressChanged;
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int bytesRead = Convert.ToInt32(e.UserState.ToString());
            double percentage = ((double)e.ProgressPercentage / bar.Maximum) * 100.0;

            bar.Increment(bytesRead);
            label2.Text = $"{(int)percentage}%";
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Utils.setStatus(1);
            label2.Text = "100%";

            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = Utils.getPath();
            var fileStream = new FileStream(filePath, FileMode.Open);

            switch (index)
            {
                case 0:
                    using (var md5 = MD5.Create())
                    {
                        string fileHash = md5.ComputeHash(bw, fileStream);
                        Utils.setHash(fileHash);    
                    }
                    break;
                case 1:
                    using (var sha1 = SHA1.Create())
                    {
                        string fileHash = sha1.ComputeHash(bw, fileStream);
                        Utils.setHash(fileHash);
                    }
                    break;
                case 2:
                    {
                        string fileHash = HashExtensions.ComputeSha224Hash(bw, fileStream);
                        Utils.setHash(fileHash);
                    }
                    break;
                case 3:
                    using (var sha256 = SHA256.Create())
                    {
                        string fileHash = sha256.ComputeHash(bw, fileStream);
                        Utils.setHash(fileHash);
                    }
                    break;
                case 4:
                    using (var sha512 = SHA512.Create())
                    {
                        string fileHash = sha512.ComputeHash(bw, fileStream);
                        Utils.setHash(fileHash);
                    }
                    break;
            }

            fileStream.Close();
        }

        private void HashDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Utils.getStatus() != 1) 
                Utils.setStatus(0);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
        private void runTask_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy) bw.RunWorkerAsync();
            else MessageBox.Show("Main thread is running.", "Hash Comparison", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            // cancel the whole process and close the window
            Utils.setStatus(-1); this.Close();
        }

        private void box_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = box.SelectedIndex;
        }
    }
}
