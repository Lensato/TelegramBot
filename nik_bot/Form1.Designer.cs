
namespace nik_bot
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
            if (disposing && (components != null)) {
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
            this.btnRunBot = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRunBot
            // 
            this.btnRunBot.Location = new System.Drawing.Point(6, 45);
            this.btnRunBot.Name = "btnRunBot";
            this.btnRunBot.Size = new System.Drawing.Size(118, 23);
            this.btnRunBot.TabIndex = 0;
            this.btnRunBot.Text = "Запустить бота";
            this.btnRunBot.UseVisualStyleBackColor = true;
            this.btnRunBot.Click += new System.EventHandler(this.btnRunBot_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(6, 19);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(337, 20);
            this.txtKey.TabIndex = 1;
            this.txtKey.Text = "1821469427:AAFQVd0nyqyBPSuwUqADef9BWOWqvHg_0r0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.btnRunBot);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ключ бота в telegram";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 112);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(389, 150);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunBot;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

