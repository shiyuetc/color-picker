using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class PickForm : Form
    {
        /// <summary>
        /// カラー詳細フォーム
        /// </summary>
        private ColorTipForm ColorTipForm = new ColorTipForm();

        /// <summary>
        /// 出力する色
        /// </summary>
        public Color OutputColor { get; private set; }

        /// <summary>
        /// 出力フラグ
        /// </summary>
        public bool IsOutput { get; private set; }

        public PickForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// カラー詳細フォームの更新
        /// </summary>
        /// <param name="point"></param>
        private void UpdateColorTipForm(Point point)
        {
            Bitmap bmp = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(point, new Point(0, 0), new Size(1, 1));
            g.Dispose();
            this.ColorTipForm.Update(point, bmp.GetPixel(0, 0));
        }

        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        private void PickForm_Load(object sender, System.EventArgs e)
        {
            this.ColorTipForm.Show();
            this.UpdateColorTipForm(Cursor.Position);
        }

        /// <summary>
        /// フォームのマウスクリックイベント
        /// </summary>
        private void PickForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.OutputColor = this.ColorTipForm.ColorPictureBox.BackColor;
                this.IsOutput = true;
            }
            this.ColorTipForm.Close();
            this.Close();
        }

        /// <summary>
        /// フォームのマウスムーブイベント
        /// </summary>
        private void PickForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.UpdateColorTipForm(new Point(e.X, e.Y));
        }
    }
}
