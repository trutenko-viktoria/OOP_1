using System;

namespace ConsoleLAB3
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("LAB 5 DEMONSTRATION\n");

         // передаєио значення через параметри

            Book book = new Book(
                "Лісова пісня",
                180,
                "Українська",
                "Художнє",
                "Леся Українка",
                150,
                3000
            );

            Magazine mag1 = new Magazine(
                "Vogue",
                150,
                "UA",
                "Fashion",
                1,
                2024,
                2000
            );

            Magazine mag2 = new Magazine(
                "Forbes",
                200,
                "UA",
                "Business",
                2,
                2024,
                3000
            );

            Booklet booklet = new Booklet(
                "Promo",
                50,
                "UA",
                "Advertising",
                20,
                1.2
            );


            Console.WriteLine("----- BOOK -----");
            book.DisplayInfo();

            Console.WriteLine("\n----- MAGAZINES -----");
            mag1.DisplayInfo();
            mag2.DisplayInfo();

            Console.WriteLine("\n----- BOOKLET -----");
            booklet.DisplayInfo();

            // COST CALCULATION (virtual/override)

            Console.WriteLine("\n===== COST CALCULATION =====");

            double bookCost = book.CalculateTotalCost(1000, 150, 2, 1.5, 1.2, 1.8);
            Console.WriteLine($"Book cost: {bookCost:F2}");

            double magCost = mag1.CalculateTotalCost(2000, 80, 1.5, 1.2, 1.1, 1.5);
            Console.WriteLine($"Magazine cost: {magCost:F2}");

            double bookletCost = booklet.CalculateTotalCost(5000, 20, 1, 1, 1, 2);
            Console.WriteLine($"Booklet cost: {bookletCost:F2}");

            // COPIES CALCULATION

            Console.WriteLine("\n===== COPIES CALCULATION =====");

            Console.WriteLine("Book copies: " +
                book.CalculateCopies(10000, 50));

            Console.WriteLine("Magazine copies: " +
                mag1.CalculateCopies(10000, 30));

            Console.WriteLine("Booklet copies: " +
                booklet.CalculateCopies(10000, 10));

            // OPERATORS 

            Console.WriteLine("\n===== OPERATORS =====");

            Console.WriteLine("Magazine comparison (mag1 > mag2): " + (mag1 > mag2));

            mag1++;
            Console.WriteLine("Magazine after ++ price: " + mag1.BaseCost);

            mag2--;
            Console.WriteLine("Magazine after -- price: " + mag2.BaseCost);

            booklet = booklet + 10;
            Console.WriteLine("Booklet after +10: " + booklet.BaseCost);

            booklet = booklet - 5;
            Console.WriteLine("Booklet after -5: " + booklet.BaseCost);

            Console.WriteLine("\n===== EQUALITY =====");
            Console.WriteLine("mag1 == mag2: " + (mag1 == mag2));

            Console.WriteLine("\n===== END =====");
            Console.ReadKey();
        }
    }
}