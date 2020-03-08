using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class SaveColorPictureForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private Color SaveColor { get; set; }

        /// <summary>
        /// 画像形式の配列
        /// </summary>
        private ImageFormat[] SaveFormat = new ImageFormat[] { ImageFormat.Png, ImageFormat.Jpeg };

        public SaveColorPictureForm(Color color)
        {
            this.SaveColor = color;
            InitializeComponent();
        }

        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        private void SaveColorPictureForm_Load(object sender, EventArgs e)
        {
            this.ColorImageButton.BackColor = this.SaveColor;
            foreach (ImageFormat format in this.SaveFormat)
            {
                this.FormatComboBox.Items.Add(format.ToString().ToUpper() + "形式");
            }
            this.FormatComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 保存ボタンのクリックイベント
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = this.SaveColor.ToArgb().ToString("x4").Remove(0, 2) +
                "_" + this.WidthNumericUpDown.Value + "x" + this.HeightNumericUpDown.Value + "." + this.SaveFormat[this.FormatComboBox.SelectedIndex].ToString().ToLower();
            sfd.Filter = "画像ファイル|*." + this.SaveFormat[this.FormatComboBox.SelectedIndex].ToString().ToLower() + "|すべてのファイル(*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap saveImage = new Bitmap((int)this.WidthNumericUpDown.Value, (int)this.HeightNumericUpDown.Value);
                Graphics g = Graphics.FromImage(saveImage);
                g.FillRectangle(new SolidBrush(SaveColor), g.VisibleClipBounds);
                g.Dispose();
                saveImage.Save(sfd.FileName, this.SaveFormat[this.FormatComboBox.SelectedIndex]);
                this.Close();
            }
        }

        /// <summary>
        /// キャンセルボタンのクリックイベント
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
