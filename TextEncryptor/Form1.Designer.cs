namespace TextEncryptor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTitle = new System.Windows.Forms.Label();
            this.MainText = new System.Windows.Forms.TextBox();
            this.KeyText = new System.Windows.Forms.TextBox();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.KeyTitle = new System.Windows.Forms.Label();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.ResultMsgLabel = new System.Windows.Forms.Label();
            this.SupportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.Location = new System.Drawing.Point(302, 30);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(226, 29);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Encryptor/Decryptor";
            // 
            // MainText
            // 
            this.MainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainText.Location = new System.Drawing.Point(23, 88);
            this.MainText.Multiline = true;
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(773, 254);
            this.MainText.TabIndex = 1;
            // 
            // KeyText
            // 
            this.KeyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyText.Location = new System.Drawing.Point(228, 422);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(359, 26);
            this.KeyText.TabIndex = 2;
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(284, 487);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(119, 40);
            this.EncryptBtn.TabIndex = 3;
            this.EncryptBtn.Text = "Encrypt and copy";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // KeyTitle
            // 
            this.KeyTitle.AutoSize = true;
            this.KeyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTitle.Location = new System.Drawing.Point(347, 383);
            this.KeyTitle.Name = "KeyTitle";
            this.KeyTitle.Size = new System.Drawing.Size(111, 24);
            this.KeyTitle.TabIndex = 5;
            this.KeyTitle.Text = "Custom Key";
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(409, 487);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(119, 40);
            this.DecryptBtn.TabIndex = 6;
            this.DecryptBtn.Text = "Decrypt and copy";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // ResultMsgLabel
            // 
            this.ResultMsgLabel.AutoSize = true;
            this.ResultMsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultMsgLabel.Location = new System.Drawing.Point(289, 541);
            this.ResultMsgLabel.Name = "ResultMsgLabel";
            this.ResultMsgLabel.Size = new System.Drawing.Size(230, 24);
            this.ResultMsgLabel.TabIndex = 7;
            this.ResultMsgLabel.Text = "Resultado de la operación";
            // 
            // SupportBtn
            // 
            this.SupportBtn.Location = new System.Drawing.Point(12, 555);
            this.SupportBtn.Name = "SupportBtn";
            this.SupportBtn.Size = new System.Drawing.Size(75, 23);
            this.SupportBtn.TabIndex = 8;
            this.SupportBtn.Text = "Support";
            this.SupportBtn.UseVisualStyleBackColor = true;
            this.SupportBtn.Click += new System.EventHandler(this.SupportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(749, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "By Schiappa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupportBtn);
            this.Controls.Add(this.ResultMsgLabel);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.KeyTitle);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.KeyText);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.MainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.TextBox MainText;
        private System.Windows.Forms.TextBox KeyText;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Label KeyTitle;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Label ResultMsgLabel;
        private System.Windows.Forms.Button SupportBtn;
        private System.Windows.Forms.Label label1;
    }
}

