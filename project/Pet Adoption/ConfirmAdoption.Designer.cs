﻿namespace Pet_Addaptation
{
    partial class ConfirmAdoption
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
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to confirm the adoption?";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.PaleGreen;
            this.btnYes.Location = new System.Drawing.Point(80, 128);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(98, 36);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNo.Location = new System.Drawing.Point(264, 128);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(88, 37);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // ConfirmAdoption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 203);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmAdoption";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmAdoption";
            this.Load += new System.EventHandler(this.ConfirmAdoption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}