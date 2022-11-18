
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxInsert = new System.Windows.Forms.Button();
            this.uxUniversityText = new System.Windows.Forms.TextBox();
            this.uxCityText = new System.Windows.Forms.TextBox();
            this.uxStateText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "University";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "State";
            // 
            // uxInsert
            // 
            this.uxInsert.Location = new System.Drawing.Point(123, 199);
            this.uxInsert.Name = "uxInsert";
            this.uxInsert.Size = new System.Drawing.Size(75, 23);
            this.uxInsert.TabIndex = 3;
            this.uxInsert.Text = "Insert";
            this.uxInsert.UseVisualStyleBackColor = true;
            this.uxInsert.Click += new System.EventHandler(this.uxInsert_Click);
            // 
            // uxUniversityText
            // 
            this.uxUniversityText.Location = new System.Drawing.Point(98, 6);
            this.uxUniversityText.Name = "uxUniversityText";
            this.uxUniversityText.Size = new System.Drawing.Size(100, 20);
            this.uxUniversityText.TabIndex = 4;
            // 
            // uxCityText
            // 
            this.uxCityText.Location = new System.Drawing.Point(98, 62);
            this.uxCityText.Name = "uxCityText";
            this.uxCityText.Size = new System.Drawing.Size(100, 20);
            this.uxCityText.TabIndex = 5;
            // 
            // uxStateText
            // 
            this.uxStateText.Location = new System.Drawing.Point(98, 118);
            this.uxStateText.Name = "uxStateText";
            this.uxStateText.Size = new System.Drawing.Size(100, 20);
            this.uxStateText.TabIndex = 6;
            // 
            // uxInsertCollegeTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 334);
            this.Controls.Add(this.uxStateText);
            this.Controls.Add(this.uxCityText);
            this.Controls.Add(this.uxUniversityText);
            this.Controls.Add(this.uxInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uxInsertCollegeTown";
            this.Text = "Insert College Town";
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
    }
}