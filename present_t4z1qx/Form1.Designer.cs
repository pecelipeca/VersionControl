﻿namespace present_t4z1qx
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.BallColor = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RibbonColor = new System.Windows.Forms.Button();
            this.BoxColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 172);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 278);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "BALL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(364, 35);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(68, 13);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            // 
            // BallColor
            // 
            this.BallColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BallColor.Location = new System.Drawing.Point(179, 59);
            this.BallColor.Name = "BallColor";
            this.BallColor.Size = new System.Drawing.Size(75, 23);
            this.BallColor.TabIndex = 3;
            this.BallColor.UseVisualStyleBackColor = false;
            this.BallColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "PRESENT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RibbonColor
            // 
            this.RibbonColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RibbonColor.Location = new System.Drawing.Point(260, 59);
            this.RibbonColor.Name = "RibbonColor";
            this.RibbonColor.Size = new System.Drawing.Size(75, 23);
            this.RibbonColor.TabIndex = 5;
            this.RibbonColor.UseVisualStyleBackColor = false;
            this.RibbonColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // BoxColor
            // 
            this.BoxColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BoxColor.Location = new System.Drawing.Point(260, 88);
            this.BoxColor.Name = "BoxColor";
            this.BoxColor.Size = new System.Drawing.Size(75, 23);
            this.BoxColor.TabIndex = 6;
            this.BoxColor.UseVisualStyleBackColor = false;
            this.BoxColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxColor);
            this.Controls.Add(this.RibbonColor);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BallColor);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BallColor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button RibbonColor;
        private System.Windows.Forms.Button BoxColor;
    }
}

