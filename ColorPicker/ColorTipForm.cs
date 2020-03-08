using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class ColorTipForm : Form
    {
        public ColorTipForm()
        {
            InitializeComponent();
        }
        
        private void ColorTipForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 色情報の更新を行う
        /// </summary>
        /// <param name="point">現在の座標</param>
        /// <param name="color">新しい色の情報</param>
        public void Update(Point point, Color color)
        {
            this.Location = new Point(point.X - (this.Width / 2), point.Y + 30);
            this.Text = string.Format("X:{0}, Y:{1}", point.X, point.Y);
            this.ColorPictureBox.BackColor = color;
            this.D16ColorLabel.Text = "#" + color.ToArgb().ToString("x4").Remove(0, 2);
            this.RGBColorLabel.Text = string.Format("R:{0}, G:{1}, B:{2}", color.R, color.G, color.B);
        }
    }
}
