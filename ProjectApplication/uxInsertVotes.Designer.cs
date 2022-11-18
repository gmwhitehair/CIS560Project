
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxEmailText = new System.Windows.Forms.TextBox();
            this.uxVoteText = new System.Windows.Forms.TextBox();
            this.uxBarText = new System.Windows.Forms.TextBox();
            this.uxDealText = new System.Windows.Forms.TextBox();
            this.uxDayText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Day";
            // 
            // uxEmailText
            // 
            this.uxEmailText.Location = new System.Drawing.Point(66, 31);
            this.uxEmailText.Name = "uxEmailText";
            this.uxEmailText.Size = new System.Drawing.Size(100, 20);
            this.uxEmailText.TabIndex = 5;
            // 
            // uxVoteText
            // 
            this.uxVoteText.Location = new System.Drawing.Point(66, 69);
            this.uxVoteText.Name = "uxVoteText";
            this.uxVoteText.Size = new System.Drawing.Size(100, 20);
            this.uxVoteText.TabIndex = 6;
            // 
            // uxBarText
            // 
            this.uxBarText.Location = new System.Drawing.Point(66, 108);
            this.uxBarText.Name = "uxBarText";
            this.uxBarText.Size = new System.Drawing.Size(100, 20);
            this.uxBarText.TabIndex = 7;
            // 
            // uxDealText
            // 
            this.uxDealText.Location = new System.Drawing.Point(66, 151);
            this.uxDealText.Name = "uxDealText";
            this.uxDealText.Size = new System.Drawing.Size(100, 20);
            this.uxDealText.TabIndex = 8;
            // 
            // uxDayText
            // 
            this.uxDayText.Location = new System.Drawing.Point(66, 195);
            this.uxDayText.Name = "uxDayText";
            this.uxDayText.Size = new System.Drawing.Size(100, 20);
            this.uxDayText.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxInsertVotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxDayText);
            this.Controls.Add(this.uxDealText);
            this.Controls.Add(this.uxBarText);
            this.Controls.Add(this.uxVoteText);
            this.Controls.Add(this.uxEmailText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uxInsertVotes";
            this.Text = "Insert Vote";
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
        private System.Windows.Forms.TextBox uxVoteText;
        private System.Windows.Forms.TextBox uxBarText;
        private System.Windows.Forms.TextBox uxDealText;
        private System.Windows.Forms.TextBox uxDayText;
        private System.Windows.Forms.Button button1;
    }
}