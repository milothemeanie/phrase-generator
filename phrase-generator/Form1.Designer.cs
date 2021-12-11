using System;

namespace phrase_generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.lblMask = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(144, 46);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFileName.Size = new System.Drawing.Size(60, 15);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name";
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Location = new System.Drawing.Point(144, 148);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhrase.Size = new System.Drawing.Size(42, 15);
            this.lblPhrase.TabIndex = 1;
            this.lblPhrase.Text = "Phrase";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(144, 325);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKeyword.Size = new System.Drawing.Size(58, 15);
            this.lblKeyword.TabIndex = 2;
            this.lblKeyword.Text = "Keywords";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(144, 64);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(361, 23);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.Text = "output.txt";
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(144, 116);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(361, 23);
            this.txtMask.TabIndex = 2;
            this.txtMask.Text = "[KEYWORD]";
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(144, 98);
            this.lblMask.Name = "lblMask";
            this.lblMask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMask.Size = new System.Drawing.Size(35, 15);
            this.lblMask.TabIndex = 5;
            this.lblMask.Text = "Mask";
            // 
            // txtKeyword
            // 
            this.txtKeyword.AcceptsReturn = true;
            this.txtKeyword.Location = new System.Drawing.Point(144, 343);
            this.txtKeyword.Multiline = true;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyword.Size = new System.Drawing.Size(361, 175);
            this.txtKeyword.TabIndex = 4;
            this.txtKeyword.WordWrap = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(212, 554);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(191, 43);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(46, 626);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(36, 17);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "TEST";
            this.lblMessage.Visible = false;
            // 
            // txtPhrase
            // 
            this.txtPhrase.AcceptsReturn = true;
            this.txtPhrase.Location = new System.Drawing.Point(144, 166);
            this.txtPhrase.Multiline = true;
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhrase.Size = new System.Drawing.Size(361, 135);
            this.txtPhrase.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 675);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblPhrase);
            this.Controls.Add(this.lblFileName);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Keyword to Phrase Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtPhrase;
    }
}
