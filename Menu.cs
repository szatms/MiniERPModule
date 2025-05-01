namespace miniERPModule
{
    internal partial class Program {
        class Menu
        {

            public Menu() { }
            private Product makeProd() {
                string tmpProd = "";

                Console.Write("\nProduct ID: ");
                tmpProd = string.Concat(Console.ReadLine() + ";");
                Console.Write("\nProduct name: ");
                tmpProd = string.Concat(tmpProd + Console.ReadLine() + ";");
                Console.Write("\nProduct price: ");
                tmpProd = string.Concat(tmpProd + Console.ReadLine());

                string[] prop = tmpProd.Split(';');
                return new Product(Convert.ToInt32(prop[0]), prop[1], Convert.ToInt32(prop[2]));
            }
            public void greeting()
            {
                Console.WriteLine("Welcome to order processing! Select an option with a number to start operations!");
                Console.WriteLine("\t#1.) Create a new order.");
                Console.WriteLine("\t#2.) View an existing order.");
                Console.WriteLine("\t#3.) Edit an existing order.");
                Console.WriteLine("\t#4.) Delete an existing order.");
                Console.WriteLine("\t#5.) EXIT.");
            }

            public void creation(List<Order> orders)
            {
                string tmp = "";
                int n = 0;
                List<Product> products = new List<Product>();

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
                    products.Add(makeProd());
                }
                orders.Add(new Order(tmp,products));
            }

            public void listOrders(List<Order> orders) {
                Console.WriteLine($"List of existing order IDs:");
                foreach (Order order in orders)
                {
                    Console.WriteLine($"\t#{order.Id}");
                }
            }

            private void viewProd(List<Order> orders, int idToEdit) {
                Console.WriteLine("List of products attached to order: ");

                for (int i = 0; i < orders[idToEdit].Products.Count; i++)
                {
                    Console.WriteLine($"#{orders[idToEdit].Products[i].ToString()}");
                }
            }

            public void view(List<Order> orders)
            {
                if (orders.Count == 0) {
                    Console.WriteLine("No orders to show!");
                    return;
                }

                listOrders(orders);

                Console.WriteLine("Enter the ID of the order you wish to view: ");
                int orderId = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < orders.Count; i++) {
                    if (orderId == orders[i].Id){
                        Console.WriteLine($"Order details:\n{orders[i].ToString()}");
                        viewProd(orders,i);
                    }
                }
            }

            private void editOrder(List<Order> orders, int idToEdit) {
                while (true)
                {
                    Console.WriteLine("Select an attribute to edit:");
                    Console.WriteLine("\t#1.) Order ID\n\t#2.) Customer ID\n\t#3.) Title\n\t#4.) Status\n\t#5.) Return");
                    int c1 = Convert.ToInt32(Console.ReadLine());

                    switch (c1)
                    {
                        case 1:
                            Console.WriteLine("New order ID: ");
                            orders[idToEdit].Id = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("New customer ID: ");
                            orders[idToEdit].CustomerId = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("New order title: ");
                            orders[idToEdit].Title = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("New order status: ");
                            orders[idToEdit].Status = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Returned!");
                            return;
                    }
                }
            }

            private void delProd(List<Order> orders, int idToEdit) {
                Console.WriteLine("Product by ID to be removed: ");
                int rmP = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < orders[idToEdit].Products.Count; i++)
                {
                    if (orders[idToEdit].Products[i].Id == rmP)
                    {
                        orders[idToEdit].removeProd(orders[idToEdit].Products[i]);
                    }
                }
            }

            public void edit(List<Order> orders)
            {
                listOrders(orders);

                int choice = 0;
                Console.WriteLine("Select an order to edit by order ID: ");
                int idToEdit = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < orders.Count; i++)
                {
                    if (idToEdit == orders[i].Id)
                    {
                        idToEdit = i;
                        break;
                    }
                }

                while (true) {
                    Console.WriteLine("Select options to edit:");
                    Console.WriteLine("\t#1.) Edit Order Properties\n\t#2.) Add products to Order\n\t#3.) Remove products from order\n\t#4.) Return");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice){
                        case 1:
                            editOrder(orders, idToEdit);
                            break;
                        case 2:
                            viewProd(orders, idToEdit);
                            Console.WriteLine("Number of products to add: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < n; i++)
                                orders[idToEdit].addProd(makeProd());
                            break;
                        case 3:
                            viewProd(orders, idToEdit);
                            delProd(orders, idToEdit);
                            break;
                        case 4:
                            return;
                    }
                }
            }

            public void deletion(List<Order> orders)
            {
                Console.WriteLine("Enter the ID of the order you wish to delete: ");
                int orderId = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < orders.Count; i++) {
                    if (orderId == orders[i].Id) { 
                        orders.RemoveAt(i);
                    }
                }
            }

        }
    }
}
