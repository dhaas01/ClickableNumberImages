namespace Clickable_Number_Images
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numberOnePictureBox = new System.Windows.Forms.PictureBox();
            this.numberTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.numberThreePictureBox = new System.Windows.Forms.PictureBox();
            this.numberFourPictureBox = new System.Windows.Forms.PictureBox();
            this.numberFivePictureBox = new System.Windows.Forms.PictureBox();
            this.numberBox = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberThreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFourPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFivePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOnePictureBox
            // 
            this.numberOnePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("numberOnePictureBox.Image")));
            this.numberOnePictureBox.Location = new System.Drawing.Point(12, 25);
            this.numberOnePictureBox.Name = "numberOnePictureBox";
            this.numberOnePictureBox.Size = new System.Drawing.Size(50, 100);
            this.numberOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberOnePictureBox.TabIndex = 1;
            this.numberOnePictureBox.TabStop = false;
            this.numberOnePictureBox.Click += new System.EventHandler(this.NumberOnePictureBox_Click);
            // 
            // numberTwoPictureBox
            // 
            this.numberTwoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("numberTwoPictureBox.Image")));
            this.numberTwoPictureBox.Location = new System.Drawing.Point(68, 25);
            this.numberTwoPictureBox.Name = "numberTwoPictureBox";
            this.numberTwoPictureBox.Size = new System.Drawing.Size(50, 100);
            this.numberTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberTwoPictureBox.TabIndex = 2;
            this.numberTwoPictureBox.TabStop = false;
            this.numberTwoPictureBox.Click += new System.EventHandler(this.NumberTwoPictureBox_Click);
            // 
            // numberThreePictureBox
            // 
            this.numberThreePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("numberThreePictureBox.Image")));
            this.numberThreePictureBox.Location = new System.Drawing.Point(124, 25);
            this.numberThreePictureBox.Name = "numberThreePictureBox";
            this.numberThreePictureBox.Size = new System.Drawing.Size(50, 100);
            this.numberThreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberThreePictureBox.TabIndex = 3;
            this.numberThreePictureBox.TabStop = false;
            this.numberThreePictureBox.Click += new System.EventHandler(this.NumberThreePictureBox_Click);
            // 
            // numberFourPictureBox
            // 
            this.numberFourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("numberFourPictureBox.Image")));
            this.numberFourPictureBox.Location = new System.Drawing.Point(180, 25);
            this.numberFourPictureBox.Name = "numberFourPictureBox";
            this.numberFourPictureBox.Size = new System.Drawing.Size(50, 100);
            this.numberFourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberFourPictureBox.TabIndex = 4;
            this.numberFourPictureBox.TabStop = false;
            this.numberFourPictureBox.Click += new System.EventHandler(this.NumberFourPictureBox_Click);
            // 
            // numberFivePictureBox
            // 
            this.numberFivePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("numberFivePictureBox.Image")));
            this.numberFivePictureBox.Location = new System.Drawing.Point(236, 25);
            this.numberFivePictureBox.Name = "numberFivePictureBox";
            this.numberFivePictureBox.Size = new System.Drawing.Size(50, 100);
            this.numberFivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberFivePictureBox.TabIndex = 5;
            this.numberFivePictureBox.TabStop = false;
            this.numberFivePictureBox.Click += new System.EventHandler(this.NumberFivePictureBox_Click);
            // 
            // numberBox
            // 
            this.numberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(12, 128);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(274, 45);
            this.numberBox.TabIndex = 6;
            this.numberBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.Location = new System.Drawing.Point(12, 9);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(281, 13);
            this.directionLabel.TabIndex = 7;
            this.directionLabel.Text = "Click on a number and it will display the number.";
            this.directionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.numberFivePictureBox);
            this.Controls.Add(this.numberFourPictureBox);
            this.Controls.Add(this.numberThreePictureBox);
            this.Controls.Add(this.numberTwoPictureBox);
            this.Controls.Add(this.numberOnePictureBox);
            this.Name = "Form1";
            this.Text = "Clickable Number Images";
            ((System.ComponentModel.ISupportInitialize)(this.numberOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberThreePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFourPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFivePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox numberOnePictureBox;
        private System.Windows.Forms.PictureBox numberTwoPictureBox;
        private System.Windows.Forms.PictureBox numberThreePictureBox;
        private System.Windows.Forms.PictureBox numberFourPictureBox;
        private System.Windows.Forms.PictureBox numberFivePictureBox;
        private System.Windows.Forms.Label numberBox;
        private System.Windows.Forms.Label directionLabel;
    }
}

