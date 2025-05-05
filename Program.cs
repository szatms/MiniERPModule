namespace miniERPModule
{
    internal partial class Program
    {
        static void Main(string[] args){
            #region Greeting
            Console.WriteLine("Demo of a mini ERP module\nFeatures of this demo:");
            Console.WriteLine("\t#Registering a new order");
            Console.WriteLine("\t#Adding a new product to an existing order");
            Console.WriteLine("\t#Updating the status of an existing order");

            Console.Write("\nPress any buttons to start demo!");
            Console.ReadKey();
            Console.Clear();
            #endregion

            //NOTE TO VIEWER: #Proper input handling will be implemented in the future or will be demonstrated in an other poject 
            //                #Patchwork error and crash prevention is in full effect.


            #region Demo
            Menu menu = new Menu();
            int choice = 0;
            var orders = new List<Order>();

            while (true)
            {
                menu.greeting();

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > 5) {
                        Console.WriteLine("Invalid input: not a valid option!\nPress any key to try again.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine($"Invalid input: {ex.Message}!\nPress any key to try again.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (choice){
                    case 1:
                        menu.creation(orders);
                        break;
                    case 2:
                        menu.view(orders);
                        break;
                    case 3:
                        menu.edit(orders);
                        break;
                    case 4:
                        menu.deletion(orders);
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        System.Environment.Exit(0);
                        break;
                }
                Console.WriteLine("\nAction completed succesfully. Press any key to continue!");
                Console.ReadKey();
                Console.Clear();
            }
            #endregion

        }
    }
}
