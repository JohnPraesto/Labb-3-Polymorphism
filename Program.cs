namespace Labb_3_Polymorphism
{
    ///////////////////////////////////////////////////////////
    /////////////////  JOHN PRAESTO SUT-23  ///////////////////
    ///////////////////////////////////////////////////////////
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ange sida ett på rektangel: ");
                double side1 = Converter();

                Console.Write("Ange sida två på rektangel: ");
                double side2 = Converter();
                Geometry rectangle = new Rectangle(side1, side2); // Vad spelar det för roll vilken klass jag inleder med?

                Console.Write("Ange sida på kvadrat: ");
                side1 = Converter();
                Square square = new Square(side1); // Vad blir skillnaden lixom?

                Console.Write("Ange diameter på cirkel: ");
                side1 = Converter();
                side1 = side1 / 2;
                Geometry circle = new Circle(side1);

                Console.WriteLine("\nArea of rectangle: " + rectangle.Area());
                Console.WriteLine("Area of square: " + square.Area());
                Console.WriteLine("Area of circle: " + circle.Area());

                Console.ReadLine();
                Console.Clear();
            }
        }

        public static double Converter()
        {
            double side = 0;
            while (true)
            {
                string userInput = Console.ReadLine();
                try
                {
                    side = double.Parse(userInput);
                    break;
                }
                catch
                {
                    Console.WriteLine("Du har matat in ogiltiga tecken. Mata endast in heltal eller decimaltal.");
                }
            }
            return side;
        }
    }
}