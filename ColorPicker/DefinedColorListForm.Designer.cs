namespace ColorPicker
{
    partial class DefinedColorListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefinedColorListForm));
            this.LoadButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ColorListView = new System.Windows.Forms.ListView();
            this.PreviewColorButton = new System.Windows.Forms.Button();
            this.PreviewColorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(284, 326);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(85, 23);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "読み込み";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(375, 326);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "キャンセル";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ColorListView
            // 
            this.ColorListView.Location = new System.Drawing.Point(12, 12);
            this.ColorListView.Name = "ColorListView";
            this.ColorListView.Size = new System.Drawing.Size(443, 308);
            this.ColorListView.TabIndex = 5;
            this.ColorListView.UseCompatibleStateImageBehavior = false;
            this.ColorListView.View = System.Windows.Forms.View.SmallIcon;
            this.ColorListView.SelectedIndexChanged += new System.EventHandler(this.ColorListView_SelectedIndexChanged);
            // 
            // PreviewColorButton
            // 
            this.PreviewColorButton.BackColor = System.Drawing.Color.White;
            this.PreviewColorButton.Location = new System.Drawing.Point(12, 326);
            this.PreviewColorButton.Name = "PreviewColorButton";
            this.PreviewColorButton.Size = new System.Drawing.Size(50, 23);
            this.PreviewColorButton.TabIndex = 6;
            this.PreviewColorButton.UseVisualStyleBackColor = false;
            // 
            // PreviewColorTextBox
            // 
            this.PreviewColorTextBox.Location = new System.Drawing.Point(68, 328);
            this.PreviewColorTextBox.Name = "PreviewColorTextBox";
            this.PreviewColorTextBox.ReadOnly = true;
            this.PreviewColorTextBox.Size = new System.Drawing.Size(100, 19);
            this.PreviewColorTextBox.TabIndex = 7;
            this.PreviewColorTextBox.Text = "#ffffff";
            // 
            // DefinedColorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 361);
            this.Controls.Add(this.PreviewColorTextBox);
            this.Controls.Add(this.PreviewColorButton);
            this.Controls.Add(this.ColorListView);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefinedColorListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "定義済み色一覧";
            this.Load += new System.EventHandler(this.DefinedColorListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListView ColorListView;
        private System.Windows.Forms.Button PreviewColorButton;
        private System.Windows.Forms.TextBox PreviewColorTextBox;
    }
}