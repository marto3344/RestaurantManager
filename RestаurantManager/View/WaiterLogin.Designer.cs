namespace RestаurantManager.View
{
    partial class WaiterLogin
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
            this.WaiterLoginButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.WaiterNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WaiterLoginButton
            // 
            this.WaiterLoginButton.Location = new System.Drawing.Point(362, 320);
            this.WaiterLoginButton.Name = "WaiterLoginButton";
            this.WaiterLoginButton.Size = new System.Drawing.Size(250, 50);
            this.WaiterLoginButton.TabIndex = 2;
            this.WaiterLoginButton.Text = "Login";
            this.WaiterLoginButton.UseVisualStyleBackColor = true;
            this.WaiterLoginButton.Click += new System.EventHandler(this.WaiterLoginButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(362, 282);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(250, 22);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // WaiterNameBox
            // 
            this.WaiterNameBox.Location = new System.Drawing.Point(362, 229);
            this.WaiterNameBox.Name = "WaiterNameBox";
            this.WaiterNameBox.Size = new System.Drawing.Size(250, 22);
            this.WaiterNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Waiter name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // WaiterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WaiterNameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WaiterLoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "WaiterLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Manage Pro";
            this.Activated += new System.EventHandler(this.WaiterLogin_Activated);
            this.Load += new System.EventHandler(this.WaiterLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WaiterLoginButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox WaiterNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}