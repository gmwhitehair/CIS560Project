
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxInsertButton = new System.Windows.Forms.Button();
            this.uxEmailText = new System.Windows.Forms.TextBox();
            this.uxText = new System.Windows.Forms.TextBox();
            this.uxTimeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Sent";
            // 
            // uxInsertButton
            // 
            this.uxInsertButton.Location = new System.Drawing.Point(51, 203);
            this.uxInsertButton.Name = "uxInsertButton";
            this.uxInsertButton.Size = new System.Drawing.Size(75, 23);
            this.uxInsertButton.TabIndex = 3;
            this.uxInsertButton.Text = "Insert";
            this.uxInsertButton.UseVisualStyleBackColor = true;
            this.uxInsertButton.Click += new System.EventHandler(this.uxInsertButton_Click);
            // 
            // uxEmailText
            // 
            this.uxEmailText.Location = new System.Drawing.Point(91, 19);
            this.uxEmailText.Name = "uxEmailText";
            this.uxEmailText.Size = new System.Drawing.Size(100, 20);
            this.uxEmailText.TabIndex = 4;
            // 
            // uxText
            // 
            this.uxText.Location = new System.Drawing.Point(91, 75);
            this.uxText.Name = "uxText";
            this.uxText.Size = new System.Drawing.Size(100, 20);
            this.uxText.TabIndex = 5;
            // 
            // uxTimeText
            // 
            this.uxTimeText.Location = new System.Drawing.Point(91, 139);
            this.uxTimeText.Name = "uxTimeText";
            this.uxTimeText.Size = new System.Drawing.Size(100, 20);
            this.uxTimeText.TabIndex = 6;
            // 
            // uxInsertComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 245);
            this.Controls.Add(this.uxTimeText);
            this.Controls.Add(this.uxText);
            this.Controls.Add(this.uxEmailText);
            this.Controls.Add(this.uxInsertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uxInsertComment";
            this.Text = "Insert Comment";
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
    }
}