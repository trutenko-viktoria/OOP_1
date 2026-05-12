using System;

namespace ConsoleLAB3
{
    //Похідний лкас КНИГА
    class Book : PrintedEdition
    {
        private string author;
        private int pages;
        private int circulation; //тираж

        public Book(string title, double baseCost, string language, string category,
                     string author, int pages, int circulation)
                     : base(title, baseCost, language, category)
        {
            this.author = author;
            this.pages = pages;
            this.circulation = circulation;
        }

        //лаба5 костр без параметрів
        public Book()
    : base()
        {
            author = "Unknown";
            pages = 0;
            circulation = 0;
        }

        //лаба 5 констр для копіювання
        public Book(Book other)
    : base(other)
        {
            author = other.author;
            pages = other.pages;
            circulation = other.circulation;
        }

        //ЛАБА 5 обрахунок вартості
        public override double CalculateTotalCost(
    int copies,
    int pages,
    double pageCost,
    double coverCoefficient,
    double formatCoefficient,
    double colorCoefficient)
        {
            double baseCost = base.CalculateTotalCost(
                copies,
                pages,
                pageCost,
                coverCoefficient,
                formatCoefficient,
                colorCoefficient);

            // Для книг додаємо +20% через тверду обкладинку
            return baseCost * 1.2;
        }

        //лаба 5 визначити к-сть примірників 
        public override int CalculateCopies(double totalMoney, double oneCopyCost)
        {
            int baseCopies = base.CalculateCopies(totalMoney, oneCopyCost);

            // книга дорожча - трохи менше примірників
            return (int)(baseCopies * 0.9);
        }

        //лаба5 бінарні оператори 

        public override bool Equals(object obj)
        {
            if (obj is Book b)
                return BaseCost == b.BaseCost;

            return false;
        }

        public override int GetHashCode()
        {
            return BaseCost.GetHashCode();
        }
        public static bool operator ==(Book a, Book b)
        {
            return a.BaseCost == b.BaseCost;
        }

        public static bool operator !=(Book a, Book b)
        {
            return a.BaseCost != b.BaseCost;
        }

        public static bool operator >(Book a, Book b)
        {
            return a.BaseCost > b.BaseCost;
        }

        public static bool operator <(Book a, Book b)
        {
            return a.BaseCost < b.BaseCost;
        }

        //лаба5 унарні оператори 
        public static Book operator ++(Book b)
        {
            b.BaseCost *= 1.1; // подорожчання на 10%
            return b;
        }

        public static Book operator --(Book b)
        {
            b.BaseCost *= 0.9; // знижка 10%
            return b;
        }

        public double CalculateRating()
        {
            if (circulation >= 5000) return 5.0; // Суперхіт
            if (circulation >= 4000) return 4.0;   // Популярна
            return 3.0;                          // Маловідома
        }


        public override void DisplayInfo() // Calls PrintedEdition.DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Автор: {author}, Сторінок: {pages}");
            Console.WriteLine($"Наклад: {circulation} прим. Рейтинг: {CalculateRating():F1}");
        }
    }

}
