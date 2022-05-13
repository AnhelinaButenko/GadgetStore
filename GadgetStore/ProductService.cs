using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStore
{
    class ProductService
    {
        private readonly NotificationService _notificationService;

        public ProductService()
        {
            _notificationService = new NotificationService();
        }


        private List<Product> _products = new List<Product>
        {
             new Product { Id = 1,  Description = "Cool Phone",  Model = "IPhone XI", Price =2000 },
             new Product { Id = 2,  Description = "Beauty Phone",  Model = "IPhone X", Price =2500 },
             new Product { Id = 3,  Description = "Great Phone",  Model = "IPhone XII", Price =2600 },
             new Product { Id = 4,  Description = "Cool Tablet",  Model = "IPhone FN78", Price =2300 },
             new Product { Id = 5,  Description = "Super Watch",  Model = "Samsung 356", Price =1500},
             new Product { Id = 6,  Description = "Great Phone",  Model = "Samsung MN890", Price =900 },
             new Product { Id = 7,  Description = "Cool Phone",  Model = "IPhone VII", Price =1000 },
             new Product { Id = 8,  Description = "Beauty Phone",  Model = "LG 890", Price =1300 },
             new Product { Id = 9,  Description = "Cool Phone",  Model = "Samsung 220G", Price =5000 },
             new Product { Id = 10,  Description = "Smart Watch",  Model = "LG 678DF", Price =4000 },
             new Product { Id = 11,  Description = "Great Tablet",  Model = "Prestigio FL890", Price =1200 },
             new Product { Id = 12,  Description = "Cool Phone",  Model = "IPhone VI", Price =700 },
        };

        private List<Product> _basket = new List<Product>();

        public List<Product> GetProducts()
        {
            return _products;
        }

        public List<Product> SelectProducts(int[] idsNumbers)
        {
            var selectedProducts = _products.Where(p => idsNumbers.Contains(p.Id));
            _basket = selectedProducts.ToList();

            _notificationService.Notify(_basket);
            return _basket;
        }
    }
}
