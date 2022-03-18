namespace RestаurantManager.View.WaiterAppForms
{
    partial class TablesForm
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mealBox = new System.Windows.Forms.ComboBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.tableBox = new System.Windows.Forms.ComboBox();
            this.completeOrder = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.billBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addMeal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.undoButton = new System.Windows.Forms.Button();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.undoButton);
            this.contentPanel.Controls.Add(this.label3);
            this.contentPanel.Controls.Add(this.mealBox);
            this.contentPanel.Controls.Add(this.quantityBox);
            this.contentPanel.Controls.Add(this.tableBox);
            this.contentPanel.Controls.Add(this.completeOrder);
            this.contentPanel.Controls.Add(this.totalCostLabel);
            this.contentPanel.Controls.Add(this.billBox);
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Controls.Add(this.addMeal);
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 450);
            this.contentPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Insert quantity";
            // 
            // mealBox
            // 
            this.mealBox.FormattingEnabled = true;
            this.mealBox.Location = new System.Drawing.Point(36, 163);
            this.mealBox.Name = "mealBox";
            this.mealBox.Size = new System.Drawing.Size(180, 24);
            this.mealBox.TabIndex = 11;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(36, 249);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(180, 22);
            this.quantityBox.TabIndex = 10;
            // 
            // tableBox
            // 
            this.tableBox.FormattingEnabled = true;
            this.tableBox.Location = new System.Drawing.Point(36, 79);
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(180, 24);
            this.tableBox.TabIndex = 9;
            this.tableBox.SelectedIndexChanged += new System.EventHandler(this.tableBox_SelectedIndexChanged);
            // 
            // completeOrder
            // 
            this.completeOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.completeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeOrder.Location = new System.Drawing.Point(394, 389);
            this.completeOrder.Name = "completeOrder";
            this.completeOrder.Size = new System.Drawing.Size(364, 42);
            this.completeOrder.TabIndex = 8;
            this.completeOrder.Text = "Recieve Bill";
            this.completeOrder.UseVisualStyleBackColor = false;
            this.completeOrder.Click += new System.EventHandler(this.completeOrder_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.totalCostLabel.Location = new System.Drawing.Point(388, 344);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(370, 42);
            this.totalCostLabel.TabIndex = 7;
            this.totalCostLabel.Text = "Total: 0 lv.";
            // 
            // billBox
            // 
            this.billBox.Enabled = false;
            this.billBox.Location = new System.Drawing.Point(394, 60);
            this.billBox.Multiline = true;
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(364, 267);
            this.billBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select meal";
            // 
            // addMeal
            // 
            this.addMeal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMeal.Location = new System.Drawing.Point(36, 304);
            this.addMeal.Name = "addMeal";
            this.addMeal.Size = new System.Drawing.Size(180, 42);
            this.addMeal.TabIndex = 3;
            this.addMeal.Text = "Add";
            this.addMeal.UseVisualStyleBackColor = false;
            this.addMeal.Click += new System.EventHandler(this.addMeal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select table";
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.Location = new System.Drawing.Point(36, 389);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(180, 42);
            this.undoButton.TabIndex = 13;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentPanel);
            this.Name = "TablesForm";
            this.Text = "TablesForm";
            this.Load += new System.EventHandler(this.TablesForm_Load);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox billBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addMeal;
        private System.Windows.Forms.Button completeOrder;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.ComboBox tableBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mealBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Button undoButton;
    }
}