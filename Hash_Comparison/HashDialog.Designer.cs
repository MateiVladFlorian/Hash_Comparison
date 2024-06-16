namespace Hash_Comparison
{
    partial class HashDialog
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.runTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.runTask);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 263);
            this.panel1.TabIndex = 0;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(418, 163);
            this.cancel.Name = "cancel";
            this.cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // runTask
            // 
            this.runTask.Location = new System.Drawing.Point(418, 91);
            this.runTask.Name = "runTask";
            this.runTask.Size = new System.Drawing.Size(75, 23);
            this.runTask.TabIndex = 6;
            this.runTask.Text = "Run Task";
            this.runTask.UseVisualStyleBackColor = true;
            this.runTask.Click += new System.EventHandler(this.runTask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "0%";
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(70, 166);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(296, 20);
            this.bar.Step = 1;
            this.bar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select hash function:";
            // 
            // box
            // 
            this.box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box.FormattingEnabled = true;
            this.box.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-224",
            "SHA-256",
            "SHA-512"});
            this.box.Location = new System.Drawing.Point(243, 95);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(155, 24);
            this.box.TabIndex = 0;
            this.box.SelectedIndexChanged += new System.EventHandler(this.box_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HashDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 263);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HashDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HashDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HashDialog_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button runTask;
        private System.Windows.Forms.Button cancel;
    }
}