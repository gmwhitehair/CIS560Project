
namespace ProjectApplication
{
    partial class uxInsertBar
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
            this.uxAddressText = new System.Windows.Forms.TextBox();
            this.uxCityText = new System.Windows.Forms.TextBox();
            this.uxStateText = new System.Windows.Forms.TextBox();
            this.uxUniversityText = new System.Windows.Forms.TextBox();
            this.uxRatingText = new System.Windows.Forms.TextBox();
            this.uxInsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bar Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "University";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rating";
            // 
            // uxNameText
            // 
            this.uxNameText.Location = new System.Drawing.Point(97, 31);
            this.uxNameText.Name = "uxNameText";
            this.uxNameText.Size = new System.Drawing.Size(141, 20);
            this.uxNameText.TabIndex = 6;
            // 
            // uxAddressText
            // 
            this.uxAddressText.Location = new System.Drawing.Point(97, 71);
            this.uxAddressText.Name = "uxAddressText";
            this.uxAddressText.Size = new System.Drawing.Size(141, 20);
            this.uxAddressText.TabIndex = 7;
            // 
            // uxCityText
            // 
            this.uxCityText.Location = new System.Drawing.Point(97, 120);
            this.uxCityText.Name = "uxCityText";
            this.uxCityText.Size = new System.Drawing.Size(141, 20);
            this.uxCityText.TabIndex = 8;
            // 
            // uxStateText
            // 
            this.uxStateText.Location = new System.Drawing.Point(97, 173);
            this.uxStateText.Name = "uxStateText";
            this.uxStateText.Size = new System.Drawing.Size(141, 20);
            this.uxStateText.TabIndex = 9;
            // 
            // uxUniversityText
            // 
            this.uxUniversityText.Location = new System.Drawing.Point(97, 223);
            this.uxUniversityText.Name = "uxUniversityText";
            this.uxUniversityText.Size = new System.Drawing.Size(141, 20);
            this.uxUniversityText.TabIndex = 10;
            // 
            // uxRatingText
            // 
            this.uxRatingText.Location = new System.Drawing.Point(97, 278);
            this.uxRatingText.Name = "uxRatingText";
            this.uxRatingText.Size = new System.Drawing.Size(141, 20);
            this.uxRatingText.TabIndex = 11;
            // 
            // uxInsertButton
            // 
            this.uxInsertButton.Location = new System.Drawing.Point(117, 321);
            this.uxInsertButton.Name = "uxInsertButton";
            this.uxInsertButton.Size = new System.Drawing.Size(75, 23);
            this.uxInsertButton.TabIndex = 12;
            this.uxInsertButton.Text = "Insert";
            this.uxInsertButton.UseVisualStyleBackColor = true;
            this.uxInsertButton.Click += new System.EventHandler(this.uxInsertButton_Click);
            // 
            // uxInsertBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 366);
            this.Controls.Add(this.uxInsertButton);
            this.Controls.Add(this.uxRatingText);
            this.Controls.Add(this.uxUniversityText);
            this.Controls.Add(this.uxStateText);
            this.Controls.Add(this.uxCityText);
            this.Controls.Add(this.uxAddressText);
            this.Controls.Add(this.uxNameText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uxInsertBar";
            this.Text = "Insert Bar";
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
        private System.Windows.Forms.TextBox uxAddressText;
        private System.Windows.Forms.TextBox uxCityText;
        private System.Windows.Forms.TextBox uxStateText;
        private System.Windows.Forms.TextBox uxUniversityText;
        private System.Windows.Forms.TextBox uxRatingText;
        private System.Windows.Forms.Button uxInsertButton;
    }
}