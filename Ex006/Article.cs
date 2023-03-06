using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class Article
    {
        public string name, description;
        public double price;

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
