using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 色情報の変更がループしないようにする変数
        /// </summary>
        private bool IsBusy { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 色情報の更新を行う
        /// </summary>
        /// <param name="color">新しい色情報</param>
        private void UpdateColor(Color color)
        {
            if (!this.IsBusy)
            {
                this.IsBusy = true;

                this.OutputColorPictureBox.BackColor = color;
                this.OutputSamplePanel.BackColor = color;
                this.OutputD16TextBox.Text = "#" + color.ToArgb().ToString("x4").Remove(0, 2);

                this.D16TextBox.Text = color.ToArgb().ToString("x4").Remove(0, 2);
                this.RedValueNumericUpDown.Value = color.R;
                this.RedColorSlider.Value = color.R;
                this.GreenValueNumericUpDown.Value = color.G;
                this.GreenColorSlider.Value = color.G;
                this.BlueValueNumericUpDown.Value = color.B;
                this.BlueColorSlider.Value = color.B;

                this.CaseConverte();
                this.IsBusy = false;
            }
        }

        /// <summary>
        /// 小文字・大文字に変換する
        /// </summary>
        private void CaseConverte()
        {
            if (this.ToLowerCheckBox.Checked)
            {
                this.OutputD16TextBox.Text = this.OutputD16TextBox.Text.ToLower();
                this.D16TextBox.Text = this.D16TextBox.Text.ToLower();
            }
            else if (this.ToUpperCheckBox.Checked)
            {
                this.OutputD16TextBox.Text = this.OutputD16TextBox.Text.ToUpper();
                this.D16TextBox.Text = this.D16TextBox.Text.ToUpper();
            }
        }

        /// <summary>
        /// 出力結果テキストボックスのクリックイベント
        /// </summary>
        private void OutputD16TextBox_Click(object sender, EventArgs e)
        {
            this.OutputD16TextBox.SelectAll();
        }

        /// <summary>
        /// コピーボタンのクリックイベント
        /// </summary>
        private void CopyOnClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.OutputD16TextBox.Text);
            this.OutputD16TextBox.SelectAll();
            this.OutputD16TextBox.Focus();
        }

        /// <summary>
        /// 保存ボタンのクリックイベント
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveColorPictureForm f = new SaveColorPictureForm(this.OutputColorPictureBox.BackColor);
            f.Location = new Point(this.Location.X + (this.Width - f.Width) / 2,
                this.Location.Y + (this.Height - f.Height) / 2);
            f.ShowDialog();
        }

        /// <summary>
        /// 小文字変換チェックボックスのチェック変更イベント
        /// </summary>
        private void ToLowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ToLowerCheckBox.Checked)
            {
                this.ToUpperCheckBox.Checked = false;
                this.CaseConverte();
            }
        }

        /// <summary>
        /// 大文字変換チェックボックスのチェック変更イベント
        /// </summary>
        private void ToUpperCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ToUpperCheckBox.Checked)
            {
                this.ToLowerCheckBox.Checked = false;
                this.CaseConverte();
            }
        }

        /// <summary>
        /// 16進数テキストボックスのキー入力イベント
        /// </summary>
        private void D16TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 16進数とバックスペース以外のキーを無効化
            if (!Uri.IsHexDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                if (this.D16TextBox.SelectedText.Length > 0)
                {
                    this.D16TextBox.SelectedText = "";
                }
                e.Handled = true;
            }
        }

        /// <summary>
        /// 16進数テキストボックスの値変更イベント
        /// </summary>
        private void D16TextBox_TextChanged(object sender, EventArgs e)
        {
            // カラーコード検出時に画面に反映
            string value = this.D16TextBox.Text;
            if ((value.Length == 3 || value.Length == 6) && value.IsHexString())
            {
                this.UpdateColor(ColorTranslator.FromHtml("#" + value));
            }
        }

        /// <summary>
        /// RGB値の値変更イベント
        /// </summary>
        private void RGBValueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateColor(Color.FromArgb((int)this.RedValueNumericUpDown.Value, (int)this.GreenValueNumericUpDown.Value, (int)this.BlueValueNumericUpDown.Value));
        }

        /// <summary>
        /// カラートラックバーの値変更イベント
        /// </summary>
        private void RGBColorSlider_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateColor(Color.FromArgb((int)RedColorSlider.Value, (int)GreenColorSlider.Value, (int)BlueColorSlider.Value));
        }

        /// <summary>
        /// 色情報の初期化ボタンのクリックイベント
        /// </summary>
        private void InitializeColorButton_Click(object sender, EventArgs e)
        {
            this.UpdateColor(Color.White);
        }

        /// <summary>
        /// 定義済み色一覧ボタンのクリックイベント
        /// </summary>
        private void DefinedColorListButton_Click(object sender, EventArgs e)
        {
            DefinedColorListForm f = new DefinedColorListForm();
            f.Location = new Point(this.Location.X + (this.Width - f.Width) / 2,
                this.Location.Y + (this.Height - f.Height) / 2);
            f.ShowDialog();
            if(f.IsLoad)
            {
                this.UpdateColor(f.OutputColor);
            }
        }

        /// <summary>
        /// カラーダイアログの表示ボタンのクリックイベント
        /// </summary>
        private void ShowColorDialogButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = this.OutputColorPictureBox.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.UpdateColor(cd.Color);
            }
        }

        /// <summary>
        /// ランダム色変更ボタンのクリックイベント
        /// </summary>
        private void GetRandomColorButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.UpdateColor(Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)));
        }

        /// <summary>
        /// 画面から色を抽出ボタンのクリックイベント
        /// </summary>
        private void GetColorFromDisplaubutton_Click(object sender, EventArgs e)
        {
            PickForm f = new PickForm();
            f.ShowDialog();
            if (f.IsOutput)
            {
                this.UpdateColor(f.OutputColor);
            }
        }
    }
}
