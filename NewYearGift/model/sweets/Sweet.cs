using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.model.sweets
{
    public abstract class Sweet
    {
        public double PriceForKg { get; set; }
        public double Weight { get; set; }
        public int Calories { get; set; }
        public string Name { get; set; }
        public double TotalPrice { get; set; }

        protected Sweet(double weight, int calories, string name, double priceForKg)
        {
            Weight = weight;
            Calories = calories;
            Name = name;
            PriceForKg = priceForKg;
            CountTotalPrice();
        }

        private void CountTotalPrice()
        {
            this.TotalPrice = PriceForKg * Weight;
        }

        public abstract string getInfo();

    }
}
