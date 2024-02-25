namespace GuessingGameProject
{
    partial class History
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
            this.historyLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyLabel
            // 
            this.historyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.historyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLabel.Location = new System.Drawing.Point(12, 50);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(357, 308);
            this.historyLabel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(35, 376);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(79, 56);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "History of Number of Tries Taken";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(280, 376);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(79, 56);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(154, 376);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(89, 56);
            this.historyButton.TabIndex = 5;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 444);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.historyLabel);
            this.Name = "History";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button historyButton;
    }
}