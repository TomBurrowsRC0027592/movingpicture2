using System;

namespace movingpicture2
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
            this.Right = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.up = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(670, 228);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(58, 49);
            this.Right.TabIndex = 1;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::movingpicture2.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(258, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(608, 179);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(57, 46);
            this.up.TabIndex = 2;
            this.up.Text = "Up";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.Left_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(551, 231);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(57, 46);
            this.Left.TabIndex = 3;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(608, 284);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(58, 45);
            this.down.TabIndex = 4;
            this.down.Text = "Down";
            this.down.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.down);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.up);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button down;
    }
}

