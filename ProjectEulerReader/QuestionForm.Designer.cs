using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectEulerReader
{
    partial class QuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.numberLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.jumpBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.broswerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(12, 9);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(88, 16);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "Question xxxx";
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(13, 29);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(382, 101);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get " +
    "3, 5, 6 and 9. The sum of these multiples is 23.";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prevBtn
            // 
            this.prevBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prevBtn.Location = new System.Drawing.Point(15, 133);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(75, 23);
            this.prevBtn.TabIndex = 2;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(322, 133);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // jumpBtn
            // 
            this.jumpBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.jumpBtn.Location = new System.Drawing.Point(167, 133);
            this.jumpBtn.Name = "jumpBtn";
            this.jumpBtn.Size = new System.Drawing.Size(75, 23);
            this.jumpBtn.TabIndex = 4;
            this.jumpBtn.Text = "Goto";
            this.jumpBtn.UseVisualStyleBackColor = true;
            this.jumpBtn.Click += new System.EventHandler(this.jumpBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.infoLabel.Location = new System.Drawing.Point(159, 8);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(238, 20);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Solved by ??????? Rating: ??%";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // broswerBtn
            // 
            this.broswerBtn.Location = new System.Drawing.Point(101, 7);
            this.broswerBtn.Name = "broswerBtn";
            this.broswerBtn.Size = new System.Drawing.Size(50, 20);
            this.broswerBtn.TabIndex = 6;
            this.broswerBtn.Text = "web";
            this.broswerBtn.UseVisualStyleBackColor = true;
            this.broswerBtn.Click += new System.EventHandler(this.broswerBtn_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.broswerBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.jumpBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.numberLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(425, 200);
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question xxx";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numberLabel;
        private Label questionLabel;
        private Button prevBtn;
        private Button nextBtn;
        private Button jumpBtn;
        private Label infoLabel;
        private Button broswerBtn;
    }
}