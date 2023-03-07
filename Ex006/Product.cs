using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class Product
    {
        public string name, description, model, brand;
        public double price;

        public string Model { get { return model; } set { model = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public double Price { get { return price; } set { price = value; } }

        public double Calculate_installments(int installments_months)
        {
            if (installments_months == 1)
            {
                return price;
            } else if (installments_months == 2)
            {
                return (price * 1.1) / 2;
            } else if (installments_months == 6)
            {
                return (price * 1.3) / 6;
            } else if (installments_months == 12)
            {
                return (price * 1.5) / 12;
            }


            return 0;
        }
    }
}
