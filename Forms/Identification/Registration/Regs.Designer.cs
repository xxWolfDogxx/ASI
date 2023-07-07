
namespace ASI.Forms.Identification.Registration
{
    partial class Regs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regs));
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.RegsGrupBox = new System.Windows.Forms.GroupBox();
            this.ButGroupBox = new System.Windows.Forms.GroupBox();
            this.BackBut = new System.Windows.Forms.Button();
            this.RegsBut = new System.Windows.Forms.Button();
            this.PasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckPassPanel = new System.Windows.Forms.Panel();
            this.CheckPassBox = new System.Windows.Forms.CheckBox();
            this.PassRepitGroupBox = new System.Windows.Forms.GroupBox();
            this.PassRepitTextBox = new System.Windows.Forms.TextBox();
            this.PassGroupBox = new System.Windows.Forms.GroupBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.RoleGR = new System.Windows.Forms.GroupBox();
            this.RoleComBox = new System.Windows.Forms.ComboBox();
            this.EmailGroupBox = new System.Windows.Forms.GroupBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneGroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneMaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DateOfBirthGroupBox = new System.Windows.Forms.GroupBox();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FIOGroupBox = new System.Windows.Forms.GroupBox();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.LogoPanel.SuspendLayout();
            this.RegsGrupBox.SuspendLayout();
            this.ButGroupBox.SuspendLayout();
            this.PasswordGroupBox.SuspendLayout();
            this.CheckPassPanel.SuspendLayout();
            this.PassRepitGroupBox.SuspendLayout();
            this.PassGroupBox.SuspendLayout();
            this.RoleGR.SuspendLayout();
            this.EmailGroupBox.SuspendLayout();
            this.PhoneGroupBox.SuspendLayout();
            this.DateOfBirthGroupBox.SuspendLayout();
            this.FIOGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoLabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(13, 14);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(554, 83);
            this.LogoPanel.TabIndex = 0;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Calibri", 25.81132F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.Location = new System.Drawing.Point(98, 19);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(273, 42);
            this.LogoLabel.TabIndex = 1;
            this.LogoLabel.Text = "Регистрация ASI";
            // 
            // RegsGrupBox
            // 
            this.RegsGrupBox.AutoSize = true;
            this.RegsGrupBox.Controls.Add(this.ButGroupBox);
            this.RegsGrupBox.Controls.Add(this.PasswordGroupBox);
            this.RegsGrupBox.Controls.Add(this.RoleGR);
            this.RegsGrupBox.Controls.Add(this.EmailGroupBox);
            this.RegsGrupBox.Controls.Add(this.PhoneGroupBox);
            this.RegsGrupBox.Controls.Add(this.DateOfBirthGroupBox);
            this.RegsGrupBox.Controls.Add(this.FIOGroupBox);
            this.RegsGrupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegsGrupBox.Font = new System.Drawing.Font("Calibri", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegsGrupBox.Location = new System.Drawing.Point(13, 97);
            this.RegsGrupBox.Name = "RegsGrupBox";
            this.RegsGrupBox.Size = new System.Drawing.Size(554, 660);
            this.RegsGrupBox.TabIndex = 1;
            this.RegsGrupBox.TabStop = false;
            this.RegsGrupBox.Text = "Анкета";
            // 
            // ButGroupBox
            // 
            this.ButGroupBox.AutoSize = true;
            this.ButGroupBox.Controls.Add(this.BackBut);
            this.ButGroupBox.Controls.Add(this.RegsBut);
            this.ButGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButGroupBox.Location = new System.Drawing.Point(3, 549);
            this.ButGroupBox.Name = "ButGroupBox";
            this.ButGroupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.ButGroupBox.Size = new System.Drawing.Size(548, 108);
            this.ButGroupBox.TabIndex = 5;
            this.ButGroupBox.TabStop = false;
            // 
            // BackBut
            // 
            this.BackBut.AutoSize = true;
            this.BackBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackBut.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBut.Location = new System.Drawing.Point(15, 61);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(518, 37);
            this.BackBut.TabIndex = 1;
            this.BackBut.Text = "Вернуться назад";
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // RegsBut
            // 
            this.RegsBut.AutoSize = true;
            this.RegsBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegsBut.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegsBut.Location = new System.Drawing.Point(15, 24);
            this.RegsBut.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.RegsBut.Name = "RegsBut";
            this.RegsBut.Size = new System.Drawing.Size(518, 37);
            this.RegsBut.TabIndex = 0;
            this.RegsBut.Text = "Зарегистрироваться";
            this.RegsBut.UseVisualStyleBackColor = true;
            this.RegsBut.Click += new System.EventHandler(this.RegsBut_Click);
            // 
            // PasswordGroupBox
            // 
            this.PasswordGroupBox.AutoSize = true;
            this.PasswordGroupBox.BackColor = System.Drawing.Color.Silver;
            this.PasswordGroupBox.Controls.Add(this.CheckPassPanel);
            this.PasswordGroupBox.Controls.Add(this.PassRepitGroupBox);
            this.PasswordGroupBox.Controls.Add(this.PassGroupBox);
            this.PasswordGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordGroupBox.Font = new System.Drawing.Font("Calibri", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordGroupBox.Location = new System.Drawing.Point(3, 356);
            this.PasswordGroupBox.Name = "PasswordGroupBox";
            this.PasswordGroupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.PasswordGroupBox.Size = new System.Drawing.Size(548, 193);
            this.PasswordGroupBox.TabIndex = 4;
            this.PasswordGroupBox.TabStop = false;
            this.PasswordGroupBox.Text = "Безопастность";
            // 
            // CheckPassPanel
            // 
            this.CheckPassPanel.AutoSize = true;
            this.CheckPassPanel.Controls.Add(this.CheckPassBox);
            this.CheckPassPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckPassPanel.Location = new System.Drawing.Point(15, 158);
            this.CheckPassPanel.Name = "CheckPassPanel";
            this.CheckPassPanel.Size = new System.Drawing.Size(518, 25);
            this.CheckPassPanel.TabIndex = 6;
            // 
            // CheckPassBox
            // 
            this.CheckPassBox.AutoSize = true;
            this.CheckPassBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckPassBox.Font = new System.Drawing.Font("Calibri", 12.22642F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPassBox.Location = new System.Drawing.Point(0, 0);
            this.CheckPassBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckPassBox.Name = "CheckPassBox";
            this.CheckPassBox.Size = new System.Drawing.Size(518, 25);
            this.CheckPassBox.TabIndex = 5;
            this.CheckPassBox.Text = "Показать пароль";
            this.CheckPassBox.UseVisualStyleBackColor = true;
            this.CheckPassBox.CheckedChanged += new System.EventHandler(this.CheckPassBox_CheckedChanged);
            // 
            // PassRepitGroupBox
            // 
            this.PassRepitGroupBox.AutoSize = true;
            this.PassRepitGroupBox.Controls.Add(this.PassRepitTextBox);
            this.PassRepitGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PassRepitGroupBox.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassRepitGroupBox.Location = new System.Drawing.Point(15, 91);
            this.PassRepitGroupBox.Name = "PassRepitGroupBox";
            this.PassRepitGroupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.PassRepitGroupBox.Size = new System.Drawing.Size(518, 67);
            this.PassRepitGroupBox.TabIndex = 5;
            this.PassRepitGroupBox.TabStop = false;
            this.PassRepitGroupBox.Text = "Повторите пароль*";
            // 
            // PassRepitTextBox
            // 
            this.PassRepitTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PassRepitTextBox.Location = new System.Drawing.Point(15, 30);
            this.PassRepitTextBox.MaxLength = 50;
            this.PassRepitTextBox.Name = "PassRepitTextBox";
            this.PassRepitTextBox.Size = new System.Drawing.Size(488, 27);
            this.PassRepitTextBox.TabIndex = 1;
            this.PassRepitTextBox.UseSystemPasswordChar = true;
            // 
            // PassGroupBox
            // 
            this.PassGroupBox.AutoSize = true;
            this.PassGroupBox.Controls.Add(this.PassTextBox);
            this.PassGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PassGroupBox.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassGroupBox.Location = new System.Drawing.Point(15, 24);
            this.PassGroupBox.Name = "PassGroupBox";
            this.PassGroupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.PassGroupBox.Size = new System.Drawing.Size(518, 67);
            this.PassGroupBox.TabIndex = 4;
            this.PassGroupBox.TabStop = false;
            this.PassGroupBox.Text = "Пароль*";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PassTextBox.Location = new System.Drawing.Point(15, 30);
            this.PassTextBox.MaxLength = 50;
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(488, 27);
            this.PassTextBox.TabIndex = 1;
            this.PassTextBox.UseSystemPasswordChar = true;
            this.PassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTextBox_KeyPress);
            // 
            // RoleGR
            // 
            this.RoleGR.AutoSize = true;
            this.RoleGR.Controls.Add(this.RoleComBox);
            this.RoleGR.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoleGR.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleGR.Location = new System.Drawing.Point(3, 285);
            this.RoleGR.Name = "RoleGR";
            this.RoleGR.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.RoleGR.Size = new System.Drawing.Size(548, 71);
            this.RoleGR.TabIndex = 6;
            this.RoleGR.TabStop = false;
            this.RoleGR.Text = "Роль*";
            // 
            // RoleComBox
            // 
            this.RoleComBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoleComBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleComBox.FormattingEnabled = true;
            this.RoleComBox.Location = new System.Drawing.Point(15, 30);
            this.RoleComBox.Name = "RoleComBox";
            this.RoleComBox.Size = new System.Drawing.Size(518, 31);
            this.RoleComBox.TabIndex = 2;
            // 
            // EmailGroupBox
            // 
            this.EmailGroupBox.AutoSize = true;
            this.EmailGroupBox.Controls.Add(this.EmailTextBox);
            this.EmailGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailGroupBox.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailGroupBox.Location = new System.Drawing.Point(3, 218);
            this.EmailGroupBox.Name = "EmailGroupBox";
            this.EmailGroupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.EmailGroupBox.Size = new System.Drawing.Size(548, 67);
            this.EmailGroupBox.TabIndex = 3;
            this.EmailGroupBox.TabStop = false;
            this.EmailGroupBox.Text = "Логин*";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailTextBox.Location = new System.Drawing.Point(15, 30);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(518, 27);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextBox_KeyPress);
            // 
            // PhoneGroupBox
            // 
            this.PhoneGroupBox.AutoSize = true;
            this.PhoneGroupBox.Controls.Add(this.PhoneMaskTextBox);
            this.PhoneGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhoneGroupBox.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneGroupBox.Location = new System.Drawing.Point(3, 151);
            this.PhoneGroupBox.Name = "PhoneGroupBox";
            this.PhoneGroupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.PhoneGroupBox.Size = new System.Drawing.Size(548, 67);
            this.PhoneGroupBox.TabIndex = 2;
            this.PhoneGroupBox.TabStop = false;
            this.PhoneGroupBox.Text = "Номер телефона*";
            // 
            // PhoneMaskTextBox
            // 
            this.PhoneMaskTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhoneMaskTextBox.Location = new System.Drawing.Point(15, 30);
            this.PhoneMaskTextBox.Mask = "+7 (999) 999-99-99";
            this.PhoneMaskTextBox.Name = "PhoneMaskTextBox";
            this.PhoneMaskTextBox.Size = new System.Drawing.Size(518, 27);
            this.PhoneMaskTextBox.TabIndex = 0;
            // 
            // DateOfBirthGroupBox
            // 
            this.DateOfBirthGroupBox.AutoSize = true;
            this.DateOfBirthGroupBox.Controls.Add(this.DateOfBirthDateTimePicker);
            this.DateOfBirthGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateOfBirthGroupBox.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthGroupBox.Location = new System.Drawing.Point(3, 84);
            this.DateOfBirthGroupBox.Name = "DateOfBirthGroupBox";
            this.DateOfBirthGroupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.DateOfBirthGroupBox.Size = new System.Drawing.Size(548, 67);
            this.DateOfBirthGroupBox.TabIndex = 1;
            this.DateOfBirthGroupBox.TabStop = false;
            this.DateOfBirthGroupBox.Text = "Дата рождения*";
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.CalendarFont = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthDateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.DateOfBirthDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(15, 30);
            this.DateOfBirthDateTimePicker.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.DateOfBirthDateTimePicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(518, 27);
            this.DateOfBirthDateTimePicker.TabIndex = 1;
            this.DateOfBirthDateTimePicker.Value = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            // 
            // FIOGroupBox
            // 
            this.FIOGroupBox.AutoSize = true;
            this.FIOGroupBox.Controls.Add(this.FIOTextBox);
            this.FIOGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FIOGroupBox.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOGroupBox.Location = new System.Drawing.Point(3, 17);
            this.FIOGroupBox.Name = "FIOGroupBox";
            this.FIOGroupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.FIOGroupBox.Size = new System.Drawing.Size(548, 67);
            this.FIOGroupBox.TabIndex = 0;
            this.FIOGroupBox.TabStop = false;
            this.FIOGroupBox.Text = "ФИО*";
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FIOTextBox.Location = new System.Drawing.Point(15, 30);
            this.FIOTextBox.MaxLength = 50;
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(518, 27);
            this.FIOTextBox.TabIndex = 0;
            this.FIOTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FIOTextBox_KeyPress);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Regs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(580, 763);
            this.Controls.Add(this.RegsGrupBox);
            this.Controls.Add(this.LogoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Regs";
            this.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Regs_FormClosed);
            this.Load += new System.EventHandler(this.Regs_Load);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.RegsGrupBox.ResumeLayout(false);
            this.RegsGrupBox.PerformLayout();
            this.ButGroupBox.ResumeLayout(false);
            this.ButGroupBox.PerformLayout();
            this.PasswordGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.PerformLayout();
            this.CheckPassPanel.ResumeLayout(false);
            this.CheckPassPanel.PerformLayout();
            this.PassRepitGroupBox.ResumeLayout(false);
            this.PassRepitGroupBox.PerformLayout();
            this.PassGroupBox.ResumeLayout(false);
            this.PassGroupBox.PerformLayout();
            this.RoleGR.ResumeLayout(false);
            this.EmailGroupBox.ResumeLayout(false);
            this.EmailGroupBox.PerformLayout();
            this.PhoneGroupBox.ResumeLayout(false);
            this.PhoneGroupBox.PerformLayout();
            this.DateOfBirthGroupBox.ResumeLayout(false);
            this.FIOGroupBox.ResumeLayout(false);
            this.FIOGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.GroupBox RegsGrupBox;
        private System.Windows.Forms.GroupBox FIOGroupBox;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.GroupBox PhoneGroupBox;
        private System.Windows.Forms.MaskedTextBox PhoneMaskTextBox;
        private System.Windows.Forms.GroupBox DateOfBirthGroupBox;
        private System.Windows.Forms.GroupBox EmailGroupBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.GroupBox PasswordGroupBox;
        private System.Windows.Forms.GroupBox PassGroupBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Panel CheckPassPanel;
        private System.Windows.Forms.CheckBox CheckPassBox;
        private System.Windows.Forms.GroupBox ButGroupBox;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.Button RegsBut;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.GroupBox PassRepitGroupBox;
        private System.Windows.Forms.TextBox PassRepitTextBox;
        private System.Windows.Forms.GroupBox RoleGR;
        internal System.Windows.Forms.ComboBox RoleComBox;
    }
}