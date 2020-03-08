namespace ColorPicker
{
    partial class ColorTipForm
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
            this.ColorPictureBox = new System.Windows.Forms.PictureBox();
            this.D16ColorLabel = new System.Windows.Forms.Label();
            this.RGBColorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorPictureBox
            // 
            this.ColorPictureBox.BackColor = System.Drawing.Color.White;
            this.ColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPictureBox.Location = new System.Drawing.Point(12, 12);
            this.ColorPictureBox.Name = "ColorPictureBox";
            this.ColorPictureBox.Size = new System.Drawing.Size(50, 50);
            this.ColorPictureBox.TabIndex = 1;
            this.ColorPictureBox.TabStop = false;
            // 
            // D16ColorLabel
            // 
            this.D16ColorLabel.AutoSize = true;
            this.D16ColorLabel.Location = new System.Drawing.Point(68, 12);
            this.D16ColorLabel.Name = "D16ColorLabel";
            this.D16ColorLabel.Size = new System.Drawing.Size(47, 12);
            this.D16ColorLabel.TabIndex = 2;
            this.D16ColorLabel.Text = "#ffffff";
            // 
            // RGBColorLabel
            // 
            this.RGBColorLabel.AutoSize = true;
            this.RGBColorLabel.Location = new System.Drawing.Point(68, 24);
            this.RGBColorLabel.Name = "RGBColorLabel";
            this.RGBColorLabel.Size = new System.Drawing.Size(83, 12);
            this.RGBColorLabel.TabIndex = 4;
            this.RGBColorLabel.Text = "R:0, G:0, B:0";
            // 
            // ColorTipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 70);
            this.ControlBox = false;
            this.Controls.Add(this.RGBColorLabel);
            this.Controls.Add(this.D16ColorLabel);
            this.Controls.Add(this.ColorPictureBox);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorTipForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "X:0, Y:0";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ColorTipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label D16ColorLabel;
        private System.Windows.Forms.Label RGBColorLabel;
        public System.Windows.Forms.PictureBox ColorPictureBox;
    }
}