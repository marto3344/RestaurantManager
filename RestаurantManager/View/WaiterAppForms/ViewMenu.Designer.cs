namespace RestаurantManager.View.WaiterAppForms
{
    partial class ViewMenu
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
            this.MenuBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // MenuBox
            // 
            this.MenuBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuBox.Location = new System.Drawing.Point(0, 0);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(800, 450);
            this.MenuBox.TabIndex = 0;
            this.MenuBox.TabStop = false;
            this.MenuBox.Text = "Menu";
            // 
            // ViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuBox);
            this.Name = "ViewMenu";
            this.Text = "ViewMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MenuBox;
    }
}