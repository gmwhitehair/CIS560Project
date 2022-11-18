
namespace ProjectApplication
{
    partial class uxInsertComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxInsertComment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxInsertButton = new System.Windows.Forms.Button();
            this.uxEmailText = new System.Windows.Forms.TextBox();
            this.uxText = new System.Windows.Forms.TextBox();
            this.uxTimeText = new System.Windows.Forms.TextBox();
            this.uxInsertGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Sent:";
            // 
            // uxInsertButton
            // 
            this.uxInsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInsertButton.Location = new System.Drawing.Point(104, 396);
            this.uxInsertButton.Name = "uxInsertButton";
            this.uxInsertButton.Size = new System.Drawing.Size(84, 32);
            this.uxInsertButton.TabIndex = 3;
            this.uxInsertButton.Text = "Insert";
            this.uxInsertButton.UseVisualStyleBackColor = true;
            this.uxInsertButton.Click += new System.EventHandler(this.uxInsertButton_Click);
            // 
            // uxEmailText
            // 
            this.uxEmailText.Location = new System.Drawing.Point(150, 171);
            this.uxEmailText.Name = "uxEmailText";
            this.uxEmailText.Size = new System.Drawing.Size(100, 20);
            this.uxEmailText.TabIndex = 4;
            // 
            // uxText
            // 
            this.uxText.Location = new System.Drawing.Point(150, 232);
            this.uxText.Name = "uxText";
            this.uxText.Size = new System.Drawing.Size(100, 20);
            this.uxText.TabIndex = 5;
            // 
            // uxTimeText
            // 
            this.uxTimeText.Location = new System.Drawing.Point(150, 301);
            this.uxTimeText.Name = "uxTimeText";
            this.uxTimeText.Size = new System.Drawing.Size(100, 20);
            this.uxTimeText.TabIndex = 6;
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
            this.uxInsertGrid.Location = new System.Drawing.Point(298, 14);
            this.uxInsertGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxInsertGrid.Name = "uxInsertGrid";
            this.uxInsertGrid.ReadOnly = true;
            this.uxInsertGrid.RowHeadersWidth = 62;
            this.uxInsertGrid.Size = new System.Drawing.Size(873, 527);
            this.uxInsertGrid.TabIndex = 14;
            // 
            // uxInsertComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.uxInsertGrid);
            this.Controls.Add(this.uxTimeText);
            this.Controls.Add(this.uxText);
            this.Controls.Add(this.uxEmailText);
            this.Controls.Add(this.uxInsertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uxInsertComment";
            this.Text = "Insert Comment";
            this.Load += new System.EventHandler(this.uxInsertComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxInsertButton;
        private System.Windows.Forms.TextBox uxEmailText;
        private System.Windows.Forms.TextBox uxText;
        private System.Windows.Forms.TextBox uxTimeText;
        private System.Windows.Forms.DataGridView uxInsertGrid;
    }
}