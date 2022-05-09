using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_de_fixação.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name +
                " " +
                "(used)" +
                "$ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
