﻿namespace Comp123_S2019_Lab10_301052117
{
    partial class MainForm
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
            this.mainFormLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainFormLabel
            // 
            this.mainFormLabel.AutoSize = true;
            this.mainFormLabel.Location = new System.Drawing.Point(222, 257);
            this.mainFormLabel.Name = "mainFormLabel";
            this.mainFormLabel.Size = new System.Drawing.Size(308, 31);
            this.mainFormLabel.TabIndex = 1;
            this.mainFormLabel.Text = "Welcome To Main Form!";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(318, 311);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(105, 47);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(318, 401);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(105, 47);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.mainFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainFormLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button closeButton;
    }
}

