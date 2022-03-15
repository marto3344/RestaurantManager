namespace RestаurantManager.View.AdminAppForms
{
    partial class AdminWaiters
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
            this.mealPanel = new System.Windows.Forms.Panel();
            this.addWaiterBox = new System.Windows.Forms.GroupBox();
            this.confirmEditButton = new System.Windows.Forms.Button();
            this.addWaiterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waiterPasswordBox = new System.Windows.Forms.TextBox();
            this.waiterNameBox = new System.Windows.Forms.TextBox();
            this.editWaiterButton = new System.Windows.Forms.Button();
            this.removeWaiterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.waitersList = new System.Windows.Forms.ListView();
            this.waiterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealPanel.SuspendLayout();
            this.addWaiterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mealPanel
            // 
            this.mealPanel.Controls.Add(this.addWaiterBox);
            this.mealPanel.Controls.Add(this.editWaiterButton);
            this.mealPanel.Controls.Add(this.removeWaiterButton);
            this.mealPanel.Controls.Add(this.label1);
            this.mealPanel.Controls.Add(this.waitersList);
            this.mealPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mealPanel.Location = new System.Drawing.Point(0, 0);
            this.mealPanel.Name = "mealPanel";
            this.mealPanel.Size = new System.Drawing.Size(984, 626);
            this.mealPanel.TabIndex = 1;
            // 
            // addWaiterBox
            // 
            this.addWaiterBox.Controls.Add(this.confirmEditButton);
            this.addWaiterBox.Controls.Add(this.addWaiterButton);
            this.addWaiterBox.Controls.Add(this.label3);
            this.addWaiterBox.Controls.Add(this.label2);
            this.addWaiterBox.Controls.Add(this.waiterPasswordBox);
            this.addWaiterBox.Controls.Add(this.waiterNameBox);
            this.addWaiterBox.Location = new System.Drawing.Point(529, 177);
            this.addWaiterBox.Name = "addWaiterBox";
            this.addWaiterBox.Size = new System.Drawing.Size(339, 316);
            this.addWaiterBox.TabIndex = 9;
            this.addWaiterBox.TabStop = false;
            this.addWaiterBox.Text = "Add waiter to the system";
            // 
            // confirmEditButton
            // 
            this.confirmEditButton.BackColor = System.Drawing.Color.LimeGreen;
            this.confirmEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmEditButton.Location = new System.Drawing.Point(6, 259);
            this.confirmEditButton.Name = "confirmEditButton";
            this.confirmEditButton.Size = new System.Drawing.Size(146, 50);
            this.confirmEditButton.TabIndex = 6;
            this.confirmEditButton.Text = "Confirm";
            this.confirmEditButton.UseVisualStyleBackColor = false;
            this.confirmEditButton.Visible = false;
            // 
            // addWaiterButton
            // 
            this.addWaiterButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addWaiterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWaiterButton.Location = new System.Drawing.Point(6, 259);
            this.addWaiterButton.Name = "addWaiterButton";
            this.addWaiterButton.Size = new System.Drawing.Size(146, 50);
            this.addWaiterButton.TabIndex = 5;
            this.addWaiterButton.Text = "Add Waiter";
            this.addWaiterButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Waiter name";
            // 
            // waiterPasswordBox
            // 
            this.waiterPasswordBox.Location = new System.Drawing.Point(6, 143);
            this.waiterPasswordBox.Name = "waiterPasswordBox";
            this.waiterPasswordBox.Size = new System.Drawing.Size(294, 22);
            this.waiterPasswordBox.TabIndex = 1;
            // 
            // waiterNameBox
            // 
            this.waiterNameBox.Location = new System.Drawing.Point(6, 68);
            this.waiterNameBox.Name = "waiterNameBox";
            this.waiterNameBox.Size = new System.Drawing.Size(294, 22);
            this.waiterNameBox.TabIndex = 0;
            // 
            // editWaiterButton
            // 
            this.editWaiterButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editWaiterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editWaiterButton.Location = new System.Drawing.Point(330, 443);
            this.editWaiterButton.Name = "editWaiterButton";
            this.editWaiterButton.Size = new System.Drawing.Size(154, 50);
            this.editWaiterButton.TabIndex = 8;
            this.editWaiterButton.Text = "Edit Waiter";
            this.editWaiterButton.UseVisualStyleBackColor = false;
            // 
            // removeWaiterButton
            // 
            this.removeWaiterButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.removeWaiterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeWaiterButton.Location = new System.Drawing.Point(123, 443);
            this.removeWaiterButton.Name = "removeWaiterButton";
            this.removeWaiterButton.Size = new System.Drawing.Size(146, 50);
            this.removeWaiterButton.TabIndex = 7;
            this.removeWaiterButton.Text = "Remove Waiter";
            this.removeWaiterButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Waiters list";
            // 
            // waitersList
            // 
            this.waitersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.waiterName,
            this.mealPrice});
            this.waitersList.HideSelection = false;
            this.waitersList.Location = new System.Drawing.Point(123, 184);
            this.waitersList.Name = "waitersList";
            this.waitersList.Size = new System.Drawing.Size(361, 217);
            this.waitersList.TabIndex = 5;
            this.waitersList.UseCompatibleStateImageBehavior = false;
            this.waitersList.View = System.Windows.Forms.View.Details;
            // 
            // waiterName
            // 
            this.waiterName.Text = "Waiter name";
            this.waiterName.Width = 192;
            // 
            // mealPrice
            // 
            this.mealPrice.Text = "Password";
            this.mealPrice.Width = 155;
            // 
            // AdminWaiters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 626);
            this.Controls.Add(this.mealPanel);
            this.Name = "AdminWaiters";
            this.Text = "AdminWaiters";
            this.mealPanel.ResumeLayout(false);
            this.mealPanel.PerformLayout();
            this.addWaiterBox.ResumeLayout(false);
            this.addWaiterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mealPanel;
        private System.Windows.Forms.GroupBox addWaiterBox;
        private System.Windows.Forms.Button confirmEditButton;
        private System.Windows.Forms.Button addWaiterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox waiterPasswordBox;
        private System.Windows.Forms.TextBox waiterNameBox;
        private System.Windows.Forms.Button editWaiterButton;
        private System.Windows.Forms.Button removeWaiterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView waitersList;
        private System.Windows.Forms.ColumnHeader waiterName;
        private System.Windows.Forms.ColumnHeader mealPrice;
    }
}