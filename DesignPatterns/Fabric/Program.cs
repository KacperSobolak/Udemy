namespace Fabric
{
    class Program
    {
        public static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();

            var circle = shapeFactory.CreateShape(ShapeType.Circle);
        }
    }

}