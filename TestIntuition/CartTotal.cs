using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIntuition
{
    public interface ICartTotal
    {
        decimal Calculate(IEnumerable<Product> products, ILocalizationInfo localInfo);
    }

    public interface ILocalizationInfo
    {
        string Country { get; set; }
    }

    public class Product
    {
        Guid Id { get; set; }
        public decimal Price { get; set; }
    }


    public class CartTotal : ICartTotal
    {
        public decimal Calculate(IEnumerable<Product> products, ILocalizationInfo localInfo)
        {
            decimal total = 0.0m;
            //add total of products

            total = products.Sum(x => x.Price);

            total = (localInfo.Country == "us" ? total * 0.05m : total * 0.15m);

            return total;
        }
    }
}
