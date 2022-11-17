
namespace ProjectApplication
{
    partial class uxInsertDeal
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
            this.label6 = new System.Windows.Forms.Label();
            this.uxNameText = new System.Windows.Forms.TextBox();
            this.uxDescriptionText = new System.Windows.Forms.TextBox();
            this.uxHappyHourText = new System.Windows.Forms.TextBox();
            this.uxDayOfWeekText = new System.Windows.Forms.TextBox();
            this.uxStartTimeText = new System.Windows.Forms.TextBox();
            this.uxEndTimeText = new System.Windows.Forms.TextBox();
            this.uxInsertButton = new System.Windows.Forms.Button();
            this.uxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bar Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Happy Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Day Of Week";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "End Time";
            // 
            // uxNameText
            // 
            this.uxNameText.Location = new System.Drawing.Point(100, 42);
            this.uxNameText.Name = "uxNameText";
            this.uxNameText.Size = new System.Drawing.Size(100, 20);
            this.uxNameText.TabIndex = 6;
            // 
            // uxDescriptionText
            // 
            this.uxDescriptionText.Location = new System.Drawing.Point(106, 94);
            this.uxDescriptionText.Name = "uxDescriptionText";
            this.uxDescriptionText.Size = new System.Drawing.Size(100, 20);
            this.uxDescriptionText.TabIndex = 7;
            // 
            // uxHappyHourText
            // 
            this.uxHappyHourText.Location = new System.Drawing.Point(110, 141);
            this.uxHappyHourText.Name = "uxHappyHourText";
            this.uxHappyHourText.Size = new System.Drawing.Size(100, 20);
            this.uxHappyHourText.TabIndex = 8;
            // 
            // uxDayOfWeekText
            // 
            this.uxDayOfWeekText.Location = new System.Drawing.Point(118, 194);
            this.uxDayOfWeekText.Name = "uxDayOfWeekText";
            this.uxDayOfWeekText.Size = new System.Drawing.Size(100, 20);
            this.uxDayOfWeekText.TabIndex = 9;
            // 
            // uxStartTimeText
            // 
            this.uxStartTimeText.Location = new System.Drawing.Point(101, 244);
            this.uxStartTimeText.Name = "uxStartTimeText";
            this.uxStartTimeText.Size = new System.Drawing.Size(100, 20);
            this.uxStartTimeText.TabIndex = 10;
            // 
            // uxEndTimeText
            // 
            this.uxEndTimeText.Location = new System.Drawing.Point(98, 296);
            this.uxEndTimeText.Name = "uxEndTimeText";
            this.uxEndTimeText.Size = new System.Drawing.Size(100, 20);
            this.uxEndTimeText.TabIndex = 11;
            // 
            // uxInsertButton
            // 
            this.uxInsertButton.Location = new System.Drawing.Point(81, 369);
            this.uxInsertButton.Name = "uxInsertButton";
            this.uxInsertButton.Size = new System.Drawing.Size(75, 23);
            this.uxInsertButton.TabIndex = 12;
            this.uxInsertButton.Text = "Insert";
            this.uxInsertButton.UseVisualStyleBackColor = true;
            this.uxInsertButton.Click += new System.EventHandler(this.uxInsert_Click);
            // 
            // uxDisplay
            // 
            this.uxDisplay.Enabled = false;
            this.uxDisplay.Location = new System.Drawing.Point(286, 12);
            this.uxDisplay.Multiline = true;
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxDisplay.Size = new System.Drawing.Size(335, 426);
            this.uxDisplay.TabIndex = 13;
            // 
            // uxInsertDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.uxDisplay);
            this.Controls.Add(this.uxInsertButton);
            this.Controls.Add(this.uxEndTimeText);
            this.Controls.Add(this.uxStartTimeText);
            this.Controls.Add(this.uxDayOfWeekText);
            this.Controls.Add(this.uxHappyHourText);
            this.Controls.Add(this.uxDescriptionText);
            this.Controls.Add(this.uxNameText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uxInsertDeal";
            this.Text = "Insert Deal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uxNameText;
        private System.Windows.Forms.TextBox uxDescriptionText;
        private System.Windows.Forms.TextBox uxHappyHourText;
        private System.Windows.Forms.TextBox uxDayOfWeekText;
        private System.Windows.Forms.TextBox uxStartTimeText;
        private System.Windows.Forms.TextBox uxEndTimeText;
        private System.Windows.Forms.Button uxInsertButton;
        private System.Windows.Forms.TextBox uxDisplay;
    }
}