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
            this.tablesLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tablesLayoutPanel
            // 
            this.tablesLayoutPanel.ColumnCount = 2;
            this.tablesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5F));
            this.tablesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.5F));
            this.tablesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tablesLayoutPanel.Name = "tablesLayoutPanel";
            this.tablesLayoutPanel.RowCount = 2;
            this.tablesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablesLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tablesLayoutPanel.TabIndex = 0;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablesLayoutPanel);
            this.Name = "TablesForm";
            this.Text = "TablesForm";
            this.Load += new System.EventHandler(this.TablesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablesLayoutPanel;
    }
}