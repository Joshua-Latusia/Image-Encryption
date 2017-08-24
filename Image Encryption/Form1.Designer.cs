namespace Image_Encryption
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.KeyGenButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.decryptButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(767, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToUseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.howToUseToolStripMenuItem.Text = "How to use ";
            // 
            // EncryptionTextBox
            // 
            this.EncryptionTextBox.Location = new System.Drawing.Point(12, 51);
            this.EncryptionTextBox.MaxLength = 3000;
            this.EncryptionTextBox.Name = "EncryptionTextBox";
            this.EncryptionTextBox.Size = new System.Drawing.Size(306, 216);
            this.EncryptionTextBox.TabIndex = 2;
            this.EncryptionTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Text To Encrypt:";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 273);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(150, 23);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(168, 273);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(150, 23);
            this.ImportButton.TabIndex = 5;
            this.ImportButton.Text = "Import Image";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(12, 302);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(150, 23);
            this.CopyButton.TabIndex = 6;
            this.CopyButton.Text = "Copy To Clipboard";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(168, 302);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Write To File";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(18, 380);
            this.EmailTextBox.MaxLength = 150;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(300, 20);
            this.EmailTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Email To Send Image:";
            // 
            // EmailButton
            // 
            this.EmailButton.Location = new System.Drawing.Point(18, 406);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(300, 23);
            this.EmailButton.TabIndex = 10;
            this.EmailButton.Text = "Send Email";
            this.EmailButton.UseVisualStyleBackColor = true;
            this.EmailButton.Click += new System.EventHandler(this.EmailButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Encryption Key:";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Enabled = false;
            this.KeyTextBox.Location = new System.Drawing.Point(429, 409);
            this.KeyTextBox.MaxLength = 80;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(191, 20);
            this.KeyTextBox.TabIndex = 12;
            // 
            // KeyGenButton
            // 
            this.KeyGenButton.Location = new System.Drawing.Point(626, 407);
            this.KeyGenButton.Name = "KeyGenButton";
            this.KeyGenButton.Size = new System.Drawing.Size(110, 23);
            this.KeyGenButton.TabIndex = 13;
            this.KeyGenButton.Text = "Generate Key";
            this.KeyGenButton.UseVisualStyleBackColor = true;
            this.KeyGenButton.Click += new System.EventHandler(this.KeyGenButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(388, 299);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(345, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(391, 349);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(12, 331);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(150, 23);
            this.decryptButton.TabIndex = 16;
            this.decryptButton.Text = "Decrypt Image";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(168, 331);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 23);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 444);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.KeyGenButton);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncryptionTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto Img V0.1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.RichTextBox EncryptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button KeyGenButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

