namespace StoreOfBuild.Domain.Products
{
    public class Product
    {
        public static int Id{get; private set;}
        public static string Name {get; private set;}
        public static Category Category { get;private set; }
        public static decimal Price { get; private set; }
        public static int StockQuantity{get;private set;}


        public Product(string name, Category category, decimal price, int stockQuantity)
        {
            ValidateValues(name, category, price, stockQuantity);
            SetProperties(name, category, price, stockQuantity);
        }

        private static void SetProperties(string name, Category category, decimal price, int stockQuantity)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQuantity;
        }


        private static void ValidateValues(string name, Category category, decimal price, int stockQuantity)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Nome é obrigatorio");
            DomainException.When(category == null, "Categoria é obrigatorio");
            DomainException.When(price < 0, "Preço é obrigatorio");
            DomainException.When(stockQuantity < 0, "Estoque não pode ser negativo");
        }

        public void Update(string name, Category category, decimal price, int stockQuantity)
        {
            ValidateValues(name, category, price, stockQuantity);
            SetProperties(name, category, price, stockQuantity); 
        }
    }
}