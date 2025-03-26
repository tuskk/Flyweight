namespace Flyweight
{
    internal class Crescent : IShape
    {
        private readonly int x;
        private readonly int y;
        private readonly int width;
        private readonly int height;
        private readonly Color color;
        private readonly bool fill;

        public Crescent(int x, int y, int width, int height, Color color, bool fill)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
            this.fill = fill;
        }

        public void Draw(Graphics g)
        {
            DrawingForm.Instance.Invoke((MethodInvoker)(() => DrawingForm.Instance.ClearMessage()));
            DrawingForm.Instance.Invoke((MethodInvoker)(() => DrawingForm.Instance.ShowMessage("Creating Crescent...")));

            using (SolidBrush brush = new SolidBrush(color))
            {
                if (fill) {
                    g.FillEllipse(brush, x, y, width, height);
                    g.FillEllipse(new SolidBrush(Color.White), x + width / 4, y, width, height);
                } else {
                    g.DrawEllipse(new Pen(color), x, y, width, height);
                    g.DrawEllipse(new Pen(Color.White), x + width / 4, y, width, height);
                }
            }
        }
    }
}