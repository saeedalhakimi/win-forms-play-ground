﻿namespace WindowsFormsApplayGround
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(407, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 20);
            this.textBox2.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click to Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hover to Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(347, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Copy on mouse inter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(347, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Copy on mouse down";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(226, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(347, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "Copy on mouse up";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(402, 370);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 40);
            this.button6.TabIndex = 101;
            this.button6.Text = "Disable";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(229, 370);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 40);
            this.button7.TabIndex = 101;
            this.button7.Text = "Enable";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(229, 410);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 40);
            this.button8.TabIndex = 102;
            this.button8.Text = "show";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(402, 410);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(165, 40);
            this.button9.TabIndex = 103;
            this.button9.Text = "hide";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(35, 90);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(129, 21);
            this.button10.TabIndex = 104;
            this.button10.Text = "change back color";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button11.FlatAppearance.BorderSize = 5;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(12, 208);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(195, 104);
            this.button11.TabIndex = 105;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "text and button form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

