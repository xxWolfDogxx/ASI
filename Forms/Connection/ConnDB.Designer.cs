
namespace ASI.Forms.Connection
{
    partial class ConnDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnDB));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoginGrupBox = new System.Windows.Forms.GroupBox();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.CancleBut = new System.Windows.Forms.Button();
            this.SaveConnBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.LoginGrupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveConnBut);
            this.groupBox1.Controls.Add(this.CancleBut);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.LoginGrupBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LoginGrupBox
            // 
            this.LoginGrupBox.AutoSize = true;
            this.LoginGrupBox.Controls.Add(this.ServerTextBox);
            this.LoginGrupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginGrupBox.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginGrupBox.Location = new System.Drawing.Point(3, 16);
            this.LoginGrupBox.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.LoginGrupBox.Name = "LoginGrupBox";
            this.LoginGrupBox.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.LoginGrupBox.Size = new System.Drawing.Size(528, 75);
            this.LoginGrupBox.TabIndex = 1;
            this.LoginGrupBox.TabStop = false;
            this.LoginGrupBox.Text = "Сервер";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServerTextBox.Location = new System.Drawing.Point(15, 34);
            this.ServerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServerTextBox.MaxLength = 50;
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(498, 31);
            this.ServerTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.PortTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.groupBox2.Size = new System.Drawing.Size(528, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Порт";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PortTextBox.Location = new System.Drawing.Point(15, 34);
            this.PortTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortTextBox.MaxLength = 50;
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(498, 31);
            this.PortTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.NameTextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(3, 166);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.groupBox3.Size = new System.Drawing.Size(528, 75);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Название базы данных";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameTextBox.Location = new System.Drawing.Point(15, 34);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(498, 31);
            this.NameTextBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.LoginTextBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(3, 241);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.groupBox4.Size = new System.Drawing.Size(528, 75);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Пользователь";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginTextBox.Location = new System.Drawing.Point(15, 34);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginTextBox.MaxLength = 50;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(498, 31);
            this.LoginTextBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.PassTextBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(3, 316);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.groupBox5.Size = new System.Drawing.Size(528, 75);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Пароль";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PassTextBox.Location = new System.Drawing.Point(15, 34);
            this.PassTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassTextBox.MaxLength = 50;
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(498, 31);
            this.PassTextBox.TabIndex = 0;
            // 
            // CancleBut
            // 
            this.CancleBut.AutoSize = true;
            this.CancleBut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CancleBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CancleBut.Font = new System.Drawing.Font("Calibri", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancleBut.Location = new System.Drawing.Point(3, 473);
            this.CancleBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancleBut.Name = "CancleBut";
            this.CancleBut.Size = new System.Drawing.Size(528, 52);
            this.CancleBut.TabIndex = 8;
            this.CancleBut.Text = "Назад";
            this.CancleBut.UseVisualStyleBackColor = true;
            this.CancleBut.Click += new System.EventHandler(this.CancleBut_Click);
            // 
            // SaveConnBut
            // 
            this.SaveConnBut.AutoSize = true;
            this.SaveConnBut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveConnBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveConnBut.Font = new System.Drawing.Font("Calibri", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveConnBut.Location = new System.Drawing.Point(3, 421);
            this.SaveConnBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveConnBut.Name = "SaveConnBut";
            this.SaveConnBut.Size = new System.Drawing.Size(528, 52);
            this.SaveConnBut.TabIndex = 9;
            this.SaveConnBut.Text = "Сохранить";
            this.SaveConnBut.UseVisualStyleBackColor = true;
            this.SaveConnBut.Click += new System.EventHandler(this.SaveConnBut_Click);
            // 
            // ConnDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(534, 528);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.ConnDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LoginGrupBox.ResumeLayout(false);
            this.LoginGrupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.GroupBox LoginGrupBox;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Button SaveConnBut;
        private System.Windows.Forms.Button CancleBut;
    }
}