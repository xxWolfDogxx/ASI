
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
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 359);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аутентификации";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ImageIdent;
    }
}