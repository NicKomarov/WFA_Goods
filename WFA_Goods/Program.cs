namespace WFA_Goods
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class Goods
    {
        public double Price { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Name { get; set; }
        public DateTime PackingDate { get; set; }
        public string Description { get; set; }
    }

    public class Products : Goods
    {
        public Products(double price, string countryOfOrigin, string name, DateTime packingDate,
                        string description, DateTime expirationDate, int amount, string measure)
        {
            Price = price;
            CountryOfOrigin = countryOfOrigin;
            Name = name;
            PackingDate = packingDate;
            Description = description;
            ExpirationDate = expirationDate;
            Amount = amount;
            Measure = measure;
        }

        public DateTime ExpirationDate;
        public int Amount;
        public string Measure;
    }

    public class Books : Goods
    {
        public Books(double price, string countryOfOrigin, string name, DateTime packingDate,
                     string description, int amountOfPages, string publisher, string authors)
        {
            Price = price;
            CountryOfOrigin = countryOfOrigin;
            Name = name;
            PackingDate = packingDate;
            Description = description;
            AmountOfPages = amountOfPages;
            Publisher = publisher;
            Authors = authors;
        }

        public int AmountOfPages;
        public string Publisher;
        public string Authors;
    }
}

