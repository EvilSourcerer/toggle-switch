using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace ToggleSlider
{
    public partial class ToggleSliderComponent : UserControl
    {
        public ToggleSliderComponent()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Click += ToggleSlider_Click;
            timer1.Tick += Timer1_Tick;
            this.AutoSize = true;
        }
        public event EventHandler CheckChanged;

        private bool Checked_bool;
        public bool Checked
        {
            get { return Checked_bool; }
            set { Checked_bool = value; Invalidate(); }
            

        }
        private Color ToggleColorDisabled_Color = Color.Green;
        public Color ToggleCircleColor
        {
            get { return ToggleColorDisabled_Color; }
            set { ToggleColorDisabled_Color = value; Invalidate(); }
        }
        private Color Bar_Color = Color.Gray;
        public Color ToggleColorBar
        {
            get { return Bar_Color; }
            set { Bar_Color = value; Invalidate(); }
        }
        private string Text = "toggleSlider1";
        public string ToggleBarText
        {
            get { return Text; }
            set { Text = value; Invalidate(); }
        }

        private int posx = 0;
        private int posy = 0;
        private bool init_ = true;
        private Color circlecolor_ = new Color();
        private bool animating_ = false;
        protected override void OnPaint(PaintEventArgs pevent)
        {
            if (init_ == true)
            {
                circlecolor_ = ToggleColorDisabled_Color;
            }

            pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Size circle_size = new Size(Convert.ToInt32(Font.SizeInPoints * 5), Convert.ToInt32(Font.SizeInPoints * 5));
            RoundedRect(Bar_Color, pevent.Graphics, new Rectangle((circle_size.Width / 4), ((circle_size.Height / 5) / 2), ((circle_size.Width) / 2), (3 * (circle_size.Height / 5) / 2)), 5);
            System.Drawing.Drawing2D.LinearGradientBrush brush_gradient = new System.Drawing.Drawing2D.LinearGradientBrush(
            new Point((circle_size.Width / 4), ((circle_size.Height / 5) / 2)),
            new Point(circle_size.Width / 2, circle_size.Height / 2),
            ToggleColorDisabled_Color,
            ToggleColorDisabled_Color
            );
            if (animating_ == false)
            {
                if (!Checked_bool)
                {
                    posx = 0;
                }
                else
                {
                    posx = ((circle_size.Width) / 2);
                }
            }

            pevent.Graphics.FillEllipse(new SolidBrush(ToggleColorDisabled_Color), posx, posy, circle_size.Width / 2, circle_size.Height / 2);
            TextRenderer.DrawText(pevent.Graphics, ToggleBarText, this.Font, new Point(circle_size.Width, circle_size.Height / 10), this.ForeColor);

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);


        }


        private void ToggleSlider_Click(object sender, EventArgs e)
        {
            Animate();
            
        }
        private Timer timer1 = new Timer();
        private void Animate()
        {
            timer1.Interval = 1;
            timer1.Start();
            animating_ = true;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Size circle_size = new Size(Convert.ToInt32(Font.SizeInPoints * 5), Convert.ToInt32(Font.SizeInPoints * 5));
            if (Checked_bool == true)
            {
                if (!(posx <= 0))
                {
                    posx -= 3;
                    this.Invalidate();
                }
                else
                {
                    Checked_bool = false;
                    animating_ = false;
                    if (this.CheckChanged != null)
                        this.CheckChanged(this, e);
                    timer1.Stop();
                }
            }
            else
            {
                init_ = false;
                if (!(posx >= ((circle_size.Width) / 2)))
                {
                    posx += 3;
                    this.Invalidate();
                }
                else
                {
                    Checked_bool = true;
                    animating_ = false;
                    if (this.CheckChanged != null)
                        this.CheckChanged(this, e);
                    timer1.Stop();
                }
            }
        }
        public static GraphicsPath RoundedRect(Color c, Graphics g, Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            g.FillPath(new SolidBrush(c), path);
            path.CloseFigure();
            return path;
        }
    }
}
