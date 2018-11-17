namespace Client_PM
{
    partial class DLG_Account
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
            this.TBX_Username = new System.Windows.Forms.TextBox();
            this.TBX_Password = new System.Windows.Forms.TextBox();
            this.TBX_VerifyPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_DeleteAccount = new System.Windows.Forms.Button();
            this.IBX_Avatar = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Username
            // 
            this.TBX_Username.Location = new System.Drawing.Point(154, 24);
            this.TBX_Username.Name = "TBX_Username";
            this.TBX_Username.Size = new System.Drawing.Size(173, 26);
            this.TBX_Username.TabIndex = 0;
            // 
            // TBX_Password
            // 
            this.TBX_Password.Location = new System.Drawing.Point(154, 56);
            this.TBX_Password.Name = "TBX_Password";
            this.TBX_Password.Size = new System.Drawing.Size(173, 26);
            this.TBX_Password.TabIndex = 1;
            this.TBX_Password.UseSystemPasswordChar = true;
            // 
            // TBX_VerifyPassword
            // 
            this.TBX_VerifyPassword.Location = new System.Drawing.Point(154, 88);
            this.TBX_VerifyPassword.Name = "TBX_VerifyPassword";
            this.TBX_VerifyPassword.Size = new System.Drawing.Size(173, 26);
            this.TBX_VerifyPassword.TabIndex = 2;
            this.TBX_VerifyPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom d\'usager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vérification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Avatar";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(282, 415);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 29);
            this.BTN_Cancel.TabIndex = 4;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(201, 415);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 29);
            this.BTN_Ok.TabIndex = 3;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // BTN_DeleteAccount
            // 
            this.BTN_DeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_DeleteAccount.Location = new System.Drawing.Point(30, 415);
            this.BTN_DeleteAccount.Name = "BTN_DeleteAccount";
            this.BTN_DeleteAccount.Size = new System.Drawing.Size(116, 29);
            this.BTN_DeleteAccount.TabIndex = 0;
            this.BTN_DeleteAccount.Text = "Supprimer";
            this.BTN_DeleteAccount.UseVisualStyleBackColor = true;
            this.BTN_DeleteAccount.Click += new System.EventHandler(this.BTN_DeleteAccount_Click);
            // 
            // IBX_Avatar
            // 
            this.IBX_Avatar.AllowDrop = true;
            this.IBX_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IBX_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IBX_Avatar.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.IBX_Avatar.ImportImageText = "Import image from file...";
            this.IBX_Avatar.Location = new System.Drawing.Point(30, 165);
            this.IBX_Avatar.Name = "IBX_Avatar";
            this.IBX_Avatar.OpenFileDialogTitle = "Please choose image an file";
            this.IBX_Avatar.PasteMenuText = "Paste image from clipboard";
            this.IBX_Avatar.Size = new System.Drawing.Size(297, 236);
            this.IBX_Avatar.TabIndex = 2;
            this.IBX_Avatar.TabStop = false;
            this.IBX_Avatar.BackgroundImageChanged += new System.EventHandler(this.IBX_Avatar_BackgroundImageChanged);
            // 
            // DLG_Account
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(369, 456);
            this.Controls.Add(this.BTN_DeleteAccount);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.IBX_Avatar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_VerifyPassword);
            this.Controls.Add(this.TBX_Password);
            this.Controls.Add(this.TBX_Username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DLG_Account";
            this.Text = "DLG_Account";
            this.Load += new System.EventHandler(this.DLG_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IBX_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Username;
        private System.Windows.Forms.TextBox TBX_Password;
        private System.Windows.Forms.TextBox TBX_VerifyPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private PhotoManagerClient.ImageBox IBX_Avatar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_DeleteAccount;
    }
}