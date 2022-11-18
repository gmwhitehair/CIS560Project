
namespace ProjectApplication
{
    partial class uxInsertUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxInsertUser));
            this.label1 = new System.Windows.Forms.Label();
            this.uxEmailText = new System.Windows.Forms.TextBox();
            this.uxInsertButton = new System.Windows.Forms.Button();
            this.uxInsertGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // uxEmailText
            // 
            this.uxEmailText.Location = new System.Drawing.Point(122, 265);
            this.uxEmailText.Name = "uxEmailText";
            this.uxEmailText.Size = new System.Drawing.Size(100, 20);
            this.uxEmailText.TabIndex = 1;
            // 
            // uxInsertButton
            // 
            this.uxInsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInsertButton.Location = new System.Drawing.Point(104, 368);
            this.uxInsertButton.Name = "uxInsertButton";
            this.uxInsertButton.Size = new System.Drawing.Size(72, 36);
            this.uxInsertButton.TabIndex = 2;
            this.uxInsertButton.Text = "Insert";
            this.uxInsertButton.UseVisualStyleBackColor = true;
            this.uxInsertButton.Click += new System.EventHandler(this.uxInsertButton_Click);
            // 
            // uxInsertGrid
            // 
            this.uxInsertGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uxInsertGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uxInsertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxInsertGrid.Location = new System.Drawing.Point(282, 27);
            this.uxInsertGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxInsertGrid.Name = "uxInsertGrid";
            this.uxInsertGrid.ReadOnly = true;
            this.uxInsertGrid.RowHeadersWidth = 62;
            this.uxInsertGrid.Size = new System.Drawing.Size(876, 504);
            this.uxInsertGrid.TabIndex = 14;
            // 
            // uxInsertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.uxInsertGrid);
            this.Controls.Add(this.uxInsertButton);
            this.Controls.Add(this.uxEmailText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uxInsertUser";
            this.Text = "Insert User";
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxEmailText;
        private System.Windows.Forms.Button uxInsertButton;
        private System.Windows.Forms.DataGridView uxInsertGrid;
    }
}