namespace Ipoteka
{
    partial class LoginForm
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
            this.panel_bg = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.pictureBox_Pass = new System.Windows.Forms.PictureBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.pictureBox_Login = new System.Windows.Forms.PictureBox();
            this.panel_auth = new System.Windows.Forms.Panel();
            this.CloseForm = new System.Windows.Forms.Label();
            this.label_auth_name = new System.Windows.Forms.Label();
            this.panel_bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).BeginInit();
            this.panel_auth.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bg
            // 
            this.panel_bg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_bg.Controls.Add(this.button_Login);
            this.panel_bg.Controls.Add(this.textBox_Pass);
            this.panel_bg.Controls.Add(this.pictureBox_Pass);
            this.panel_bg.Controls.Add(this.textBox_Login);
            this.panel_bg.Controls.Add(this.pictureBox_Login);
            this.panel_bg.Controls.Add(this.panel_auth);
            this.panel_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bg.Location = new System.Drawing.Point(0, 0);
            this.panel_bg.Name = "panel_bg";
            this.panel_bg.Size = new System.Drawing.Size(495, 208);
            this.panel_bg.TabIndex = 1;
            this.panel_bg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_bg_MouseDown);
            this.panel_bg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_bg_MouseMove);
            // 
            // button_Login
            // 
            this.button_Login.Enabled = false;
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Login.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_Login.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Login.Location = new System.Drawing.Point(181, 155);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(152, 41);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "Авторизуватись";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Pass.Location = new System.Drawing.Point(172, 114);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(182, 35);
            this.textBox_Pass.TabIndex = 4;
            this.textBox_Pass.UseSystemPasswordChar = true;
            this.textBox_Pass.TextChanged += new System.EventHandler(this.textBox_Pass_TextChanged);
            this.textBox_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Pass_KeyDown);
            // 
            // pictureBox_Pass
            // 
            this.pictureBox_Pass.Image = global::Ipoteka.Properties.Resources.pass_avatar;
            this.pictureBox_Pass.Location = new System.Drawing.Point(129, 114);
            this.pictureBox_Pass.Name = "pictureBox_Pass";
            this.pictureBox_Pass.Size = new System.Drawing.Size(37, 35);
            this.pictureBox_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Pass.TabIndex = 3;
            this.pictureBox_Pass.TabStop = false;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(172, 73);
            this.textBox_Login.MaxLength = 255;
            this.textBox_Login.Multiline = true;
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(182, 35);
            this.textBox_Login.TabIndex = 2;
            this.textBox_Login.Tag = "";
            // 
            // pictureBox_Login
            // 
            this.pictureBox_Login.Image = global::Ipoteka.Properties.Resources.login_avatar;
            this.pictureBox_Login.Location = new System.Drawing.Point(129, 73);
            this.pictureBox_Login.Name = "pictureBox_Login";
            this.pictureBox_Login.Size = new System.Drawing.Size(37, 35);
            this.pictureBox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Login.TabIndex = 1;
            this.pictureBox_Login.TabStop = false;
            // 
            // panel_auth
            // 
            this.panel_auth.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel_auth.Controls.Add(this.CloseForm);
            this.panel_auth.Controls.Add(this.label_auth_name);
            this.panel_auth.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_auth.Location = new System.Drawing.Point(0, 0);
            this.panel_auth.Name = "panel_auth";
            this.panel_auth.Size = new System.Drawing.Size(495, 56);
            this.panel_auth.TabIndex = 0;
            // 
            // CloseForm
            // 
            this.CloseForm.AutoSize = true;
            this.CloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseForm.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CloseForm.Location = new System.Drawing.Point(434, 9);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(49, 13);
            this.CloseForm.TabIndex = 1;
            this.CloseForm.Text = "Закрити";
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            this.CloseForm.MouseEnter += new System.EventHandler(this.CloseForm_MouseEnter);
            this.CloseForm.MouseLeave += new System.EventHandler(this.CloseForm_MouseLeave);
            // 
            // label_auth_name
            // 
            this.label_auth_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_auth_name.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_auth_name.ForeColor = System.Drawing.Color.DimGray;
            this.label_auth_name.Location = new System.Drawing.Point(0, 0);
            this.label_auth_name.Name = "label_auth_name";
            this.label_auth_name.Size = new System.Drawing.Size(495, 56);
            this.label_auth_name.TabIndex = 0;
            this.label_auth_name.Text = "Авторизація";
            this.label_auth_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_auth_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_auth_name_MouseDown);
            this.label_auth_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_auth_name_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 208);
            this.Controls.Add(this.panel_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "AuthorisationForm";
            this.panel_bg.ResumeLayout(false);
            this.panel_bg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).EndInit();
            this.panel_auth.ResumeLayout(false);
            this.panel_auth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_auth;
        private System.Windows.Forms.Label label_auth_name;
        private System.Windows.Forms.PictureBox pictureBox_Login;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.PictureBox pictureBox_Pass;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label CloseForm;
        private System.Windows.Forms.Panel panel_bg;
    }
}

