

namespace miniERPModule
{
    internal partial class Program
    {
        class Order
        {
            private int id;
            private int customerId;
            private string title;
            private string status;
            private ArrayList products = new ArrayList();

            public Order(string data, ArrayList products)
            {
                string[] tmp = data.Split(';');
                this.id = Convert.ToInt32(tmp[0]);
                this.customerId = Convert.ToInt32(tmp[1]);
                this.title = tmp[2];
                this.status = tmp[3];
                this.products = products;
            }

            #region getters and setters
            public int Id{ get { return id; } set { id = value; } }

            public int CustomerId{ get { return customerId; } set { customerId = value; } }

            public string Title{ get { return title; } set { title = value; } }

            public string Status{ get { return status; } set { status = value; } }

            public ArrayList Products{ get { return products; } set { products = value; } }
            #endregion

            public void addProd(Product product) { this.products.Add(product); }

            public void removeProd(Product product) { this.products.Remove(product); }

            public int getOrderPrice() {
                int sum = 0;

                foreach (Product product in this.products) {
                    product.Price += sum;
                }
                
                return sum;
            }

            public override string ToString(){
                return $"Order ID:\t{this.id}\nCustomer ID:\t{this.customerId}\nTitle:\t{this.title}\nSTATUS:\t{this.status}";
            }
        }
    }
}
