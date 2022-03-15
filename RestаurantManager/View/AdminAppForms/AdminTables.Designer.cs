namespace RestаurantManager.View.AdminAppForms
{
    partial class AdminTables
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
            this.addTableBox = new System.Windows.Forms.GroupBox();
            this.confirmEditButton = new System.Windows.Forms.Button();
            this.addTableButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableNameBox = new System.Windows.Forms.TextBox();
            this.editMealButton = new System.Windows.Forms.Button();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableList = new System.Windows.Forms.ListView();
            this.tableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealPanel.SuspendLayout();
            this.addTableBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mealPanel
            // 
            this.mealPanel.Controls.Add(this.addTableBox);
            this.mealPanel.Controls.Add(this.editMealButton);
            this.mealPanel.Controls.Add(this.removeTableButton);
            this.mealPanel.Controls.Add(this.label1);
            this.mealPanel.Controls.Add(this.tableList);
            this.mealPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mealPanel.Location = new System.Drawing.Point(0, 0);
            this.mealPanel.Name = "mealPanel";
            this.mealPanel.Size = new System.Drawing.Size(984, 626);
            this.mealPanel.TabIndex = 1;
            // 
            // addTableBox
            // 
            this.addTableBox.Controls.Add(this.confirmEditButton);
            this.addTableBox.Controls.Add(this.addTableButton);
            this.addTableBox.Controls.Add(this.label2);
            this.addTableBox.Controls.Add(this.tableNameBox);
            this.addTableBox.Location = new System.Drawing.Point(529, 177);
            this.addTableBox.Name = "addTableBox";
            this.addTableBox.Size = new System.Drawing.Size(339, 316);
            this.addTableBox.TabIndex = 9;
            this.addTableBox.TabStop = false;
            this.addTableBox.Text = "Add Table";
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
            // addTableButton
            // 
            this.addTableButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTableButton.Location = new System.Drawing.Point(6, 259);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(146, 50);
            this.addTableButton.TabIndex = 5;
            this.addTableButton.Text = "Add Table";
            this.addTableButton.UseVisualStyleBackColor = false;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table name";
            // 
            // tableNameBox
            // 
            this.tableNameBox.Location = new System.Drawing.Point(6, 68);
            this.tableNameBox.Name = "tableNameBox";
            this.tableNameBox.Size = new System.Drawing.Size(294, 22);
            this.tableNameBox.TabIndex = 0;
            // 
            // editMealButton
            // 
            this.editMealButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editMealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMealButton.Location = new System.Drawing.Point(275, 443);
            this.editMealButton.Name = "editMealButton";
            this.editMealButton.Size = new System.Drawing.Size(154, 50);
            this.editMealButton.TabIndex = 8;
            this.editMealButton.Text = "Edit Table";
            this.editMealButton.UseVisualStyleBackColor = false;
            // 
            // removeTableButton
            // 
            this.removeTableButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.removeTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTableButton.Location = new System.Drawing.Point(123, 443);
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.Size = new System.Drawing.Size(146, 50);
            this.removeTableButton.TabIndex = 7;
            this.removeTableButton.Text = "Remove Table";
            this.removeTableButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tables list";
            // 
            // tableList
            // 
            this.tableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableName});
            this.tableList.HideSelection = false;
            this.tableList.Location = new System.Drawing.Point(123, 184);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(306, 217);
            this.tableList.TabIndex = 5;
            this.tableList.UseCompatibleStateImageBehavior = false;
            this.tableList.View = System.Windows.Forms.View.Details;
            // 
            // tableName
            // 
            this.tableName.Text = "Table Name";
            this.tableName.Width = 295;
            // 
            // AdminTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 626);
            this.Controls.Add(this.mealPanel);
            this.Name = "AdminTables";
            this.Text = "AdminTables";
            this.mealPanel.ResumeLayout(false);
            this.mealPanel.PerformLayout();
            this.addTableBox.ResumeLayout(false);
            this.addTableBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mealPanel;
        private System.Windows.Forms.GroupBox addTableBox;
        private System.Windows.Forms.Button confirmEditButton;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tableNameBox;
        private System.Windows.Forms.Button editMealButton;
        private System.Windows.Forms.Button removeTableButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView tableList;
        private System.Windows.Forms.ColumnHeader tableName;
    }
}