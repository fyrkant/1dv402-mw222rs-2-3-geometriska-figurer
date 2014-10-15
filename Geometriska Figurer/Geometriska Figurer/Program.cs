using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_Figurer
{   
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop == true)
            {
                // Visa menyn.
                ViewMenu();

                // Låt användaren välja.
                int menuSwitch;
                if (int.TryParse(Console.ReadLine(), out menuSwitch) && menuSwitch >= 0 && menuSwitch < 3)
                {
                    switch (menuSwitch)
                    {
                        case 0:
                            loop = false;
                            continue;
                        case 1:
                            ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                            break;
                        case 2:
                            ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                            break;
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Ange ett heltal mellan 0 och 2.", menuSwitch);
                    Console.ResetColor();
                }

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nTryck ner valfri tangent för att fortsätta.");
                Console.ResetColor();
                Console.WriteLine();
                Console.CursorVisible = false;
                Console.ReadKey(true);
                Console.CursorVisible = true;
                Console.Clear(); 
            }           
        }

        // Privat statisk metod som läser in en figurs längd och bredd, skapar objektet och returnerar en referens till det. 
        private static Shape CreateShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Ellipse)
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("=====================================");
                Console.WriteLine("=             Ellips                =");
                Console.WriteLine("=====================================");
                Console.ResetColor();
                Console.WriteLine();
                Shape myEllipse = new Ellipse(ReadDoubleGreaterThanZero("Ange längd: "), ReadDoubleGreaterThanZero("Ange bredd: "));
                return myEllipse;
            }

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=====================================");
            Console.WriteLine("=             Rektangel             =");
            Console.WriteLine("=====================================");
            Console.ResetColor();
            Console.WriteLine();
            Shape myRectangle = new Rectangle(ReadDoubleGreaterThanZero("Ange längd: "), ReadDoubleGreaterThanZero("Ange bredd: "));
            return myRectangle;
        }

        // Privat statisk metod som returnerar ett värde av typen double som är större än 0.
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double temp;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(prompt);
                Console.ResetColor();

                if (double.TryParse(Console.ReadLine(), out temp) && temp > 0)
                {
                    return temp;
                }
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Fel! Ange ett flyttal större än 0.");
                Console.ResetColor();
            } while (true);
        }

        // Privat statisk metod som presenterar en meny. 
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=====================================");
            Console.WriteLine("=        Geometriska Figurer        =");
            Console.WriteLine("=====================================");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n0. Avsluta.");
            Console.WriteLine("1. Ellips.");
            Console.WriteLine("2. Rektangel.");
            Console.WriteLine("\n=====================================");
            Console.Write("\nAnge menyval [0-2]: ");
            Console.ResetColor();

        }

        // Privat statisk metod som presenterar en figurs detaljer.
        private static void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=====================================");
            Console.WriteLine("=             Detaljer              =");
            Console.WriteLine("=====================================");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine(shape.ToString());
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine();
            
        }

    }
}
