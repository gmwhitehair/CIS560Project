
namespace ProjectApplication
{
    partial class uxInsertVotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxInsertVotes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxEmailText = new System.Windows.Forms.TextBox();
            this.uxBarText = new System.Windows.Forms.TextBox();
            this.uxDealText = new System.Windows.Forms.TextBox();
            this.uxDayText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uxInsertGrid = new System.Windows.Forms.DataGridView();
            this.uxInsertVotesUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertVotesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 73);
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
            this.label2.Location = new System.Drawing.Point(41, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deal:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Day:";
            // 
            // uxEmailText
            // 
            this.uxEmailText.Location = new System.Drawing.Point(132, 78);
            this.uxEmailText.Name = "uxEmailText";
            this.uxEmailText.Size = new System.Drawing.Size(100, 20);
            this.uxEmailText.TabIndex = 5;
            // 
            // uxBarText
            // 
            this.uxBarText.Location = new System.Drawing.Point(132, 190);
            this.uxBarText.Name = "uxBarText";
            this.uxBarText.Size = new System.Drawing.Size(100, 20);
            this.uxBarText.TabIndex = 7;
            // 
            // uxDealText
            // 
            this.uxDealText.Location = new System.Drawing.Point(132, 250);
            this.uxDealText.Name = "uxDealText";
            this.uxDealText.Size = new System.Drawing.Size(100, 20);
            this.uxDealText.TabIndex = 8;
            // 
            // uxDayText
            // 
            this.uxDayText.Location = new System.Drawing.Point(132, 313);
            this.uxDayText.Name = "uxDayText";
            this.uxDayText.Size = new System.Drawing.Size(100, 20);
            this.uxDayText.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(92, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.uxInsertGrid.Location = new System.Drawing.Point(337, 20);
            this.uxInsertGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxInsertGrid.Name = "uxInsertGrid";
            this.uxInsertGrid.ReadOnly = true;
            this.uxInsertGrid.RowHeadersWidth = 62;
            this.uxInsertGrid.Size = new System.Drawing.Size(825, 499);
            this.uxInsertGrid.TabIndex = 14;
            // 
            // uxInsertVotesUpDown
            // 
            this.uxInsertVotesUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.uxInsertVotesUpDown.Location = new System.Drawing.Point(132, 134);
            this.uxInsertVotesUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxInsertVotesUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxInsertVotesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.uxInsertVotesUpDown.Name = "uxInsertVotesUpDown";
            this.uxInsertVotesUpDown.Size = new System.Drawing.Size(99, 20);
            this.uxInsertVotesUpDown.TabIndex = 15;
            this.uxInsertVotesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxInsertVotesUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 447);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 72);
            this.label6.TabIndex = 16;
            this.label6.Text = "Votes cannot be updated here\r\nUnique email for bar, deal, and day\r\nUse double app" +
    "ostrophe for single apostrophe\r\n1 is an upvote, -1 is a downvote";
            // 
            // uxInsertVotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1185, 549);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxInsertVotesUpDown);
            this.Controls.Add(this.uxInsertGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxDayText);
            this.Controls.Add(this.uxDealText);
            this.Controls.Add(this.uxBarText);
            this.Controls.Add(this.uxEmailText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uxInsertVotes";
            this.Text = "Insert Vote";
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxInsertVotesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxEmailText;
        private System.Windows.Forms.TextBox uxBarText;
        private System.Windows.Forms.TextBox uxDealText;
        private System.Windows.Forms.TextBox uxDayText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView uxInsertGrid;
        private System.Windows.Forms.NumericUpDown uxInsertVotesUpDown;
        private System.Windows.Forms.Label label6;
    }
}