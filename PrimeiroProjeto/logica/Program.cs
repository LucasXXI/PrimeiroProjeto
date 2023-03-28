using PrimeiroProjeto.logica;
using PrimeiroProjeto.poo;
using PrimeiroProjeto.poo.exerciciosClasses;
using PrimeiroProjeto.poo.construtores;
using System.Globalization;
using PrimeiroProjeto.poo.Structs;
using PrimeiroProjeto.vetores;
using PrimeiroProjeto.Entities;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birt date (dd/MM/YYYY): ");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            string status = Console.ReadLine();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            Client client = new Client(name, email, DateTime.Parse(birthDate));
            Order order = new Order(DateTime.Now, Enum.Parse<OrderStatus>(status), client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);

        }
    }
}
