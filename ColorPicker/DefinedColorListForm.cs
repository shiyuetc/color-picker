using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class DefinedColorListForm : Form
    {
        /// <summary>
        /// 親フォームに返す色情報
        /// </summary>
        public Color OutputColor { get; private set; }

        /// <summary>
        /// 読み込み処理を行うかどうか
        /// </summary>
        public bool IsLoad { get; private set; }

        public DefinedColorListForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        private void DefinedColorListForm_Load(object sender, EventArgs e)
        {
            foreach (PropertyInfo info in typeof(Color).GetProperties(BindingFlags.Public | BindingFlags.Static))
            {
                Color color = (Color)info.GetValue(null, null);
                if (color.Name == "Transparent")
                    continue;

                string value = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
                ListViewItem item = new ListViewItem(new string[] { color.Name, value });
                item.BackColor = color;
                this.ColorListView.Items.Add(item);
            }
            this.Text = "定義済み色一覧(" + ColorListView.Items.Count + ")";
            this.ColorListView.Items[0].Selected = true;
        }

        /// <summary>
        /// 定義済み色一覧の選択値変更イベント
        /// </summary>
        private void ColorListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColorListView.SelectedItems.Count > 0)
            {
                this.PreviewColorButton.BackColor = this.ColorListView.Items[this.ColorListView.SelectedItems[0].Index].BackColor;
                this.PreviewColorTextBox.Text = "#" + this.PreviewColorButton.BackColor.R.ToString("x2") + this.PreviewColorButton.BackColor.G.ToString("x2") + this.PreviewColorButton.BackColor.B.ToString("x2");
            }
        }

        /// <summary>
        /// 読み込みボタンのクリックイベント
        /// </summary>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            this.IsLoad = true;
            this.OutputColor = this.PreviewColorButton.BackColor;
            this.Close();
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
