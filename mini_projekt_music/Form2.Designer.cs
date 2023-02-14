namespace mini_projekt_music
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
            this.usernameLable = new System.Windows.Forms.Label();
            this.UrGamesRichBox = new System.Windows.Forms.RichTextBox();
            this.YourGamesLabel = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.DodajanjeIgreBtn = new System.Windows.Forms.Button();
            this.AllGamesRIchBox = new System.Windows.Forms.RichTextBox();
            this.AllGamesLabel = new System.Windows.Forms.Label();
            this.DodajanjeIgreBox = new System.Windows.Forms.TextBox();
            this.DeleteGameBOX = new System.Windows.Forms.TextBox();
            this.RemoveGameBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLable
            // 
            this.usernameLable.AutoSize = true;
            this.usernameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLable.Location = new System.Drawing.Point(12, 9);
            this.usernameLable.Name = "usernameLable";
            this.usernameLable.Size = new System.Drawing.Size(0, 17);
            this.usernameLable.TabIndex = 0;
            // 
            // UrGamesRichBox
            // 
            this.UrGamesRichBox.BackColor = System.Drawing.Color.White;
            this.UrGamesRichBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UrGamesRichBox.Location = new System.Drawing.Point(15, 235);
            this.UrGamesRichBox.Name = "UrGamesRichBox";
            this.UrGamesRichBox.Size = new System.Drawing.Size(212, 203);
            this.UrGamesRichBox.TabIndex = 2;
            this.UrGamesRichBox.Text = "";
            // 
            // YourGamesLabel
            // 
            this.YourGamesLabel.AutoSize = true;
            this.YourGamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YourGamesLabel.Location = new System.Drawing.Point(12, 215);
            this.YourGamesLabel.Name = "YourGamesLabel";
            this.YourGamesLabel.Size = new System.Drawing.Size(99, 17);
            this.YourGamesLabel.TabIndex = 2;
            this.YourGamesLabel.Text = "Your games:";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.Red;
            this.LogOutBtn.Location = new System.Drawing.Point(15, 29);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 26);
            this.LogOutBtn.TabIndex = 3;
            this.LogOutBtn.Text = "Log out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // DodajanjeIgreBtn
            // 
            this.DodajanjeIgreBtn.BackColor = System.Drawing.Color.Aqua;
            this.DodajanjeIgreBtn.Location = new System.Drawing.Point(307, 263);
            this.DodajanjeIgreBtn.Name = "DodajanjeIgreBtn";
            this.DodajanjeIgreBtn.Size = new System.Drawing.Size(154, 27);
            this.DodajanjeIgreBtn.TabIndex = 4;
            this.DodajanjeIgreBtn.Text = "Dodaj si novo igro";
            this.DodajanjeIgreBtn.UseVisualStyleBackColor = false;
            this.DodajanjeIgreBtn.Click += new System.EventHandler(this.DodajanjeIgreBtn_Click);
            // 
            // AllGamesRIchBox
            // 
            this.AllGamesRIchBox.BackColor = System.Drawing.Color.White;
            this.AllGamesRIchBox.Location = new System.Drawing.Point(575, 29);
            this.AllGamesRIchBox.Name = "AllGamesRIchBox";
            this.AllGamesRIchBox.Size = new System.Drawing.Size(213, 409);
            this.AllGamesRIchBox.TabIndex = 5;
            this.AllGamesRIchBox.Text = "";
            // 
            // AllGamesLabel
            // 
            this.AllGamesLabel.AutoSize = true;
            this.AllGamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AllGamesLabel.Location = new System.Drawing.Point(572, 9);
            this.AllGamesLabel.Name = "AllGamesLabel";
            this.AllGamesLabel.Size = new System.Drawing.Size(83, 17);
            this.AllGamesLabel.TabIndex = 6;
            this.AllGamesLabel.Text = "All games:";
            // 
            // DodajanjeIgreBox
            // 
            this.DodajanjeIgreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajanjeIgreBox.Location = new System.Drawing.Point(307, 235);
            this.DodajanjeIgreBox.Name = "DodajanjeIgreBox";
            this.DodajanjeIgreBox.Size = new System.Drawing.Size(154, 22);
            this.DodajanjeIgreBox.TabIndex = 7;
            // 
            // DeleteGameBOX
            // 
            this.DeleteGameBOX.Location = new System.Drawing.Point(307, 297);
            this.DeleteGameBOX.Name = "DeleteGameBOX";
            this.DeleteGameBOX.Size = new System.Drawing.Size(154, 22);
            this.DeleteGameBOX.TabIndex = 8;
            // 
            // RemoveGameBTN
            // 
            this.RemoveGameBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RemoveGameBTN.Location = new System.Drawing.Point(307, 325);
            this.RemoveGameBTN.Name = "RemoveGameBTN";
            this.RemoveGameBTN.Size = new System.Drawing.Size(154, 27);
            this.RemoveGameBTN.TabIndex = 9;
            this.RemoveGameBTN.Text = "Odstrani svojo igro";
            this.RemoveGameBTN.UseVisualStyleBackColor = false;
            this.RemoveGameBTN.Click += new System.EventHandler(this.RemoveGameBTN_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveGameBTN);
            this.Controls.Add(this.DeleteGameBOX);
            this.Controls.Add(this.DodajanjeIgreBox);
            this.Controls.Add(this.AllGamesLabel);
            this.Controls.Add(this.AllGamesRIchBox);
            this.Controls.Add(this.DodajanjeIgreBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.YourGamesLabel);
            this.Controls.Add(this.UrGamesRichBox);
            this.Controls.Add(this.usernameLable);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Steeeeeem";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLable;
        private System.Windows.Forms.RichTextBox UrGamesRichBox;
        private System.Windows.Forms.Label YourGamesLabel;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button DodajanjeIgreBtn;
        private System.Windows.Forms.RichTextBox AllGamesRIchBox;
        private System.Windows.Forms.Label AllGamesLabel;
        private System.Windows.Forms.TextBox DodajanjeIgreBox;
        private System.Windows.Forms.TextBox DeleteGameBOX;
        private System.Windows.Forms.Button RemoveGameBTN;
    }
}