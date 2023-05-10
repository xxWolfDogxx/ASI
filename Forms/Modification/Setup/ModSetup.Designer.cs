
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
            this.noteGR = new System.Windows.Forms.GroupBox();
            this.NoteSetupTextBox = new System.Windows.Forms.TextBox();
            this.endGB = new System.Windows.Forms.GroupBox();
            this.DateEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startGR = new System.Windows.Forms.GroupBox();
            this.DateStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.printerGR = new System.Windows.Forms.GroupBox();
            this.PrinterSetupComBox = new System.Windows.Forms.ComboBox();
            this.consumableGR = new System.Windows.Forms.GroupBox();
            this.CartrigeSetupComBox = new System.Windows.Forms.ComboBox();
            this.idGR = new System.Windows.Forms.GroupBox();
            this.IdSetupTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancleBut = new System.Windows.Forms.Button();
            this.ModSetupBut = new System.Windows.Forms.Button();
            this.AddSetupBut = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.noteGR.SuspendLayout();
            this.endGB.SuspendLayout();
            this.startGR.SuspendLayout();
            this.printerGR.SuspendLayout();
            this.consumableGR.SuspendLayout();
            this.idGR.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.noteGR);
            this.groupBox2.Controls.Add(this.endGB);
            this.groupBox2.Controls.Add(this.startGR);
            this.groupBox2.Controls.Add(this.printerGR);
            this.groupBox2.Controls.Add(this.consumableGR);
            this.groupBox2.Controls.Add(this.idGR);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(584, 410);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поля";
            // 
            // noteGR
            // 
            this.noteGR.AutoSize = true;
            this.noteGR.Controls.Add(this.NoteSetupTextBox);
            this.noteGR.Dock = System.Windows.Forms.DockStyle.Top;
            this.noteGR.Location = new System.Drawing.Point(10, 341);
            this.noteGR.Name = "noteGR";
            this.noteGR.Padding = new System.Windows.Forms.Padding(10);
            this.noteGR.Size = new System.Drawing.Size(564, 64);
            this.noteGR.TabIndex = 6;
            this.noteGR.TabStop = false;
            this.noteGR.Text = "Заметки";
            // 
            // NoteSetupTextBox
            // 
            this.NoteSetupTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoteSetupTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteSetupTextBox.Location = new System.Drawing.Point(10, 23);
            this.NoteSetupTextBox.Name = "NoteSetupTextBox";
            this.NoteSetupTextBox.Size = new System.Drawing.Size(544, 31);
            this.NoteSetupTextBox.TabIndex = 1;
            // 
            // endGB
            // 
            this.endGB.AutoSize = true;
            this.endGB.Controls.Add(this.DateEndDatePicker);
            this.endGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.endGB.Location = new System.Drawing.Point(10, 278);
            this.endGB.Name = "endGB";
            this.endGB.Padding = new System.Windows.Forms.Padding(10);
            this.endGB.Size = new System.Drawing.Size(564, 63);
            this.endGB.TabIndex = 5;
            this.endGB.TabStop = false;
            this.endGB.Text = "Дата снятия";
            // 
            // DateEndDatePicker
            // 
            this.DateEndDatePicker.Checked = false;
            this.DateEndDatePicker.CustomFormat = "";
            this.DateEndDatePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateEndDatePicker.Font = new System.Drawing.Font("Calibri", 14F);
            this.DateEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEndDatePicker.Location = new System.Drawing.Point(10, 23);
            this.DateEndDatePicker.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.DateEndDatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateEndDatePicker.Name = "DateEndDatePicker";
            this.DateEndDatePicker.ShowCheckBox = true;
            this.DateEndDatePicker.Size = new System.Drawing.Size(544, 30);
            this.DateEndDatePicker.TabIndex = 2;
            this.DateEndDatePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateEndDatePicker.ValueChanged += new System.EventHandler(this.DateEndDatePicker_ValueChanged);
            // 
            // startGR
            // 
            this.startGR.AutoSize = true;
            this.startGR.Controls.Add(this.DateStartDatePicker);
            this.startGR.Dock = System.Windows.Forms.DockStyle.Top;
            this.startGR.Location = new System.Drawing.Point(10, 215);
            this.startGR.Name = "startGR";
            this.startGR.Padding = new System.Windows.Forms.Padding(10);
            this.startGR.Size = new System.Drawing.Size(564, 63);
            this.startGR.TabIndex = 4;
            this.startGR.TabStop = false;
            this.startGR.Text = "Дата установки";
            // 
            // DateStartDatePicker
            // 
            this.DateStartDatePicker.Checked = false;
            this.DateStartDatePicker.CustomFormat = "dd.MM.yyyy";
            this.DateStartDatePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateStartDatePicker.Font = new System.Drawing.Font("Calibri", 14F);
            this.DateStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStartDatePicker.Location = new System.Drawing.Point(10, 23);
            this.DateStartDatePicker.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.DateStartDatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateStartDatePicker.Name = "DateStartDatePicker";
            this.DateStartDatePicker.Size = new System.Drawing.Size(544, 30);
            this.DateStartDatePicker.TabIndex = 1;
            this.DateStartDatePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // printerGR
            // 
            this.printerGR.AutoSize = true;
            this.printerGR.Controls.Add(this.PrinterSetupComBox);
            this.printerGR.Dock = System.Windows.Forms.DockStyle.Top;
            this.printerGR.Location = new System.Drawing.Point(10, 151);
            this.printerGR.Name = "printerGR";
            this.printerGR.Padding = new System.Windows.Forms.Padding(10);
            this.printerGR.Size = new System.Drawing.Size(564, 64);
            this.printerGR.TabIndex = 3;
            this.printerGR.TabStop = false;
            this.printerGR.Text = "Принтер";
            // 
            // PrinterSetupComBox
            // 
            this.PrinterSetupComBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrinterSetupComBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrinterSetupComBox.FormattingEnabled = true;
            this.PrinterSetupComBox.Location = new System.Drawing.Point(10, 23);
            this.PrinterSetupComBox.Name = "PrinterSetupComBox";
            this.PrinterSetupComBox.Size = new System.Drawing.Size(544, 31);
            this.PrinterSetupComBox.TabIndex = 2;
            // 
            // consumableGR
            // 
            this.consumableGR.AutoSize = true;
            this.consumableGR.Controls.Add(this.CartrigeSetupComBox);
            this.consumableGR.Dock = System.Windows.Forms.DockStyle.Top;
            this.consumableGR.Location = new System.Drawing.Point(10, 87);
            this.consumableGR.Name = "consumableGR";
            this.consumableGR.Padding = new System.Windows.Forms.Padding(10);
            this.consumableGR.Size = new System.Drawing.Size(564, 64);
            this.consumableGR.TabIndex = 2;
            this.consumableGR.TabStop = false;
            this.consumableGR.Text = "Расходник";
            // 
            // CartrigeSetupComBox
            // 
            this.CartrigeSetupComBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CartrigeSetupComBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartrigeSetupComBox.FormattingEnabled = true;
            this.CartrigeSetupComBox.Location = new System.Drawing.Point(10, 23);
            this.CartrigeSetupComBox.Name = "CartrigeSetupComBox";
            this.CartrigeSetupComBox.Size = new System.Drawing.Size(544, 31);
            this.CartrigeSetupComBox.TabIndex = 3;
            this.CartrigeSetupComBox.SelectionChangeCommitted += new System.EventHandler(this.CartrigeSetupComBox_SelectionChangeCommitted);
            // 
            // idGR
            // 
            this.idGR.AutoSize = true;
            this.idGR.Controls.Add(this.IdSetupTextBox);
            this.idGR.Dock = System.Windows.Forms.DockStyle.Top;
            this.idGR.Location = new System.Drawing.Point(10, 23);
            this.idGR.Name = "idGR";
            this.idGR.Padding = new System.Windows.Forms.Padding(10);
            this.idGR.Size = new System.Drawing.Size(564, 64);
            this.idGR.TabIndex = 1;
            this.idGR.TabStop = false;
            this.idGR.Text = "ID";
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
            this.groupBox1.Location = new System.Drawing.Point(0, 500);
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
            this.ClientSize = new System.Drawing.Size(584, 634);
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
            this.noteGR.ResumeLayout(false);
            this.noteGR.PerformLayout();
            this.endGB.ResumeLayout(false);
            this.startGR.ResumeLayout(false);
            this.printerGR.ResumeLayout(false);
            this.consumableGR.ResumeLayout(false);
            this.idGR.ResumeLayout(false);
            this.idGR.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox endGB;
        private System.Windows.Forms.DateTimePicker DateEndDatePicker;
        private System.Windows.Forms.GroupBox startGR;
        private System.Windows.Forms.DateTimePicker DateStartDatePicker;
        private System.Windows.Forms.GroupBox consumableGR;
        private System.Windows.Forms.GroupBox printerGR;
        private System.Windows.Forms.GroupBox idGR;
        public System.Windows.Forms.TextBox IdSetupTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancleBut;
        private System.Windows.Forms.Button ModSetupBut;
        private System.Windows.Forms.Button AddSetupBut;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.GroupBox noteGR;
        public System.Windows.Forms.TextBox NoteSetupTextBox;
        internal System.Windows.Forms.ComboBox CartrigeSetupComBox;
        internal System.Windows.Forms.ComboBox PrinterSetupComBox;
    }
}