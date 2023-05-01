namespace ASI.Forms.Modification.Audiences
{
    partial class ModAudit
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.CommentAuditTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AuditTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.IdAuditTextBox = new System.Windows.Forms.TextBox();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancleBut = new System.Windows.Forms.Button();
            this.ModAuditBut = new System.Windows.Forms.Button();
            this.AddAuditBut = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(584, 230);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поля";
            // 
            // groupBox9
            // 
            this.groupBox9.AutoSize = true;
            this.groupBox9.Controls.Add(this.CommentAuditTextBox);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Location = new System.Drawing.Point(10, 151);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox9.Size = new System.Drawing.Size(564, 64);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Комментарий";
            // 
            // CommentAuditTextBox
            // 
            this.CommentAuditTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommentAuditTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentAuditTextBox.Location = new System.Drawing.Point(10, 23);
            this.CommentAuditTextBox.Name = "CommentAuditTextBox";
            this.CommentAuditTextBox.Size = new System.Drawing.Size(544, 31);
            this.CommentAuditTextBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.AuditTextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(10, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(564, 64);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Корпус - Аудитория";
            // 
            // AuditTextBox
            // 
            this.AuditTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuditTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuditTextBox.Location = new System.Drawing.Point(10, 23);
            this.AuditTextBox.Mask = "99 - 999";
            this.AuditTextBox.Name = "AuditTextBox";
            this.AuditTextBox.Size = new System.Drawing.Size(544, 31);
            this.AuditTextBox.TabIndex = 1;
            this.AuditTextBox.Text = "04";
            // 
            // groupBox10
            // 
            this.groupBox10.AutoSize = true;
            this.groupBox10.Controls.Add(this.IdAuditTextBox);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(10, 23);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox10.Size = new System.Drawing.Size(564, 64);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "ID";
            // 
            // IdAuditTextBox
            // 
            this.IdAuditTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdAuditTextBox.Enabled = false;
            this.IdAuditTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdAuditTextBox.Location = new System.Drawing.Point(10, 23);
            this.IdAuditTextBox.Name = "IdAuditTextBox";
            this.IdAuditTextBox.ReadOnly = true;
            this.IdAuditTextBox.Size = new System.Drawing.Size(544, 31);
            this.IdAuditTextBox.TabIndex = 1;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoLabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(584, 87);
            this.LogoPanel.TabIndex = 9;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Calibri", 25.81132F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.Location = new System.Drawing.Point(107, 23);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(382, 42);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "Добавление аудитории";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancleBut);
            this.groupBox1.Controls.Add(this.ModAuditBut);
            this.groupBox1.Controls.Add(this.AddAuditBut);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(584, 134);
            this.groupBox1.TabIndex = 8;
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
            // ModAuditBut
            // 
            this.ModAuditBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModAuditBut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModAuditBut.Location = new System.Drawing.Point(20, 63);
            this.ModAuditBut.Margin = new System.Windows.Forms.Padding(10);
            this.ModAuditBut.Name = "ModAuditBut";
            this.ModAuditBut.Size = new System.Drawing.Size(544, 30);
            this.ModAuditBut.TabIndex = 1;
            this.ModAuditBut.Text = "Изменить";
            this.ModAuditBut.UseVisualStyleBackColor = true;
            this.ModAuditBut.Click += new System.EventHandler(this.ModAuditBut_Click);
            // 
            // AddAuditBut
            // 
            this.AddAuditBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddAuditBut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAuditBut.Location = new System.Drawing.Point(20, 33);
            this.AddAuditBut.Margin = new System.Windows.Forms.Padding(10);
            this.AddAuditBut.Name = "AddAuditBut";
            this.AddAuditBut.Size = new System.Drawing.Size(544, 30);
            this.AddAuditBut.TabIndex = 0;
            this.AddAuditBut.Text = "Добавить";
            this.AddAuditBut.UseVisualStyleBackColor = true;
            this.AddAuditBut.Click += new System.EventHandler(this.AddAuditBut_Click);
            // 
            // ModAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корпус - Аудитория";
            this.Load += new System.EventHandler(this.ModAudit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.TextBox CommentAuditTextBox;
        private System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.TextBox IdAuditTextBox;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancleBut;
        private System.Windows.Forms.Button ModAuditBut;
        private System.Windows.Forms.Button AddAuditBut;
        public System.Windows.Forms.MaskedTextBox AuditTextBox;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
    }
}