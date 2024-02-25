namespace GuessingGameProject
{
    partial class GuessingGameForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numTriesLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.historyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(111, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Guessing Game (0-100)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(210, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Max. 8 tries/game)";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(459, 39);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 54);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "No. Of Tries";
            // 
            // numTriesLabel
            // 
            this.numTriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numTriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTriesLabel.Location = new System.Drawing.Point(459, 217);
            this.numTriesLabel.Name = "numTriesLabel";
            this.numTriesLabel.Size = new System.Drawing.Size(96, 31);
            this.numTriesLabel.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(459, 300);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 51);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(279, 183);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(85, 38);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(144, 192);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(108, 22);
            this.inputTextBox.TabIndex = 7;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(69, 260);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 20);
            this.messageLabel.TabIndex = 8;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(69, 315);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(45, 20);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "Date";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(64, 379);
            this.progressBar1.Maximum = 8;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(242, 25);
            this.progressBar1.TabIndex = 10;
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(334, 340);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(89, 49);
            this.historyButton.TabIndex = 11;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // GuessingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.numTriesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GuessingGameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GuessingGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numTriesLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button historyButton;
    }
}