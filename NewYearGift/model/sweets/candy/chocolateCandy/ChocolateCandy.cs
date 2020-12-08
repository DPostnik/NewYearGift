using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.model.sweets.candy.chocolateCandy
{
    [Serializable]
    class ChocolateCandy: Candy
    {
        public int PersentageOfCocoa { get; set; }

        private ChocolateCandy(){}
        public ChocolateCandy(double weight, int calories, string name, double priceForKg, double percentageOfSugar, Filling filling, int persentageOfCocoa) : base(weight, calories, name, priceForKg, percentageOfSugar, filling)
        {
            PersentageOfCocoa = persentageOfCocoa;
        }

        public override string GetInfo()
        {
            return "this is Chocolate Candy " + this.Name + " Weight: " + this.Weight;
        }
    }
}
