namespace miniERPModule
{
    internal partial class Program {
        class Menu
        {

            public Menu() { }
            public void greeting()
            {
                Console.WriteLine("Welcome to order processing! Select an option with a number to start operations!");
                Console.WriteLine("\t#1.) Create a new order.");
                Console.WriteLine("\t#2.) View an existing order.");
                Console.WriteLine("\t#3.) Edit an existing order.");
                Console.WriteLine("\t#4.) Delete an existing order.");
                Console.WriteLine("\t#5.) EXIT.");
            }

            public void creation(ArrayList orders)
            {
                string tmp = "";
                int n = 0;
                string tmpProd = "";
                string[] tmpArr;
                ArrayList products = new ArrayList();

                Console.WriteLine("To create a new order, enter the correct data!");

                Console.Write("\nOrder ID: ");
                tmp += Console.ReadLine() + ";";
                Console.Write("\nCustomer ID: ");
                tmp += Console.ReadLine() + ";";
                Console.Write("\nTitle: ");
                tmp += Console.ReadLine() + ";";
                Console.Write("\nStatus: ");
                tmp += Console.ReadLine();
                Console.Write("\nNumber of products: ");

                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.Write("\nProduct ID: ");
                    tmpProd = string.Concat(Console.ReadLine() + ";");
                    Console.Write("\nProduct name: ");
                    tmpProd = string.Concat(tmpProd + Console.ReadLine() + ";");
                    Console.Write("\nProduct price: ");
                    tmpProd = string.Concat(tmpProd + Console.ReadLine());

                    tmpArr = tmpProd.Split(';');
                    products.Add(new Product(Convert.ToInt32(tmpArr[0]), tmpArr[1], Convert.ToInt32(tmpArr[2])));
                    tmpProd = "";
                }
                orders.Add(new Order(tmp,products));
            }

            public void view(ArrayList orders)
            {

            }

            public void deletion(ArrayList orders)
            {

            }

            public void edit(ArrayList orders)
            {

            }
        }
    }
}
