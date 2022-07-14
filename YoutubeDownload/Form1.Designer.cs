
namespace YoutubeDownload
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.radiomp3 = new System.Windows.Forms.RadioButton();
            this.radiomp4 = new System.Windows.Forms.RadioButton();
            this.btnIndir = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblYazi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Format:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(85, 39);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(354, 23);
            this.txtUrl.TabIndex = 2;
            // 
            // radiomp3
            // 
            this.radiomp3.AutoSize = true;
            this.radiomp3.Checked = true;
            this.radiomp3.Location = new System.Drawing.Point(82, 81);
            this.radiomp3.Name = "radiomp3";
            this.radiomp3.Size = new System.Drawing.Size(49, 19);
            this.radiomp3.TabIndex = 3;
            this.radiomp3.TabStop = true;
            this.radiomp3.Text = "MP3";
            this.radiomp3.UseVisualStyleBackColor = true;
            this.radiomp3.CheckedChanged += new System.EventHandler(this.radiomp3_CheckedChanged);
            // 
            // radiomp4
            // 
            this.radiomp4.AutoSize = true;
            this.radiomp4.Location = new System.Drawing.Point(148, 81);
            this.radiomp4.Name = "radiomp4";
            this.radiomp4.Size = new System.Drawing.Size(49, 19);
            this.radiomp4.TabIndex = 4;
            this.radiomp4.Text = "MP4";
            this.radiomp4.UseVisualStyleBackColor = true;
            this.radiomp4.CheckedChanged += new System.EventHandler(this.radiomp4_CheckedChanged);
            // 
            // btnIndir
            // 
            this.btnIndir.Location = new System.Drawing.Point(148, 128);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(159, 50);
            this.btnIndir.TabIndex = 5;
            this.btnIndir.Text = "İndir";
            this.btnIndir.UseVisualStyleBackColor = true;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(456, 16);
            this.progressBar1.TabIndex = 6;
            // 
            // lblYazi
            // 
            this.lblYazi.AutoSize = true;
            this.lblYazi.Location = new System.Drawing.Point(30, 107);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(0, 15);
            this.lblYazi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 210);
            this.Controls.Add(this.lblYazi);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnIndir);
            this.Controls.Add(this.radiomp4);
            this.Controls.Add(this.radiomp3);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube MP3 & MP4 Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.RadioButton radiomp3;
        private System.Windows.Forms.RadioButton radiomp4;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblYazi;
    }
}

