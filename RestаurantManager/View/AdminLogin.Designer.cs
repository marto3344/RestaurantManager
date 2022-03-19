namespace RestаurantManager.View
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminNameBox = new System.Windows.Forms.TextBox();
            this.AdminPasswordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Admin name";
            // 
            // AdminNameBox
            // 
            this.AdminNameBox.Location = new System.Drawing.Point(352, 215);
            this.AdminNameBox.Name = "AdminNameBox";
            this.AdminNameBox.Size = new System.Drawing.Size(250, 22);
            this.AdminNameBox.TabIndex = 0;
            // 
            // AdminPasswordBox
            // 
            this.AdminPasswordBox.Location = new System.Drawing.Point(352, 268);
            this.AdminPasswordBox.Name = "AdminPasswordBox";
            this.AdminPasswordBox.Size = new System.Drawing.Size(250, 22);
            this.AdminPasswordBox.TabIndex = 1;
            this.AdminPasswordBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AdminLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminLoginButton.Location = new System.Drawing.Point(352, 306);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(250, 50);
            this.AdminLoginButton.TabIndex = 2;
            this.AdminLoginButton.Text = "Login";
            this.AdminLoginButton.UseVisualStyleBackColor = false;
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminNameBox);
            this.Controls.Add(this.AdminPasswordBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdminLoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Manager Pro";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminNameBox;
        private System.Windows.Forms.TextBox AdminPasswordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AdminLoginButton;
    }
}