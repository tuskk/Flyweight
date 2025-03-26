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
                case ShapeType.Crescent_FILL:
                    return new Crescent(x, y, width, height, color, true);
                  case ShapeType.Crescent_NOFILL:
                    return new Crescent(x, y, width, height, color, false);
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }
}