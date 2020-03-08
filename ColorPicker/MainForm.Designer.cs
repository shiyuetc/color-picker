namespace ColorPicker
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OutputColorPictureBox = new System.Windows.Forms.PictureBox();
            this.OutputSamplePanel = new System.Windows.Forms.Panel();
            this.OutputSampleLabel4 = new System.Windows.Forms.Label();
            this.OutputSampleLabel3 = new System.Windows.Forms.Label();
            this.OutputSampleLabel2 = new System.Windows.Forms.Label();
            this.OutputSampleLabel1 = new System.Windows.Forms.Label();
            this.RedValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GreenValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BlueValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RedColorSlider = new ColorPicker.ColorSlider();
            this.GreenColorSlider = new ColorPicker.ColorSlider();
            this.BlueColorSlider = new ColorPicker.ColorSlider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ToUpperCheckBox = new System.Windows.Forms.CheckBox();
            this.ToLowerCheckBox = new System.Windows.Forms.CheckBox();
            this.D16TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CopyOnClipboardButton = new System.Windows.Forms.Button();
            this.OutputD16TextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DefinedColorListButton = new System.Windows.Forms.Button();
            this.ShowColorDialogButton = new System.Windows.Forms.Button();
            this.GetRandomColorButton = new System.Windows.Forms.Button();
            this.InitializeColorButton = new System.Windows.Forms.Button();
            this.GetColorFromDisplaubutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OutputColorPictureBox)).BeginInit();
            this.OutputSamplePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueValueNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputColorPictureBox
            // 
            this.OutputColorPictureBox.BackColor = System.Drawing.Color.White;
            this.OutputColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputColorPictureBox.Location = new System.Drawing.Point(18, 21);
            this.OutputColorPictureBox.Name = "OutputColorPictureBox";
            this.OutputColorPictureBox.Size = new System.Drawing.Size(100, 100);
            this.OutputColorPictureBox.TabIndex = 2;
            this.OutputColorPictureBox.TabStop = false;
            // 
            // OutputSamplePanel
            // 
            this.OutputSamplePanel.BackColor = System.Drawing.Color.White;
            this.OutputSamplePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputSamplePanel.Controls.Add(this.OutputSampleLabel4);
            this.OutputSamplePanel.Controls.Add(this.OutputSampleLabel3);
            this.OutputSamplePanel.Controls.Add(this.OutputSampleLabel2);
            this.OutputSamplePanel.Controls.Add(this.OutputSampleLabel1);
            this.OutputSamplePanel.Location = new System.Drawing.Point(124, 21);
            this.OutputSamplePanel.Name = "OutputSamplePanel";
            this.OutputSamplePanel.Size = new System.Drawing.Size(220, 100);
            this.OutputSamplePanel.TabIndex = 3;
            // 
            // OutputSampleLabel4
            // 
            this.OutputSampleLabel4.AutoSize = true;
            this.OutputSampleLabel4.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OutputSampleLabel4.ForeColor = System.Drawing.Color.White;
            this.OutputSampleLabel4.Location = new System.Drawing.Point(9, 77);
            this.OutputSampleLabel4.Name = "OutputSampleLabel4";
            this.OutputSampleLabel4.Size = new System.Drawing.Size(200, 12);
            this.OutputSampleLabel4.TabIndex = 3;
            this.OutputSampleLabel4.Text = "これはサンプルのテキストです。";
            // 
            // OutputSampleLabel3
            // 
            this.OutputSampleLabel3.AutoSize = true;
            this.OutputSampleLabel3.ForeColor = System.Drawing.Color.White;
            this.OutputSampleLabel3.Location = new System.Drawing.Point(9, 54);
            this.OutputSampleLabel3.Name = "OutputSampleLabel3";
            this.OutputSampleLabel3.Size = new System.Drawing.Size(185, 12);
            this.OutputSampleLabel3.TabIndex = 2;
            this.OutputSampleLabel3.Text = "これはサンプルのテキストです。";
            // 
            // OutputSampleLabel2
            // 
            this.OutputSampleLabel2.AutoSize = true;
            this.OutputSampleLabel2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OutputSampleLabel2.Location = new System.Drawing.Point(9, 32);
            this.OutputSampleLabel2.Name = "OutputSampleLabel2";
            this.OutputSampleLabel2.Size = new System.Drawing.Size(200, 12);
            this.OutputSampleLabel2.TabIndex = 1;
            this.OutputSampleLabel2.Text = "これはサンプルのテキストです。";
            // 
            // OutputSampleLabel1
            // 
            this.OutputSampleLabel1.AutoSize = true;
            this.OutputSampleLabel1.Location = new System.Drawing.Point(9, 9);
            this.OutputSampleLabel1.Name = "OutputSampleLabel1";
            this.OutputSampleLabel1.Size = new System.Drawing.Size(185, 12);
            this.OutputSampleLabel1.TabIndex = 0;
            this.OutputSampleLabel1.Text = "これはサンプルのテキストです。";
            // 
            // RedValueNumericUpDown
            // 
            this.RedValueNumericUpDown.Location = new System.Drawing.Point(33, 21);
            this.RedValueNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedValueNumericUpDown.Name = "RedValueNumericUpDown";
            this.RedValueNumericUpDown.Size = new System.Drawing.Size(40, 19);
            this.RedValueNumericUpDown.TabIndex = 7;
            this.RedValueNumericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedValueNumericUpDown.ValueChanged += new System.EventHandler(this.RGBValueNumericUpDown_ValueChanged);
            // 
            // GreenValueNumericUpDown
            // 
            this.GreenValueNumericUpDown.Location = new System.Drawing.Point(33, 43);
            this.GreenValueNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenValueNumericUpDown.Name = "GreenValueNumericUpDown";
            this.GreenValueNumericUpDown.Size = new System.Drawing.Size(40, 19);
            this.GreenValueNumericUpDown.TabIndex = 8;
            this.GreenValueNumericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenValueNumericUpDown.ValueChanged += new System.EventHandler(this.RGBValueNumericUpDown_ValueChanged);
            // 
            // BlueValueNumericUpDown
            // 
            this.BlueValueNumericUpDown.Location = new System.Drawing.Point(33, 65);
            this.BlueValueNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueValueNumericUpDown.Name = "BlueValueNumericUpDown";
            this.BlueValueNumericUpDown.Size = new System.Drawing.Size(40, 19);
            this.BlueValueNumericUpDown.TabIndex = 9;
            this.BlueValueNumericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueValueNumericUpDown.ValueChanged += new System.EventHandler(this.RGBValueNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "B";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RedColorSlider);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GreenColorSlider);
            this.groupBox1.Controls.Add(this.BlueColorSlider);
            this.groupBox1.Controls.Add(this.BlueValueNumericUpDown);
            this.groupBox1.Controls.Add(this.RedValueNumericUpDown);
            this.groupBox1.Controls.Add(this.GreenValueNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(6, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 99);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB値";
            // 
            // RedColorSlider
            // 
            this.RedColorSlider.EndColor = System.Drawing.Color.Red;
            this.RedColorSlider.Location = new System.Drawing.Point(75, 24);
            this.RedColorSlider.Maximum = 255;
            this.RedColorSlider.Minimum = 0;
            this.RedColorSlider.Name = "RedColorSlider";
            this.RedColorSlider.Size = new System.Drawing.Size(269, 16);
            this.RedColorSlider.StartColor = System.Drawing.Color.Black;
            this.RedColorSlider.TabIndex = 4;
            this.RedColorSlider.Text = "colorSlider1";
            this.RedColorSlider.Value = 255;
            this.RedColorSlider.ValueChanged += new System.EventHandler(this.RGBColorSlider_ValueChanged);
            // 
            // GreenColorSlider
            // 
            this.GreenColorSlider.EndColor = System.Drawing.Color.Green;
            this.GreenColorSlider.Location = new System.Drawing.Point(75, 46);
            this.GreenColorSlider.Maximum = 255;
            this.GreenColorSlider.Minimum = 0;
            this.GreenColorSlider.Name = "GreenColorSlider";
            this.GreenColorSlider.Size = new System.Drawing.Size(269, 16);
            this.GreenColorSlider.StartColor = System.Drawing.Color.Black;
            this.GreenColorSlider.TabIndex = 5;
            this.GreenColorSlider.Text = "colorSlider2";
            this.GreenColorSlider.Value = 255;
            this.GreenColorSlider.ValueChanged += new System.EventHandler(this.RGBColorSlider_ValueChanged);
            // 
            // BlueColorSlider
            // 
            this.BlueColorSlider.EndColor = System.Drawing.Color.Blue;
            this.BlueColorSlider.Location = new System.Drawing.Point(75, 68);
            this.BlueColorSlider.Maximum = 255;
            this.BlueColorSlider.Minimum = 0;
            this.BlueColorSlider.Name = "BlueColorSlider";
            this.BlueColorSlider.Size = new System.Drawing.Size(269, 16);
            this.BlueColorSlider.StartColor = System.Drawing.Color.Black;
            this.BlueColorSlider.TabIndex = 6;
            this.BlueColorSlider.Text = "colorSlider3";
            this.BlueColorSlider.Value = 255;
            this.BlueColorSlider.ValueChanged += new System.EventHandler(this.RGBColorSlider_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 349);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出力色情報";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ToUpperCheckBox);
            this.groupBox4.Controls.Add(this.ToLowerCheckBox);
            this.groupBox4.Controls.Add(this.D16TextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 54);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "16進数";
            // 
            // ToUpperCheckBox
            // 
            this.ToUpperCheckBox.AutoSize = true;
            this.ToUpperCheckBox.Location = new System.Drawing.Point(229, 23);
            this.ToUpperCheckBox.Name = "ToUpperCheckBox";
            this.ToUpperCheckBox.Size = new System.Drawing.Size(84, 16);
            this.ToUpperCheckBox.TabIndex = 3;
            this.ToUpperCheckBox.Text = "大文字変換";
            this.ToUpperCheckBox.UseVisualStyleBackColor = true;
            this.ToUpperCheckBox.CheckedChanged += new System.EventHandler(this.ToUpperCheckBox_CheckedChanged);
            // 
            // ToLowerCheckBox
            // 
            this.ToLowerCheckBox.AutoSize = true;
            this.ToLowerCheckBox.Location = new System.Drawing.Point(139, 23);
            this.ToLowerCheckBox.Name = "ToLowerCheckBox";
            this.ToLowerCheckBox.Size = new System.Drawing.Size(84, 16);
            this.ToLowerCheckBox.TabIndex = 2;
            this.ToLowerCheckBox.Text = "小文字変換";
            this.ToLowerCheckBox.UseVisualStyleBackColor = true;
            this.ToLowerCheckBox.CheckedChanged += new System.EventHandler(this.ToLowerCheckBox_CheckedChanged);
            // 
            // D16TextBox
            // 
            this.D16TextBox.Location = new System.Drawing.Point(33, 21);
            this.D16TextBox.MaxLength = 6;
            this.D16TextBox.Name = "D16TextBox";
            this.D16TextBox.Size = new System.Drawing.Size(100, 19);
            this.D16TextBox.TabIndex = 1;
            this.D16TextBox.Text = "ffffff";
            this.D16TextBox.TextChanged += new System.EventHandler(this.D16TextBox_TextChanged);
            this.D16TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.D16TextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "#";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SaveButton);
            this.groupBox3.Controls.Add(this.CopyOnClipboardButton);
            this.groupBox3.Controls.Add(this.OutputD16TextBox);
            this.groupBox3.Controls.Add(this.OutputColorPictureBox);
            this.groupBox3.Controls.Add(this.OutputSamplePanel);
            this.groupBox3.Location = new System.Drawing.Point(6, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 160);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "出力結果";
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(151, 125);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(25, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CopyOnClipboardButton
            // 
            this.CopyOnClipboardButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyOnClipboardButton.Image")));
            this.CopyOnClipboardButton.Location = new System.Drawing.Point(124, 125);
            this.CopyOnClipboardButton.Name = "CopyOnClipboardButton";
            this.CopyOnClipboardButton.Size = new System.Drawing.Size(25, 23);
            this.CopyOnClipboardButton.TabIndex = 5;
            this.CopyOnClipboardButton.UseVisualStyleBackColor = true;
            this.CopyOnClipboardButton.Click += new System.EventHandler(this.CopyOnClipboardButton_Click);
            // 
            // OutputD16TextBox
            // 
            this.OutputD16TextBox.Location = new System.Drawing.Point(18, 127);
            this.OutputD16TextBox.Name = "OutputD16TextBox";
            this.OutputD16TextBox.ReadOnly = true;
            this.OutputD16TextBox.Size = new System.Drawing.Size(100, 19);
            this.OutputD16TextBox.TabIndex = 4;
            this.OutputD16TextBox.Text = "#ffffff";
            this.OutputD16TextBox.Click += new System.EventHandler(this.OutputD16TextBox_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DefinedColorListButton);
            this.groupBox5.Controls.Add(this.ShowColorDialogButton);
            this.groupBox5.Controls.Add(this.GetRandomColorButton);
            this.groupBox5.Controls.Add(this.InitializeColorButton);
            this.groupBox5.Controls.Add(this.GetColorFromDisplaubutton);
            this.groupBox5.Location = new System.Drawing.Point(394, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(165, 178);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ツール";
            // 
            // DefinedColorListButton
            // 
            this.DefinedColorListButton.Image = ((System.Drawing.Image)(resources.GetObject("DefinedColorListButton.Image")));
            this.DefinedColorListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DefinedColorListButton.Location = new System.Drawing.Point(15, 56);
            this.DefinedColorListButton.Name = "DefinedColorListButton";
            this.DefinedColorListButton.Size = new System.Drawing.Size(133, 23);
            this.DefinedColorListButton.TabIndex = 4;
            this.DefinedColorListButton.Text = "定義済み色一覧";
            this.DefinedColorListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DefinedColorListButton.UseVisualStyleBackColor = true;
            this.DefinedColorListButton.Click += new System.EventHandler(this.DefinedColorListButton_Click);
            // 
            // ShowColorDialogButton
            // 
            this.ShowColorDialogButton.Location = new System.Drawing.Point(15, 85);
            this.ShowColorDialogButton.Name = "ShowColorDialogButton";
            this.ShowColorDialogButton.Size = new System.Drawing.Size(133, 23);
            this.ShowColorDialogButton.TabIndex = 3;
            this.ShowColorDialogButton.Text = "ｶﾗｰﾀﾞｲｱﾛｸﾞを表示";
            this.ShowColorDialogButton.UseVisualStyleBackColor = true;
            this.ShowColorDialogButton.Click += new System.EventHandler(this.ShowColorDialogButton_Click);
            // 
            // GetRandomColorButton
            // 
            this.GetRandomColorButton.Image = ((System.Drawing.Image)(resources.GetObject("GetRandomColorButton.Image")));
            this.GetRandomColorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GetRandomColorButton.Location = new System.Drawing.Point(15, 114);
            this.GetRandomColorButton.Name = "GetRandomColorButton";
            this.GetRandomColorButton.Size = new System.Drawing.Size(133, 23);
            this.GetRandomColorButton.TabIndex = 2;
            this.GetRandomColorButton.Text = "ランダム色変更";
            this.GetRandomColorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GetRandomColorButton.UseVisualStyleBackColor = true;
            this.GetRandomColorButton.Click += new System.EventHandler(this.GetRandomColorButton_Click);
            // 
            // InitializeColorButton
            // 
            this.InitializeColorButton.Location = new System.Drawing.Point(15, 27);
            this.InitializeColorButton.Name = "InitializeColorButton";
            this.InitializeColorButton.Size = new System.Drawing.Size(133, 23);
            this.InitializeColorButton.TabIndex = 1;
            this.InitializeColorButton.Text = "色情報を初期化";
            this.InitializeColorButton.UseVisualStyleBackColor = true;
            this.InitializeColorButton.Click += new System.EventHandler(this.InitializeColorButton_Click);
            // 
            // GetColorFromDisplaubutton
            // 
            this.GetColorFromDisplaubutton.Image = ((System.Drawing.Image)(resources.GetObject("GetColorFromDisplaubutton.Image")));
            this.GetColorFromDisplaubutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GetColorFromDisplaubutton.Location = new System.Drawing.Point(15, 143);
            this.GetColorFromDisplaubutton.Name = "GetColorFromDisplaubutton";
            this.GetColorFromDisplaubutton.Size = new System.Drawing.Size(133, 23);
            this.GetColorFromDisplaubutton.TabIndex = 0;
            this.GetColorFromDisplaubutton.Text = "画面から色を抽出";
            this.GetColorFromDisplaubutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GetColorFromDisplaubutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GetColorFromDisplaubutton.UseVisualStyleBackColor = true;
            this.GetColorFromDisplaubutton.Click += new System.EventHandler(this.GetColorFromDisplaubutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 373);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ColorPicker";
            ((System.ComponentModel.ISupportInitialize)(this.OutputColorPictureBox)).EndInit();
            this.OutputSamplePanel.ResumeLayout(false);
            this.OutputSamplePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueValueNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox OutputColorPictureBox;
        private System.Windows.Forms.Panel OutputSamplePanel;
        private System.Windows.Forms.Label OutputSampleLabel4;
        private System.Windows.Forms.Label OutputSampleLabel3;
        private System.Windows.Forms.Label OutputSampleLabel2;
        private System.Windows.Forms.Label OutputSampleLabel1;
        private ColorSlider RedColorSlider;
        private ColorSlider GreenColorSlider;
        private ColorSlider BlueColorSlider;
        private System.Windows.Forms.NumericUpDown RedValueNumericUpDown;
        private System.Windows.Forms.NumericUpDown GreenValueNumericUpDown;
        private System.Windows.Forms.NumericUpDown BlueValueNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ToUpperCheckBox;
        private System.Windows.Forms.CheckBox ToLowerCheckBox;
        private System.Windows.Forms.TextBox D16TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox OutputD16TextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button GetColorFromDisplaubutton;
        private System.Windows.Forms.Button GetRandomColorButton;
        private System.Windows.Forms.Button InitializeColorButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CopyOnClipboardButton;
        private System.Windows.Forms.Button ShowColorDialogButton;
        private System.Windows.Forms.Button DefinedColorListButton;
    }
}

