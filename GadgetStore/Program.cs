using System;

namespace GadgetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();

            var products = productService.GetProducts();

            foreach (var item in products)
            {
                Console.WriteLine($"Id: {item.Id}, Description: {item.Description}, Model: {item.Model}, Price: {item.Price} ");
            }

            Console.WriteLine("Input Ids of selected products separated by comma to 10: ");

            var idsString = Console.ReadLine();

            string[] ids = idsString.Split(',');
            int[] idsNumbers = new int[ids.Length];

            for (int i = 0; i < ids.Length; i++)
            {
                idsNumbers[i] = Convert.ToInt32(ids[i]);
            }

            if (idsNumbers.Length > 10)
            {
                Console.WriteLine("Input Ids of selected products separated by comma to 10: ");
                System.Environment.Exit(0);
            }

            productService.SelectProducts(idsNumbers);

            Console.WriteLine($"Your data: ");

            Console.WriteLine($"Enter name: ");
            var name = Console.ReadLine();

            Console.WriteLine($"Enter last name: ");
            var lastName = Console.ReadLine();

            Console.WriteLine($"Enter addres: ");
            var addres = Console.ReadLine();

            Console.WriteLine($"Enter email: ");
            var email = Console.ReadLine();

            Console.WriteLine($"Enter phone: ");
            var phone = Console.ReadLine();

            UserInformation userInformation = new UserInformation
            {
                Name = name,
                LastName = lastName,
                Address = addres,
                Email = email,
                Phone = phone
            };

            NotificationService notificationService = new NotificationService();

            notificationService.Notify(userInformation);
        }
    }
}
