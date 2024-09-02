namespace Graphics_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            int x0 = 50, y0 = 50, xEnd = 200, yEnd = 200;
            DrawDDALine(g, x0, y0, xEnd, yEnd);
        }

        private void DrawDDALine(Graphics g, int x0, int y0, int xEnd, int yEnd)
        {
            int dx = xEnd - x0, dy = yEnd;
            int steps = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);

            float xIncrement = dx / (float)steps;
            float yIncrement = dy / (float)steps;

            float x = x0;
            float y = y0;
            g.FillRectangle(Brushes.Black, x, y, 2, 2);

            for (int k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                g.FillRectangle(Brushes.Black, x, y, 2, 2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            int xc = 470, yc = 180, r = 100;
            DrawMidpointCircle(g, xc, yc, r);
        }

        private void DrawMidpointCircle(Graphics g, int xc, int yc, int r)
        {
            int x = 0, y = r;
            int d = 1 - r;
            CirclePoints(g, xc, yc, x, y);

            while (x < y)
            {
                if (d < 0)
                    d += 2 * x + 3;
                else
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                CirclePoints(g, xc, yc, x, y);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);  // Clear the form before drawing
            int xc = 800, yc = 180, r = 100;
            DrawBresenhamCircle(g, xc, yc, r);
        }

        private void DrawBresenhamCircle(Graphics g, int xc, int yc, int r)
        {
            int x = 0, y = r;
            int d = 3 - 2 * r;
            CirclePoints(g, xc, yc, x, y);

            while (y >= x)
            {
                x++;
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                {
                    d = d + 4 * x + 6;
                }
                CirclePoints(g, xc, yc, x, y);
            }
        }

        private void CirclePoints(Graphics g, int xc, int yc, int x, int y)
        {
            g.FillRectangle(Brushes.Black, xc + x, yc + y, 2, 2);
            g.FillRectangle(Brushes.Black, xc - x, yc + y, 2, 2);
            g.FillRectangle(Brushes.Black, xc + x, yc - y, 2, 2);
            g.FillRectangle(Brushes.Black, xc - x, yc - y, 2, 2);
            g.FillRectangle(Brushes.Black, xc + y, yc + x, 2, 2);
            g.FillRectangle(Brushes.Black, xc - y, yc + x, 2, 2);
            g.FillRectangle(Brushes.Black, xc + y, yc - x, 2, 2);
            g.FillRectangle(Brushes.Black, xc - y, yc - x, 2, 2);
        }
    }
}

