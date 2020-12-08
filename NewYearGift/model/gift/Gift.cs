using System;
using System.Collections.Generic;
using System.Text;
using NewYearGift.model.sweets;

namespace NewYearGift.model.gift
{
    class Gift
    {
        public List<Sweet> Sweets { get; }
        public double Weight { get; set; } = 0;
        public string Name { get; }
        public double Price { get; set; } = 0;
        public Gift(List<Sweet> sweets)
        {
            this.Sweets = sweets;
            CountGiftPrice();
            CountGiftWeight();
        }

        private void CountGiftPrice()
        {
            foreach (Sweet sweet in this.Sweets)
            {
                this.Price += 1.1 * sweet.TotalPrice;
            }
        }

        private void CountGiftWeight()
        {
            foreach (Sweet sweet in this.Sweets)
            {

                this.Weight += sweet.Weight;
            }
        }
    }
}
