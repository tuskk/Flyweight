namespace Flyweight
{
    public partial class DrawingForm : Form
    {
        private readonly int WIDTH = 818;
        private readonly int HEIGHT = 395;
        private static readonly ShapeType[] shapes = { ShapeType.LINE, ShapeType.OVAL_FILL, ShapeType.OVAL_NOFILL, ShapeType.CRESCENT };
        private static readonly Color[] colors = { Color.Red, Color.Green, Color.Orange, Color.Blue };
        private readonly Random rand = new Random();
        private bool stopRequested = false;
        private bool isDrawing = false;
        private List<IShape> shapeList = new List<IShape>();
        public static DrawingForm? Instance;

        public DrawingForm()
        {
            InitializeComponent();
            Instance = this;
            drawTimer.Interval = 2000;
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            if (!stopRequested && shapeList.Count < 20)
            {
                IShape shape = ShapeFactory.GetShape(GetRandomShape(), GetRandomColor(), GetRandomX(), GetRandomY(), GetRandomWidth(), GetRandomHeight());
                shapeList.Add(shape);
                pictrBox.Invalidate();
            }
        }
    }
}