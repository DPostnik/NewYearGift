using System;
using System.Collections.Generic;
using System.Text;
using NewYearGift.model.sweets;

namespace NewYearGift.model.gift
{
    [Serializable]
    public class Gift
    {
        public List<Sweet> Sweets { get; }
        public double Weight { get; set; } = 0;
        public string Name { get; }
        public double Price { get; set; } = 0;

        public Gift(){}
        public Gift(List<Sweet> sweets, string name)
        {
            Name = name;
            Sweets = sweets;
            CountGiftPrice();
            CountGiftWeight();
        }

        private void CountGiftPrice()
        {
            foreach (Sweet sweet in Sweets)
            {
                Price += 1.1 * sweet.TotalPrice;
            }
        }

        private void CountGiftWeight()
        {
            foreach (Sweet sweet in Sweets)
            {

                Weight += sweet.Weight;
            }
        }
    }
}
