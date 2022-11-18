
namespace ProjectApplication
{
    partial class uxInsertCollegeTown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxInsertCollegeTown));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxInsert = new System.Windows.Forms.Button();
            this.uxUniversityText = new System.Windows.Forms.TextBox();
            this.uxCityText = new System.Windows.Forms.TextBox();
            this.uxStateText = new System.Windows.Forms.TextBox();
            this.uxInsertGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "University:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "State:";
            // 
            // uxInsert
            // 
            this.uxInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInsert.Location = new System.Drawing.Point(89, 347);
            this.uxInsert.Name = "uxInsert";
            this.uxInsert.Size = new System.Drawing.Size(83, 42);
            this.uxInsert.TabIndex = 3;
            this.uxInsert.Text = "Insert";
            this.uxInsert.UseVisualStyleBackColor = true;
            this.uxInsert.Click += new System.EventHandler(this.uxInsert_Click);
            // 
            // uxUniversityText
            // 
            this.uxUniversityText.Location = new System.Drawing.Point(153, 154);
            this.uxUniversityText.Name = "uxUniversityText";
            this.uxUniversityText.Size = new System.Drawing.Size(100, 20);
            this.uxUniversityText.TabIndex = 4;
            // 
            // uxCityText
            // 
            this.uxCityText.Location = new System.Drawing.Point(153, 210);
            this.uxCityText.Name = "uxCityText";
            this.uxCityText.Size = new System.Drawing.Size(100, 20);
            this.uxCityText.TabIndex = 5;
            // 
            // uxStateText
            // 
            this.uxStateText.Location = new System.Drawing.Point(153, 266);
            this.uxStateText.Name = "uxStateText";
            this.uxStateText.Size = new System.Drawing.Size(100, 20);
            this.uxStateText.TabIndex = 6;
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
            this.uxInsertGrid.Location = new System.Drawing.Point(292, 14);
            this.uxInsertGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxInsertGrid.Name = "uxInsertGrid";
            this.uxInsertGrid.ReadOnly = true;
            this.uxInsertGrid.RowHeadersWidth = 62;
            this.uxInsertGrid.Size = new System.Drawing.Size(869, 522);
            this.uxInsertGrid.TabIndex = 14;
            // 
            // uxInsertCollegeTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.uxInsertGrid);
            this.Controls.Add(this.uxStateText);
            this.Controls.Add(this.uxCityText);
            this.Controls.Add(this.uxUniversityText);
            this.Controls.Add(this.uxInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uxInsertCollegeTown";
            this.Text = "Insert College Town";
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxInsert;
        private System.Windows.Forms.TextBox uxUniversityText;
        private System.Windows.Forms.TextBox uxCityText;
        private System.Windows.Forms.TextBox uxStateText;
        private System.Windows.Forms.DataGridView uxInsertGrid;
    }
}