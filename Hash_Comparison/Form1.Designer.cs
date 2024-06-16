namespace Hash_Comparison
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.compareHash = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.test_fail = new System.Windows.Forms.Label();
            this.test_ok = new System.Windows.Forms.Label();
            this.computedHash = new System.Windows.Forms.TextBox();
            this.inputHash = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.compareHash);
            this.panel1.Controls.Add(this.openFile);
            this.panel1.Controls.Add(this.test_fail);
            this.panel1.Controls.Add(this.test_ok);
            this.panel1.Controls.Add(this.computedHash);
            this.panel1.Controls.Add(this.inputHash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 424);
            this.panel1.TabIndex = 0;
            // 
            // compareHash
            // 
            this.compareHash.Enabled = false;
            this.compareHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.compareHash.Location = new System.Drawing.Point(176, 285);
            this.compareHash.Name = "compareHash";
            this.compareHash.Size = new System.Drawing.Size(173, 36);
            this.compareHash.TabIndex = 7;
            this.compareHash.Text = "Compare Hashes";
            this.compareHash.UseVisualStyleBackColor = true;
            this.compareHash.Click += new System.EventHandler(this.compareHash_Click);
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.openFile.Location = new System.Drawing.Point(397, 285);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(114, 36);
            this.openFile.TabIndex = 6;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // test_fail
            // 
            this.test_fail.AutoSize = true;
            this.test_fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_fail.ForeColor = System.Drawing.Color.Red;
            this.test_fail.Location = new System.Drawing.Point(215, 144);
            this.test_fail.Name = "test_fail";
            this.test_fail.Size = new System.Drawing.Size(281, 20);
            this.test_fail.TabIndex = 5;
            this.test_fail.Text = "Hash outputs are not corresponding.";
            this.test_fail.Visible = false;
            // 
            // test_ok
            // 
            this.test_ok.AutoSize = true;
            this.test_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_ok.ForeColor = System.Drawing.Color.White;
            this.test_ok.Location = new System.Drawing.Point(224, 144);
            this.test_ok.Name = "test_ok";
            this.test_ok.Size = new System.Drawing.Size(253, 20);
            this.test_ok.TabIndex = 4;
            this.test_ok.Text = "Hash outputs are corresponding.";
            this.test_ok.Visible = false;
            // 
            // computedHash
            // 
            this.computedHash.Location = new System.Drawing.Point(176, 195);
            this.computedHash.Multiline = true;
            this.computedHash.Name = "computedHash";
            this.computedHash.Size = new System.Drawing.Size(335, 58);
            this.computedHash.TabIndex = 3;
            // 
            // inputHash
            // 
            this.inputHash.Location = new System.Drawing.Point(175, 103);
            this.inputHash.Name = "inputHash";
            this.inputHash.Size = new System.Drawing.Size(335, 22);
            this.inputHash.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(719, 424);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash_Comparison";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputHash;
        private System.Windows.Forms.TextBox computedHash;
        private System.Windows.Forms.Label test_ok;
        private System.Windows.Forms.Label test_fail;
        private System.Windows.Forms.Button compareHash;
        private System.Windows.Forms.Button openFile;
    }
}

