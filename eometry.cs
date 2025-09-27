
using ConsoleAppGeometry.Shape;

namespace ConsoleAppGeometry;

class Program
{
    public static int Main(string[] args)
    {
        string shapeType = Console.ReadLine() ?? string.Empty;
        IShape shape;

        switch(shapeType)
        {
            case "t":
                shape = new Triangle(Utils.ReadPositiveInt());               
                break;
            case "r":
                shape = new Rectangle(Utils.ReadPositiveInt(), Utils.ReadPositiveInt());
                break;
            case "s":
                shape = new Square(Utils.ReadPositiveInt());
                break;
            default:
                Console.WriteLine("Wrong shape type, must be one of: t, r, s");
                return 1;
        }

        shape.Print();

        return 0;
    }
}
