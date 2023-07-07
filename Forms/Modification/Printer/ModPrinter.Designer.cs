
namespace ASI.Forms.Modification.Printer
{
    partial class ModPrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModPrinter));
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ModelComBox = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RoomComBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.InventoryPrinterTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NamePrinterTextBox = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.IdPrinterTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancleBut = new System.Windows.Forms.Button();
            this.ModPrinterBut = new System.Windows.Forms.Button();
            this.AddPrinterBut = new System.Windows.Forms.Button();
            this.LogoPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoLabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(13, 14);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(558, 90);
            this.LogoPanel.TabIndex = 1;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Calibri", 25.81132F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.Location = new System.Drawing.Point(119, 22);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(348, 42);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "Добавление принтер";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(13, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(558, 419);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поля";
            // 
            // groupBox8
            // 
            this.groupBox8.AutoSize = true;
            this.groupBox8.Controls.Add(this.ModelComBox);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(10, 343);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox8.Size = new System.Drawing.Size(538, 64);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Модель";
            // 
            // ModelComBox
            // 
            this.ModelComBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModelComBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelComBox.FormattingEnabled = true;
            this.ModelComBox.Location = new System.Drawing.Point(10, 23);
            this.ModelComBox.Name = "ModelComBox";
            this.ModelComBox.Size = new System.Drawing.Size(518, 31);
            this.ModelComBox.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.Controls.Add(this.NoteTextBox);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(10, 279);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox7.Size = new System.Drawing.Size(538, 64);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Заметки";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoteTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteTextBox.Location = new System.Drawing.Point(10, 23);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(518, 31);
            this.NoteTextBox.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.RoomComBox);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(10, 215);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox6.Size = new System.Drawing.Size(538, 64);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Аудитория";
            // 
            // RoomComBox
            // 
            this.RoomComBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomComBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomComBox.FormattingEnabled = true;
            this.RoomComBox.Location = new System.Drawing.Point(10, 23);
            this.RoomComBox.Name = "RoomComBox";
            this.RoomComBox.Size = new System.Drawing.Size(518, 31);
            this.RoomComBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.InventoryPrinterTextBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(10, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(538, 64);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Инвентарный номер";
            // 
            // InventoryPrinterTextBox
            // 
            this.InventoryPrinterTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryPrinterTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventoryPrinterTextBox.Location = new System.Drawing.Point(10, 23);
            this.InventoryPrinterTextBox.Name = "InventoryPrinterTextBox";
            this.InventoryPrinterTextBox.Size = new System.Drawing.Size(518, 31);
            this.InventoryPrinterTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.NamePrinterTextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(10, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(538, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Название";
            // 
            // NamePrinterTextBox
            // 
            this.NamePrinterTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePrinterTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamePrinterTextBox.Location = new System.Drawing.Point(10, 23);
            this.NamePrinterTextBox.Name = "NamePrinterTextBox";
            this.NamePrinterTextBox.Size = new System.Drawing.Size(518, 31);
            this.NamePrinterTextBox.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.AutoSize = true;
            this.groupBox10.Controls.Add(this.IdPrinterTextBox);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(10, 23);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox10.Size = new System.Drawing.Size(538, 64);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "ID";
            // 
            // IdPrinterTextBox
            // 
            this.IdPrinterTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdPrinterTextBox.Enabled = false;
            this.IdPrinterTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdPrinterTextBox.Location = new System.Drawing.Point(10, 23);
            this.IdPrinterTextBox.Name = "IdPrinterTextBox";
            this.IdPrinterTextBox.ReadOnly = true;
            this.IdPrinterTextBox.Size = new System.Drawing.Size(518, 31);
            this.IdPrinterTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancleBut);
            this.groupBox1.Controls.Add(this.ModPrinterBut);
            this.groupBox1.Controls.Add(this.AddPrinterBut);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(13, 523);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(558, 134);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // CancleBut
            // 
            this.CancleBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancleBut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancleBut.Location = new System.Drawing.Point(20, 93);
            this.CancleBut.Margin = new System.Windows.Forms.Padding(10);
            this.CancleBut.Name = "CancleBut";
            this.CancleBut.Size = new System.Drawing.Size(518, 30);
            this.CancleBut.TabIndex = 2;
            this.CancleBut.Text = "Отмена";
            this.CancleBut.UseVisualStyleBackColor = true;
            this.CancleBut.Click += new System.EventHandler(this.CancleBut_Click);
            // 
            // ModPrinterBut
            // 
            this.ModPrinterBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModPrinterBut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModPrinterBut.Location = new System.Drawing.Point(20, 63);
            this.ModPrinterBut.Margin = new System.Windows.Forms.Padding(10);
            this.ModPrinterBut.Name = "ModPrinterBut";
            this.ModPrinterBut.Size = new System.Drawing.Size(518, 30);
            this.ModPrinterBut.TabIndex = 1;
            this.ModPrinterBut.Text = "Изменить";
            this.ModPrinterBut.UseVisualStyleBackColor = true;
            this.ModPrinterBut.Click += new System.EventHandler(this.ModPrinterBut_Click);
            // 
            // AddPrinterBut
            // 
            this.AddPrinterBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddPrinterBut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPrinterBut.Location = new System.Drawing.Point(20, 33);
            this.AddPrinterBut.Margin = new System.Windows.Forms.Padding(10);
            this.AddPrinterBut.Name = "AddPrinterBut";
            this.AddPrinterBut.Size = new System.Drawing.Size(518, 30);
            this.AddPrinterBut.TabIndex = 0;
            this.AddPrinterBut.Text = "Добавить";
            this.AddPrinterBut.UseVisualStyleBackColor = true;
            this.AddPrinterBut.Click += new System.EventHandler(this.AddPrinterBut_Click);
            // 
            // ModPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(584, 671);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModPrinter";
            this.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Принтер";
            this.Load += new System.EventHandler(this.ModPrinter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModPrinter_KeyDown);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancleBut;
        private System.Windows.Forms.Button ModPrinterBut;
        private System.Windows.Forms.Button AddPrinterBut;
        internal System.Windows.Forms.ComboBox ModelComBox;
        internal System.Windows.Forms.ComboBox RoomComBox;
        internal System.Windows.Forms.TextBox InventoryPrinterTextBox;
        internal System.Windows.Forms.TextBox NamePrinterTextBox;
        public System.Windows.Forms.TextBox IdPrinterTextBox;
        internal System.Windows.Forms.TextBox NoteTextBox;
    }
}