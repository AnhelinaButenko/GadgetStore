using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStore
{
    class NotificationService
    {
        public void Notify(List<Product> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Id: {item.Id}, Description: {item.Description}, Model: {item.Model}, Price: {item.Price} ");
            }

            Console.WriteLine("___");
            var sum = products.Sum(p => p.Price);
     
            Console.WriteLine($"Price: {sum}");
        }

        public int Notify(UserInformation userInformation)
        {
            Random rnd = new Random();

            int specialNumber = rnd.Next(50000, 100000);

            Console.WriteLine($"Your order number: {specialNumber} \nYour order will be with you within 3-5 days. Have a good day! =)");

            return specialNumber;
        }
    }
}
