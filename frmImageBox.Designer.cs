namespace WindowsFormsApplayGround
{
    partial class frmImageBox
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
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.Image = global::WindowsFormsApplayGround.Properties.Resources.dice_1;
            this.picBox1.Location = new System.Drawing.Point(160, 75);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(232, 271);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "Roll ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox2
            // 
            this.picBox2.Image = global::WindowsFormsApplayGround.Properties.Resources.dice_1;
            this.picBox2.Location = new System.Drawing.Point(398, 75);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(232, 271);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 2;
            this.picBox2.TabStop = false;
            // 
            // frmImageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBox1);
            this.Name = "frmImageBox";
            this.Text = "frmImageBox";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBox2;
    }
}