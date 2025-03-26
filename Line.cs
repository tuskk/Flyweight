namespace Flyweight
{
    internal class Line : IShape
    {
        private readonly int x1;
        private readonly int y1;
        private readonly int x2;
        private readonly int y2;
        private readonly Color color;

        public Line(int x1, int y1, int x2, int y2, Color color)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.color = color;
        }

        public void Draw(Graphics g)
        {
            DrawingForm.Instance.Invoke((MethodInvoker)(() => DrawingForm.Instance.ClearMessage()));
            DrawingForm.Instance.Invoke((MethodInvoker)(() => DrawingForm.Instance.ShowMessage("Creating Line...")));
            g.DrawLine(new Pen(color), x1, y1, x2, y2);
        }
    }
}
