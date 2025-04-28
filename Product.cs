namespace miniERPModule
{
    internal partial class Program
    {
        class Product
        {
            private int id;
            private string name;
            private int price;

            public Product(int id, string name, int price) { 
                this.id = id;
                this.name = name;
                this.price = price;
            }

            #region getters and setters
            public int Id { get { return id; } set { id = value; } }
            public string Name { get { return name; } set { name = value; } }
            public int Price { get { return price; } set { price = value; } }
            #endregion

            public override string ToString() {
                return $"Product ID:\t{this.id}\nProduct name:\t{this.Name}\nProduct price:\t{this.price}";
            }
        }
    }
}
