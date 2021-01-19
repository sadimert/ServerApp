
namespace ServerApp
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.txtGonder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(225, 25);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(94, 29);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Basla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(338, 25);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(94, 29);
            this.btnDurdur.TabIndex = 1;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(274, 315);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(94, 36);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "Gonder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "127.0.0.1";
            // 
            // txtEkran
            // 
            this.txtEkran.Location = new System.Drawing.Point(12, 76);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(356, 145);
            this.txtEkran.TabIndex = 4;
            // 
            // txtGonder
            // 
            this.txtGonder.Location = new System.Drawing.Point(12, 251);
            this.txtGonder.Name = "txtGonder";
            this.txtGonder.Size = new System.Drawing.Size(356, 27);
            this.txtGonder.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGonder);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.TextBox txtGonder;
        private System.Windows.Forms.Label label1;
    }
}

