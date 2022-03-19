namespace RestаurantManager.View
{
    partial class AdminApp
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
            this.SideNavPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SwitchAccountButton = new System.Windows.Forms.Button();
            this.ViewWaitersButton = new System.Windows.Forms.Button();
            this.MealsButton = new System.Windows.Forms.Button();
            this.TablesButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.SideNavPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideNavPanel
            // 
            this.SideNavPanel.BackColor = System.Drawing.Color.Navy;
            this.SideNavPanel.Controls.Add(this.ExitButton);
            this.SideNavPanel.Controls.Add(this.SwitchAccountButton);
            this.SideNavPanel.Controls.Add(this.ViewWaitersButton);
            this.SideNavPanel.Controls.Add(this.MealsButton);
            this.SideNavPanel.Controls.Add(this.TablesButton);
            this.SideNavPanel.Controls.Add(this.LogoPanel);
            this.SideNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.SideNavPanel.Name = "SideNavPanel";
            this.SideNavPanel.Size = new System.Drawing.Size(250, 673);
            this.SideNavPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(0, 561);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(250, 56);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.Enter += new System.EventHandler(this.ExitButton_Enter);
            this.ExitButton.Leave += new System.EventHandler(this.ExitButton_Leave);
            // 
            // SwitchAccountButton
            // 
            this.SwitchAccountButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SwitchAccountButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SwitchAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchAccountButton.Location = new System.Drawing.Point(0, 617);
            this.SwitchAccountButton.Name = "SwitchAccountButton";
            this.SwitchAccountButton.Size = new System.Drawing.Size(250, 56);
            this.SwitchAccountButton.TabIndex = 4;
            this.SwitchAccountButton.Text = "Switch account";
            this.SwitchAccountButton.UseVisualStyleBackColor = false;
            this.SwitchAccountButton.Click += new System.EventHandler(this.SwitchAccountButton_Click);
            this.SwitchAccountButton.Enter += new System.EventHandler(this.SwitchAccountButton_Enter);
            this.SwitchAccountButton.Leave += new System.EventHandler(this.SwitchAccountButton_Leave);
            // 
            // ViewWaitersButton
            // 
            this.ViewWaitersButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ViewWaitersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewWaitersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewWaitersButton.Location = new System.Drawing.Point(0, 258);
            this.ViewWaitersButton.Name = "ViewWaitersButton";
            this.ViewWaitersButton.Size = new System.Drawing.Size(250, 56);
            this.ViewWaitersButton.TabIndex = 3;
            this.ViewWaitersButton.Text = "View Waiters";
            this.ViewWaitersButton.UseVisualStyleBackColor = false;
            this.ViewWaitersButton.Click += new System.EventHandler(this.ViewWaitersButton_Click);
            this.ViewWaitersButton.Enter += new System.EventHandler(this.ViewWaitersButton_Enter);
            this.ViewWaitersButton.Leave += new System.EventHandler(this.ViewWaitersButton_Leave);
            // 
            // MealsButton
            // 
            this.MealsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MealsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MealsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MealsButton.Location = new System.Drawing.Point(0, 202);
            this.MealsButton.Name = "MealsButton";
            this.MealsButton.Size = new System.Drawing.Size(250, 56);
            this.MealsButton.TabIndex = 2;
            this.MealsButton.Text = "Meals";
            this.MealsButton.UseVisualStyleBackColor = false;
            this.MealsButton.Click += new System.EventHandler(this.button1_Click);
            this.MealsButton.Enter += new System.EventHandler(this.MealsButton_Enter);
            this.MealsButton.Leave += new System.EventHandler(this.MealsButton_Leave);
            this.MealsButton.MouseHover += new System.EventHandler(this.MealsButton_MouseHover);
            // 
            // TablesButton
            // 
            this.TablesButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TablesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TablesButton.Location = new System.Drawing.Point(0, 146);
            this.TablesButton.Name = "TablesButton";
            this.TablesButton.Size = new System.Drawing.Size(250, 56);
            this.TablesButton.TabIndex = 1;
            this.TablesButton.Text = "Tables";
            this.TablesButton.UseVisualStyleBackColor = false;
            this.TablesButton.Click += new System.EventHandler(this.TablesButton_Click);
            this.TablesButton.Enter += new System.EventHandler(this.TablesButton_Enter);
            this.TablesButton.Leave += new System.EventHandler(this.TablesButton_Leave);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Lavender;
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(250, 146);
            this.LogoPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Manager Pro";
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(250, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1002, 673);
            this.contentPanel.TabIndex = 1;
            // 
            // AdminApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 673);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.SideNavPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Manager Pro";
            this.Load += new System.EventHandler(this.AdminApp_Load);
            this.SideNavPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideNavPanel;
        private System.Windows.Forms.Button MealsButton;
        private System.Windows.Forms.Button TablesButton;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SwitchAccountButton;
        private System.Windows.Forms.Button ViewWaitersButton;
        private System.Windows.Forms.Panel contentPanel;
    }
}