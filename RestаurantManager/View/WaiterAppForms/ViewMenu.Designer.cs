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
            this.menuList = new System.Windows.Forms.ListView();
            this.mealName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBox
            // 
            this.MenuBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MenuBox.Controls.Add(this.menuList);
            this.MenuBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuBox.Location = new System.Drawing.Point(0, 0);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(804, 597);
            this.MenuBox.TabIndex = 0;
            this.MenuBox.TabStop = false;
            this.MenuBox.Text = "Menu";
            // 
            // menuList
            // 
            this.menuList.BackColor = System.Drawing.Color.LightCyan;
            this.menuList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mealName,
            this.mealPrice});
            this.menuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuList.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuList.HideSelection = false;
            this.menuList.Location = new System.Drawing.Point(3, 39);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(798, 555);
            this.menuList.TabIndex = 6;
            this.menuList.UseCompatibleStateImageBehavior = false;
            this.menuList.View = System.Windows.Forms.View.Details;
            // 
            // mealName
            // 
            this.mealName.Text = "Meal Name";
            this.mealName.Width = 467;
            // 
            // mealPrice
            // 
            this.mealPrice.Text = "Price";
            this.mealPrice.Width = 310;
            // 
            // ViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 597);
            this.Controls.Add(this.MenuBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Manager Pro";
            this.Load += new System.EventHandler(this.ViewMenu_Load);
            this.MenuBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MenuBox;
        private System.Windows.Forms.ListView menuList;
        private System.Windows.Forms.ColumnHeader mealName;
        private System.Windows.Forms.ColumnHeader mealPrice;
    }
}