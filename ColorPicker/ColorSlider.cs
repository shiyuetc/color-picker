using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ColorPicker
{
    public partial class ColorSlider : Control
    {
        // イベントの宣言  
        [Description("コントロールの値が変更するとき発生します。")]
        [Category("アクション")]
        public event EventHandler ValueChanged;
        public int Maximum { set; get; } = 100;
        public int Minimum { get; set; }
        private int _value;
        public int Value
        {
            set
            {
                this._value = value;
                drawGradation();
                this.Refresh();
                if (ValueChanged != null && Value <= Minimum && Value >= Maximum) ValueChanged(this, new EventArgs());
            }
            get
            {
                return this._value;
            }
        }
        private Color _startColor = Color.Black;
        public Color StartColor
        {
            set
            {
                this._startColor = value;
                drawGradation();
                this.Refresh();
            }
            get
            {

                return this._startColor;
            }
        }

        private Color _endColor = Color.White;
        public Color EndColor
        {
            set
            {
                this._endColor = value;
                drawGradation();
                this.Refresh();
            }
            get
            {

                return this._endColor;
            }
        }

        public ColorSlider()
        {
            //InitializeComponent();

            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            this.Resize += new EventHandler(this.ColorSlider_Resize);
            this.MouseMove += new MouseEventHandler(this.ColorSlider_MouseMove);
            this.MouseDown += new MouseEventHandler(this.ColorSlider_MouseDown);
            this.MouseUp += new MouseEventHandler(this.ColorSlider_MouseUp);
            this.MouseLeave += new EventHandler(this.ColorSlider_MouseLeave);
            this.MouseEnter += new EventHandler(this.ColorSlider_MouseEnter);

            drawTick();
        }

        // 描画  
        //針の描画  
        private Bitmap tick;
        private void drawTick()
        {
            tick = new Bitmap(10, 10);

            Graphics g = Graphics.FromImage(tick);
            g.SmoothingMode = SmoothingMode.HighQuality;
            Point[] point = {   new Point(5,1), new Point(9,5),
                                new Point(9,7), new Point(8,8),
                                new Point(2,8), new Point(1,7),
                                new Point(1,5), new Point(5,1) };
            Brush b = new SolidBrush(Color.White);
            g.FillPolygon(b, point);
            Pen p = new Pen(Color.Black, 1);
            if (activeFlag == true)
            {
                p = new Pen(Color.Brown, 1);
            }
            g.DrawLines(p, point);
            g.Dispose();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            pe.Graphics.DrawImage(gradation, 5, 0, gradation.Width, gradation.Height);
            pe.Graphics.DrawImage(tick, (Value * gradation.Width) / (Maximum - Minimum), gradation.Height);

        }

        //グラデーションの描画  
        private Bitmap gradation;
        private void drawGradation()
        {
            if (this.Width > 10 && this.Height > 10)
            {
                Size gradationSize = new Size(this.Width - 10, this.Height - 10);

                gradation = new Bitmap(gradationSize.Width, gradationSize.Height);
                Graphics g = Graphics.FromImage(gradation);
                LinearGradientBrush gb =
                    new LinearGradientBrush(new Point(0, 0), new Point(gradationSize.Width, gradationSize.Height),
                        StartColor, EndColor);
                g.FillRectangle(gb, new Rectangle(0, 0, gradationSize.Width, gradationSize.Height));

                //枠線  
                Pen p = new Pen(Color.Black, 1);
                if (activeFlag == true)
                {
                    p = new Pen(Color.Brown, 1);
                }

                g.DrawRectangle(p, 0, 0, gradationSize.Width - 1, gradationSize.Height - 1);
                g.Dispose();
            }

        }


        //リサイズ時、グラデーションの再描画  
        private void ColorSlider_Resize(object sender, EventArgs e)
        {
            drawGradation();
            this.Refresh();
        }


        //プロパティ  
        private bool mouseDown = false;
        private void ColorSlider_MouseDown(object sender, MouseEventArgs e)
        {
            Value = (int)(((float)(e.X - 5) / (this.Width - 10)) * (Maximum - Minimum));
            if (Value <= Minimum) Value = Minimum;
            if (Value >= Maximum) Value = Maximum;

            this.Refresh();

            ValueChanged?.Invoke(this, new EventArgs());

            mouseDown = true;
        }

        private void ColorSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Value = (int)(((float)(e.X - 5) / (this.Width - 10)) * (Maximum - Minimum));
                if (Value <= Minimum) Value = Minimum;
                if (Value >= Maximum) Value = Maximum;

                this.Refresh();

                ValueChanged?.Invoke(this, new EventArgs());
            }
        }

        private void ColorSlider_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private bool activeFlag = false;
        private void ColorSlider_MouseEnter(object sender, EventArgs e)
        {
            activeFlag = true;

            drawGradation();
            drawTick();
            this.Refresh();
        }

        private void ColorSlider_MouseLeave(object sender, EventArgs e)
        {
            activeFlag = false;

            drawGradation();
            drawTick();
            this.Refresh();
        }

    }
}
