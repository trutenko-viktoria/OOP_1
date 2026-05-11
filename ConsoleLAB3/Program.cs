using System;

namespace ConsoleLAB3
{
    //базовий клас
    class PrintedEdition
    {
        //закриті загальні поля
        private string title; //з малої бо це внутрішн поле
        private double baseCost;
        private string language;
        private string category; 

        //властивості для доступу (аксесори) 
        public string Title //з великої бо це властивість, зовнішня оболочка
        {
            get => title;
            set
            {
                // Перевірка на порожній рядок
                if (!string.IsNullOrWhiteSpace(value))
                    title = value;
                else
                    Console.WriteLine("eror! it can not be empty");
            }
        }

        public double BaseCost
        {
            get => baseCost;
            set
            {
                // Вартість не може бути від'ємною
                if (value >= 0)
                    baseCost = value;
                else
                    Console.WriteLine("Eror. it must be positive!");
            }
        }

        //тут вже без перевірок, але їх теж можна додати 
        public string Language { get => language; set => language = value; }
        public string Category { get => category; set => category = value; }

        //конструктор базового класу з параметрами
        public PrintedEdition(string title, double baseCost, string language, string category)
        {
            Title = title; 
            BaseCost = baseCost;
            Language = language;
            Category = category;
        }

        //метод розрахунку вартості (базова ціна + 20 % вартості)
        public virtual double CalculateTotalCost()
        {
            double paperWork = baseCost * 0.4;        // 40% paper
            double printingWork = baseCost * 0.4;     // 40% polygraphy
            double taxes = (paperWork + printingWork) * 0.2; // 20% tax
            return paperWork + printingWork + taxes;
        }

        public virtual void DisplayInfo()
        {
            //використовую $ (інтерполяцію рядків)
            Console.WriteLine($"\nВидання: {title}");
            Console.WriteLine($"Категорія: {category}, Мова: {language}");
            Console.WriteLine($"Ціна з податками: {CalculateTotalCost():F2} грн"); //F2 - форматування чисел. 2 цифри після коми
        }
    }

    //Похідний лкас КНИГА
    class Book : PrintedEdition
    {
        private string author;
        private int pages;
        private int circulation; //тираж

        public Book (string title, double baseCost, string language, string category,
                     string author, int pages, int circulation)
                     : base(title, baseCost, language, category)
        {
            this.author = author;
            this.pages = pages;
            this.circulation = circulation;
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

    class Magazine : PrintedEdition
    {
        private int issueNumber;
        private int year;
        private int salesCount;

        //аксесори
        public int IssueNumber { get => issueNumber; set => issueNumber = value; }
        public int Year { get => year; set => year = value; }
        public int SalesCount { get => salesCount; set => salesCount = value; }

        //конструктор 
        public Magazine(string title, double baseCost, string language, string category,
                        int issueNumber, int year, int salesCount)
            : base(title, baseCost, language, category)
        {
            this.issueNumber = issueNumber;
            this.year = year;
            this.salesCount = salesCount;
        }

        //розрахунок рейтингу 
        public double CalculateRating()
        {
            if (salesCount > 2000) return 5.0;
            if (salesCount > 1500) return 4.0   ;
            else return 3.0;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Номер: {issueNumber}, Рік: {year}");
            Console.WriteLine($"Продажі: {salesCount}. Рейтинг: {CalculateRating()}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            // 1. Створюємо нормальну книгу
            Book myBook = new Book("Лісова пісня", 180, "Українська", "Художнє", "Леся Українка", 150, 3000);
            myBook.DisplayInfo();

            // 2. Створюємо журнал з помилковими даними для перевірки set
            Magazine myMag = new Magazine("Наука сьогодні", 10, "Українська", "Наукове", 5, 2024, 500);
            // Оскільки ціна була -10, set її не прийняв, і залишиться дефолтне 0.
            myMag.DisplayInfo();

            Console.ReadKey();
        }
    }
}
 