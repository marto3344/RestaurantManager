namespace RestаurantManager.View.AdminAppForms
{
    partial class MealsForm
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
            this.addMealBox = new System.Windows.Forms.GroupBox();
            this.confirmEditButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mealPriceBox = new System.Windows.Forms.TextBox();
            this.mealNameBox = new System.Windows.Forms.TextBox();
            this.editMealButton = new System.Windows.Forms.Button();
            this.removeMealButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mealName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealPanel.SuspendLayout();
            this.addMealBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mealPanel
            // 
            this.mealPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mealPanel.Controls.Add(this.addMealBox);
            this.mealPanel.Controls.Add(this.editMealButton);
            this.mealPanel.Controls.Add(this.removeMealButton);
            this.mealPanel.Controls.Add(this.label1);
            this.mealPanel.Controls.Add(this.listView1);
            this.mealPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mealPanel.Location = new System.Drawing.Point(0, 0);
            this.mealPanel.Name = "mealPanel";
            this.mealPanel.Size = new System.Drawing.Size(984, 626);
            this.mealPanel.TabIndex = 0;
            this.mealPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mealPanel_Paint);
            // 
            // addMealBox
            // 
            this.addMealBox.Controls.Add(this.confirmEditButton);
            this.addMealBox.Controls.Add(this.button2);
            this.addMealBox.Controls.Add(this.label3);
            this.addMealBox.Controls.Add(this.label2);
            this.addMealBox.Controls.Add(this.mealPriceBox);
            this.addMealBox.Controls.Add(this.mealNameBox);
            this.addMealBox.Location = new System.Drawing.Point(529, 177);
            this.addMealBox.Name = "addMealBox";
            this.addMealBox.Size = new System.Drawing.Size(339, 316);
            this.addMealBox.TabIndex = 9;
            this.addMealBox.TabStop = false;
            this.addMealBox.Text = "Add meal ";
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
            this.confirmEditButton.Click += new System.EventHandler(this.confirmEditButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add Meal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meal name";
            // 
            // mealPriceBox
            // 
            this.mealPriceBox.Location = new System.Drawing.Point(6, 143);
            this.mealPriceBox.Name = "mealPriceBox";
            this.mealPriceBox.Size = new System.Drawing.Size(294, 22);
            this.mealPriceBox.TabIndex = 1;
            // 
            // mealNameBox
            // 
            this.mealNameBox.Location = new System.Drawing.Point(6, 68);
            this.mealNameBox.Name = "mealNameBox";
            this.mealNameBox.Size = new System.Drawing.Size(294, 22);
            this.mealNameBox.TabIndex = 0;
            // 
            // editMealButton
            // 
            this.editMealButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editMealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMealButton.Location = new System.Drawing.Point(275, 443);
            this.editMealButton.Name = "editMealButton";
            this.editMealButton.Size = new System.Drawing.Size(154, 50);
            this.editMealButton.TabIndex = 8;
            this.editMealButton.Text = "Edit Meal";
            this.editMealButton.UseVisualStyleBackColor = false;
            this.editMealButton.Click += new System.EventHandler(this.editMealButton_Click);
            // 
            // removeMealButton
            // 
            this.removeMealButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.removeMealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMealButton.Location = new System.Drawing.Point(123, 443);
            this.removeMealButton.Name = "removeMealButton";
            this.removeMealButton.Size = new System.Drawing.Size(146, 50);
            this.removeMealButton.TabIndex = 7;
            this.removeMealButton.Text = "Remove Meal";
            this.removeMealButton.UseVisualStyleBackColor = false;
            this.removeMealButton.Click += new System.EventHandler(this.removeMealButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mealName,
            this.mealPrice});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(123, 184);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(306, 217);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // mealName
            // 
            this.mealName.Text = "Meal Name";
            this.mealName.Width = 192;
            // 
            // mealPrice
            // 
            this.mealPrice.Text = "Price";
            // 
            // MealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 626);
            this.Controls.Add(this.mealPanel);
            this.Name = "MealsForm";
            this.Text = "MealsForm";
            this.Load += new System.EventHandler(this.MealsForm_Load);
            this.mealPanel.ResumeLayout(false);
            this.mealPanel.PerformLayout();
            this.addMealBox.ResumeLayout(false);
            this.addMealBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mealPanel;
        private System.Windows.Forms.GroupBox addMealBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mealPriceBox;
        private System.Windows.Forms.TextBox mealNameBox;
        private System.Windows.Forms.Button editMealButton;
        private System.Windows.Forms.Button removeMealButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader mealName;
        private System.Windows.Forms.ColumnHeader mealPrice;
        private System.Windows.Forms.Button confirmEditButton;
    }
}