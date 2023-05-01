
namespace ASI.Forms.Modification.Setup
{
    partial class ModSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModSetup));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DateWithDrawal = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DateSetup = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NumberCartrigeSetupComBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InventPrinterSetupComBox = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.IdSetupTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancleBut = new System.Windows.Forms.Button();
            this.ModSetupBut = new System.Windows.Forms.Button();
            this.AddSetupBut = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(584, 351);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поля";
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.DateWithDrawal);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(10, 278);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox6.Size = new System.Drawing.Size(564, 63);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Дата снятия";
            // 
            // DateWithDrawal
            // 
            this.DateWithDrawal.CustomFormat = "dd.MM.yyyy";
            this.DateWithDrawal.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateWithDrawal.Font = new System.Drawing.Font("Calibri", 14F);
            this.DateWithDrawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateWithDrawal.Location = new System.Drawing.Point(10, 23);
            this.DateWithDrawal.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.DateWithDrawal.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateWithDrawal.Name = "DateWithDrawal";
            this.DateWithDrawal.Size = new System.Drawing.Size(544, 30);
            this.DateWithDrawal.TabIndex = 2;
            this.DateWithDrawal.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.DateSetup);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(10, 215);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox5.Size = new System.Drawing.Size(564, 63);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Дата установки";
            // 
            // DateSetup
            // 
            this.DateSetup.CustomFormat = "dd.MM.yyyy";
            this.DateSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateSetup.Font = new System.Drawing.Font("Calibri", 14F);
            this.DateSetup.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateSetup.Location = new System.Drawing.Point(10, 23);
            this.DateSetup.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.DateSetup.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateSetup.Name = "DateSetup";
            this.DateSetup.Size = new System.Drawing.Size(544, 30);
            this.DateSetup.TabIndex = 1;
            this.DateSetup.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.NumberCartrigeSetupComBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(10, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(564, 64);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Номер картриджа";
            // 
            // NumberCartrigeSetupComBox
            // 
            this.NumberCartrigeSetupComBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumberCartrigeSetupComBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberCartrigeSetupComBox.FormattingEnabled = true;
            this.NumberCartrigeSetupComBox.Location = new System.Drawing.Point(10, 23);
            this.NumberCartrigeSetupComBox.Name = "NumberCartrigeSetupComBox";
            this.NumberCartrigeSetupComBox.Size = new System.Drawing.Size(544, 31);
            this.NumberCartrigeSetupComBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.InventPrinterSetupComBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(10, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(564, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Инвентарный номер принтера";
            // 
            // InventPrinterSetupComBox
            // 
            this.InventPrinterSetupComBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventPrinterSetupComBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventPrinterSetupComBox.FormattingEnabled = true;
            this.InventPrinterSetupComBox.Location = new System.Drawing.Point(10, 23);
            this.InventPrinterSetupComBox.Name = "InventPrinterSetupComBox";
            this.InventPrinterSetupComBox.Size = new System.Drawing.Size(544, 31);
            this.InventPrinterSetupComBox.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.AutoSize = true;
            this.groupBox10.Controls.Add(this.IdSetupTextBox);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(10, 23);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox10.Size = new System.Drawing.Size(564, 64);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "ID";
            // 
            // IdSetupTextBox
            // 
            this.IdSetupTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdSetupTextBox.Enabled = false;
            this.IdSetupTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdSetupTextBox.Location = new System.Drawing.Point(10, 23);
            this.IdSetupTextBox.Name = "IdSetupTextBox";
            this.IdSetupTextBox.ReadOnly = true;
            this.IdSetupTextBox.Size = new System.Drawing.Size(544, 31);
            this.IdSetupTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancleBut);
            this.groupBox1.Controls.Add(this.ModSetupBut);
            this.groupBox1.Controls.Add(this.AddSetupBut);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(584, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // CancleBut
            // 
            this.CancleBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancleBut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancleBut.Location = new System.Drawing.Point(20, 93);
            this.CancleBut.Margin = new System.Windows.Forms.Padding(10);
            this.CancleBut.Name = "CancleBut";
            this.CancleBut.Size = new System.Drawing.Size(544, 30);
            this.CancleBut.TabIndex = 2;
            this.CancleBut.Text = "Отмена";
            this.CancleBut.UseVisualStyleBackColor = true;
            this.CancleBut.Click += new System.EventHandler(this.CancleBut_Click);
            // 
            // ModSetupBut
            // 
            this.ModSetupBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModSetupBut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModSetupBut.Location = new System.Drawing.Point(20, 63);
            this.ModSetupBut.Margin = new System.Windows.Forms.Padding(10);
            this.ModSetupBut.Name = "ModSetupBut";
            this.ModSetupBut.Size = new System.Drawing.Size(544, 30);
            this.ModSetupBut.TabIndex = 1;
            this.ModSetupBut.Text = "Изменить";
            this.ModSetupBut.UseVisualStyleBackColor = true;
            this.ModSetupBut.Click += new System.EventHandler(this.ModSetupBut_Click);
            // 
            // AddSetupBut
            // 
            this.AddSetupBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddSetupBut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSetupBut.Location = new System.Drawing.Point(20, 33);
            this.AddSetupBut.Margin = new System.Windows.Forms.Padding(10);
            this.AddSetupBut.Name = "AddSetupBut";
            this.AddSetupBut.Size = new System.Drawing.Size(544, 30);
            this.AddSetupBut.TabIndex = 0;
            this.AddSetupBut.Text = "Добавить";
            this.AddSetupBut.UseVisualStyleBackColor = true;
            this.AddSetupBut.Click += new System.EventHandler(this.AddSetupBut_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoLabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(584, 90);
            this.LogoPanel.TabIndex = 4;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Calibri", 25.81132F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.Location = new System.Drawing.Point(142, 24);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(313, 42);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "Добавление записи";
            // 
            // ModSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(584, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Установки";
            this.Load += new System.EventHandler(this.ModSetup_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker DateWithDrawal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker DateSetup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.TextBox IdSetupTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancleBut;
        private System.Windows.Forms.Button ModSetupBut;
        private System.Windows.Forms.Button AddSetupBut;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.ComboBox NumberCartrigeSetupComBox;
        private System.Windows.Forms.ComboBox InventPrinterSetupComBox;
    }
}