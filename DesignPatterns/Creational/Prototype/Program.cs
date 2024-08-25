using System.Threading.Channels;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Circle
            {
                Radius = 5,
                X = 2,
                Y = 3,
                Border = new Border
                {
                    Color = "Red",
                    Size = "2px"
                }
            };

            var c2 = c1.ShallowCLone();

            Console.WriteLine(ReferenceEquals(c1, c2));
            Console.WriteLine(ReferenceEquals(c1.Border, c2.Border));

            var c3 = c1.DeepClone();

            Console.WriteLine(ReferenceEquals(c1, c3));
            Console.WriteLine(ReferenceEquals(c1.Border, c3.Border));
        }
    }
}
