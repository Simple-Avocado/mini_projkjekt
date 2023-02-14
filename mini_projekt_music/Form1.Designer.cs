namespace mini_projekt_music
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
            this.LoginButon = new System.Windows.Forms.Button();
            this.UsernameLoginBox = new System.Windows.Forms.TextBox();
            this.PasswordLoginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wrongpassorusernamelabel = new System.Windows.Forms.Label();
            this.LoginReegisterBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButon
            // 
            this.LoginButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LoginButon.Location = new System.Drawing.Point(348, 290);
            this.LoginButon.Name = "LoginButon";
            this.LoginButon.Size = new System.Drawing.Size(100, 39);
            this.LoginButon.TabIndex = 0;
            this.LoginButon.Text = "Log in";
            this.LoginButon.UseVisualStyleBackColor = false;
            this.LoginButon.Click += new System.EventHandler(this.LoginButon_Click);
            // 
            // UsernameLoginBox
            // 
            this.UsernameLoginBox.Location = new System.Drawing.Point(348, 188);
            this.UsernameLoginBox.Name = "UsernameLoginBox";
            this.UsernameLoginBox.Size = new System.Drawing.Size(100, 22);
            this.UsernameLoginBox.TabIndex = 1;
            // 
            // PasswordLoginBox
            // 
            this.PasswordLoginBox.Location = new System.Drawing.Point(348, 246);
            this.PasswordLoginBox.Name = "PasswordLoginBox";
            this.PasswordLoginBox.PasswordChar = '*';
            this.PasswordLoginBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordLoginBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usename";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // wrongpassorusernamelabel
            // 
            this.wrongpassorusernamelabel.AutoSize = true;
            this.wrongpassorusernamelabel.ForeColor = System.Drawing.Color.Red;
            this.wrongpassorusernamelabel.Location = new System.Drawing.Point(345, 270);
            this.wrongpassorusernamelabel.Name = "wrongpassorusernamelabel";
            this.wrongpassorusernamelabel.Size = new System.Drawing.Size(0, 17);
            this.wrongpassorusernamelabel.TabIndex = 5;
            // 
            // LoginReegisterBtn
            // 
            this.LoginReegisterBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.LoginReegisterBtn.Location = new System.Drawing.Point(348, 335);
            this.LoginReegisterBtn.Name = "LoginReegisterBtn";
            this.LoginReegisterBtn.Size = new System.Drawing.Size(100, 39);
            this.LoginReegisterBtn.TabIndex = 6;
            this.LoginReegisterBtn.Text = "Regster";
            this.LoginReegisterBtn.UseVisualStyleBackColor = false;
            this.LoginReegisterBtn.Click += new System.EventHandler(this.LoginReegisterBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(334, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Spremeni Geslo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Spremeni geslo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "staro geslo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "novo geslo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginReegisterBtn);
            this.Controls.Add(this.wrongpassorusernamelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordLoginBox);
            this.Controls.Add(this.UsernameLoginBox);
            this.Controls.Add(this.LoginButon);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Log-in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButon;
        private System.Windows.Forms.TextBox UsernameLoginBox;
        private System.Windows.Forms.TextBox PasswordLoginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wrongpassorusernamelabel;
        private System.Windows.Forms.Button LoginReegisterBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

