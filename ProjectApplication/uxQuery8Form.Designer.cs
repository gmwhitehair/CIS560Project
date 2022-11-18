namespace ProjectApplication
{
    partial class uxQuery8Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxQuery8Form));
            this.uxRunQueryButton = new System.Windows.Forms.Button();
            this.uxInsertGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxRunQueryButton
            // 
            this.uxRunQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRunQueryButton.ForeColor = System.Drawing.Color.Black;
            this.uxRunQueryButton.Location = new System.Drawing.Point(59, 368);
            this.uxRunQueryButton.Name = "uxRunQueryButton";
            this.uxRunQueryButton.Size = new System.Drawing.Size(115, 39);
            this.uxRunQueryButton.TabIndex = 18;
            this.uxRunQueryButton.Text = "Run Query";
            this.uxRunQueryButton.UseVisualStyleBackColor = true;
            this.uxRunQueryButton.Click += new System.EventHandler(this.uxRunQueryButton_Click);
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
            this.uxInsertGrid.Location = new System.Drawing.Point(298, 28);
            this.uxInsertGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxInsertGrid.Name = "uxInsertGrid";
            this.uxInsertGrid.ReadOnly = true;
            this.uxInsertGrid.RowHeadersWidth = 62;
            this.uxInsertGrid.Size = new System.Drawing.Size(827, 505);
            this.uxInsertGrid.TabIndex = 17;
            this.uxInsertGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxInsertGrid_CellContentClick);
            // 
            // uxQuery8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.uxRunQueryButton);
            this.Controls.Add(this.uxInsertGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uxQuery8Form";
            this.Text = "uxQuery8Form";
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxRunQueryButton;
        private System.Windows.Forms.DataGridView uxInsertGrid;
    }
}