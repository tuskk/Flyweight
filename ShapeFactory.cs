namespace Flyweight
{
    public static class ShapeFactory
    {
        public static IShape GetShape(ShapeType type, Color color, int x, int y, int width, int height)
        {
            switch (type)
            {
                case ShapeType.LINE:
                    return new Line(x, y, x + width, y + height, color);
                case ShapeType.OVAL_FILL:
                    return new Oval(x, y, width, height, color, true);
                  case ShapeType.OVAL_NOFILL:
                    return new Oval(x, y, width, height, color, false);
                case ShapeType.CRESCENT:
                    return new Crescent(x, y, width, height, color);
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }
}