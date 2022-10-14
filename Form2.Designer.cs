
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.txtapi = new System.Windows.Forms.Label();
            this.txtsender = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.Label();
            this.txtmess = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtapi
            // 
            this.txtapi.AutoSize = true;
            this.txtapi.Location = new System.Drawing.Point(109, 56);
            this.txtapi.Name = "txtapi";
            this.txtapi.Size = new System.Drawing.Size(48, 13);
            this.txtapi.TabIndex = 0;
            this.txtapi.Text = "API KEY";
            // 
            // txtsender
            // 
            this.txtsender.AutoSize = true;
            this.txtsender.Location = new System.Drawing.Point(109, 104);
            this.txtsender.Name = "txtsender";
            this.txtsender.Size = new System.Drawing.Size(52, 13);
            this.txtsender.TabIndex = 1;
            this.txtsender.Text = "SENDER";
            // 
            // txtnum
            // 
            this.txtnum.AutoSize = true;
            this.txtnum.Location = new System.Drawing.Point(109, 148);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(54, 13);
            this.txtnum.TabIndex = 2;
            this.txtnum.Text = "NUMBER";
            // 
            // txtmess
            // 
            this.txtmess.AutoSize = true;
            this.txtmess.Location = new System.Drawing.Point(109, 195);
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(59, 13);
            this.txtmess.TabIndex = 3;
            this.txtmess.Text = "MESSAGE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(296, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(296, 195);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtmess);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtsender);
            this.Controls.Add(this.txtapi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtapi;
        private System.Windows.Forms.Label txtsender;
        private System.Windows.Forms.Label txtnum;
        private System.Windows.Forms.Label txtmess;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}