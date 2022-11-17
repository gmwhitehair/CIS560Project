
namespace ProjectApplication
{
    partial class uxInsert
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
            this.uxDeal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxDeal
            // 
            this.uxDeal.Location = new System.Drawing.Point(70, 42);
            this.uxDeal.Name = "uxDeal";
            this.uxDeal.Size = new System.Drawing.Size(75, 23);
            this.uxDeal.TabIndex = 0;
            this.uxDeal.Text = "Deal";
            this.uxDeal.UseVisualStyleBackColor = true;
            this.uxDeal.Click += new System.EventHandler(this.uxDeal_Click);
            // 
            // uxInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxDeal);
            this.Name = "uxInsert";
            this.Text = "Insert";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxDeal;
    }
}