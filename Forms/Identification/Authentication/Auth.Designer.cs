
namespace ASI.Forms.Identification.Authentication
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.ImageIdent = new System.Windows.Forms.ImageList(this.components);
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.DopGrupBox = new System.Windows.Forms.Panel();
            this.ForgotPassLinkLabel = new System.Windows.Forms.LinkLabel();
            this.RegsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AuthButGrupBox = new System.Windows.Forms.GroupBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.CheckPassPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CheckPassBox = new System.Windows.Forms.CheckBox();
            this.PassGrupBox = new System.Windows.Forms.GroupBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.LoginGrupBox = new System.Windows.Forms.GroupBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LogoPanel.SuspendLayout();
            this.AuthPanel.SuspendLayout();
            this.DopGrupBox.SuspendLayout();
            this.AuthButGrupBox.SuspendLayout();
            this.CheckPassPanel.SuspendLayout();
            this.PassGrupBox.SuspendLayout();
            this.LoginGrupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageIdent
            // 
            this.ImageIdent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageIdent.ImageStream")));
            this.ImageIdent.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageIdent.Images.SetKeyName(0, "309058_key_login_private_protect_protection_icon.png");
            this.ImageIdent.Images.SetKeyName(1, "511942_lock_login_protection_secure_icon.png");
            this.ImageIdent.Images.SetKeyName(2, "2203549_admin_avatar_human_login_user_icon.png");
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoLabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(13, 14);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(504, 90);
            this.LogoPanel.TabIndex = 0;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Calibri", 25.81132F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.Location = new System.Drawing.Point(230, 22);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(64, 42);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "ASI";
            // 
            // AuthPanel
            // 
            this.AuthPanel.Controls.Add(this.DopGrupBox);
            this.AuthPanel.Controls.Add(this.AuthButGrupBox);
            this.AuthPanel.Controls.Add(this.CheckPassPanel);
            this.AuthPanel.Controls.Add(this.PassGrupBox);
            this.AuthPanel.Controls.Add(this.LoginGrupBox);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthPanel.Location = new System.Drawing.Point(13, 104);
            this.AuthPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(504, 337);
            this.AuthPanel.TabIndex = 1;
            // 
            // DopGrupBox
            // 
            this.DopGrupBox.Controls.Add(this.ForgotPassLinkLabel);
            this.DopGrupBox.Controls.Add(this.RegsLinkLabel);
            this.DopGrupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DopGrupBox.Location = new System.Drawing.Point(0, 282);
            this.DopGrupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DopGrupBox.Name = "DopGrupBox";
            this.DopGrupBox.Size = new System.Drawing.Size(504, 55);
            this.DopGrupBox.TabIndex = 5;
            // 
            // ForgotPassLinkLabel
            // 
            this.ForgotPassLinkLabel.AutoSize = true;
            this.ForgotPassLinkLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ForgotPassLinkLabel.Font = new System.Drawing.Font("Calibri", 10.26415F, System.Drawing.FontStyle.Italic);
            this.ForgotPassLinkLabel.Location = new System.Drawing.Point(422, 0);
            this.ForgotPassLinkLabel.Name = "ForgotPassLinkLabel";
            this.ForgotPassLinkLabel.Size = new System.Drawing.Size(82, 17);
            this.ForgotPassLinkLabel.TabIndex = 5;
            this.ForgotPassLinkLabel.TabStop = true;
            this.ForgotPassLinkLabel.Text = "База данных";
            this.ForgotPassLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPassLinkLabel_LinkClicked);
            // 
            // RegsLinkLabel
            // 
            this.RegsLinkLabel.AutoSize = true;
            this.RegsLinkLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegsLinkLabel.Font = new System.Drawing.Font("Calibri", 10.26415F, System.Drawing.FontStyle.Italic);
            this.RegsLinkLabel.Location = new System.Drawing.Point(0, 0);
            this.RegsLinkLabel.Name = "RegsLinkLabel";
            this.RegsLinkLabel.Size = new System.Drawing.Size(145, 17);
            this.RegsLinkLabel.TabIndex = 4;
            this.RegsLinkLabel.TabStop = true;
            this.RegsLinkLabel.Text = "Зарегистрироваться?";
            this.RegsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegsLinkLabel_LinkClicked);
            // 
            // AuthButGrupBox
            // 
            this.AuthButGrupBox.Controls.Add(this.AuthButton);
            this.AuthButGrupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthButGrupBox.Location = new System.Drawing.Point(0, 196);
            this.AuthButGrupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuthButGrupBox.Name = "AuthButGrupBox";
            this.AuthButGrupBox.Padding = new System.Windows.Forms.Padding(10);
            this.AuthButGrupBox.Size = new System.Drawing.Size(504, 86);
            this.AuthButGrupBox.TabIndex = 4;
            this.AuthButGrupBox.TabStop = false;
            // 
            // AuthButton
            // 
            this.AuthButton.AutoSize = true;
            this.AuthButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AuthButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthButton.Font = new System.Drawing.Font("Calibri", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.Location = new System.Drawing.Point(10, 27);
            this.AuthButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(484, 49);
            this.AuthButton.TabIndex = 5;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // CheckPassPanel
            // 
            this.CheckPassPanel.Controls.Add(this.ErrorLabel);
            this.CheckPassPanel.Controls.Add(this.CheckPassBox);
            this.CheckPassPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckPassPanel.Location = new System.Drawing.Point(0, 150);
            this.CheckPassPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckPassPanel.Name = "CheckPassPanel";
            this.CheckPassPanel.Size = new System.Drawing.Size(504, 46);
            this.CheckPassPanel.TabIndex = 3;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorLabel.Location = new System.Drawing.Point(0, 27);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(204, 19);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "Неверный логин или пароль";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckPassBox
            // 
            this.CheckPassBox.AutoSize = true;
            this.CheckPassBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CheckPassBox.Font = new System.Drawing.Font("Calibri", 12.22642F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPassBox.Location = new System.Drawing.Point(344, 0);
            this.CheckPassBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckPassBox.Name = "CheckPassBox";
            this.CheckPassBox.Size = new System.Drawing.Size(160, 46);
            this.CheckPassBox.TabIndex = 4;
            this.CheckPassBox.Text = "Показать пароль";
            this.CheckPassBox.UseVisualStyleBackColor = true;
            this.CheckPassBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PassGrupBox
            // 
            this.PassGrupBox.AutoSize = true;
            this.PassGrupBox.Controls.Add(this.PassTextBox);
            this.PassGrupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PassGrupBox.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassGrupBox.Location = new System.Drawing.Point(0, 75);
            this.PassGrupBox.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.PassGrupBox.Name = "PassGrupBox";
            this.PassGrupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.PassGrupBox.Size = new System.Drawing.Size(504, 75);
            this.PassGrupBox.TabIndex = 1;
            this.PassGrupBox.TabStop = false;
            this.PassGrupBox.Text = "Пароль";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PassTextBox.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTextBox.Location = new System.Drawing.Point(15, 34);
            this.PassTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassTextBox.MaxLength = 50;
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(474, 31);
            this.PassTextBox.TabIndex = 1;
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // LoginGrupBox
            // 
            this.LoginGrupBox.AutoSize = true;
            this.LoginGrupBox.Controls.Add(this.LoginTextBox);
            this.LoginGrupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginGrupBox.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginGrupBox.Location = new System.Drawing.Point(0, 0);
            this.LoginGrupBox.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.LoginGrupBox.Name = "LoginGrupBox";
            this.LoginGrupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.LoginGrupBox.Size = new System.Drawing.Size(504, 75);
            this.LoginGrupBox.TabIndex = 0;
            this.LoginGrupBox.TabStop = false;
            this.LoginGrupBox.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginTextBox.Location = new System.Drawing.Point(15, 34);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginTextBox.MaxLength = 50;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(474, 31);
            this.LoginTextBox.TabIndex = 0;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(530, 455);
            this.Controls.Add(this.AuthPanel);
            this.Controls.Add(this.LogoPanel);
            this.Font = new System.Drawing.Font("Calibri", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Auth";
            this.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Auth_FormClosed);
            this.Load += new System.EventHandler(this.Auth_Load);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.DopGrupBox.ResumeLayout(false);
            this.DopGrupBox.PerformLayout();
            this.AuthButGrupBox.ResumeLayout(false);
            this.AuthButGrupBox.PerformLayout();
            this.CheckPassPanel.ResumeLayout(false);
            this.CheckPassPanel.PerformLayout();
            this.PassGrupBox.ResumeLayout(false);
            this.PassGrupBox.PerformLayout();
            this.LoginGrupBox.ResumeLayout(false);
            this.LoginGrupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ImageIdent;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.GroupBox LoginGrupBox;
        private System.Windows.Forms.GroupBox PassGrupBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Panel CheckPassPanel;
        private System.Windows.Forms.CheckBox CheckPassBox;
        private System.Windows.Forms.GroupBox AuthButGrupBox;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Panel DopGrupBox;
        private System.Windows.Forms.LinkLabel ForgotPassLinkLabel;
        private System.Windows.Forms.LinkLabel RegsLinkLabel;
        private System.Windows.Forms.Label ErrorLabel;
    //    private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
    }
}