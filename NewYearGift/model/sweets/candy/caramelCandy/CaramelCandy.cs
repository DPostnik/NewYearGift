using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.model.sweets.candy.caramelCandy
{
    [Serializable]
    class CaramelCandy: Candy
    {
        public CaramelShape CaramelShape { get; set; }

        private CaramelCandy(){}
        public CaramelCandy(double weight, int calories, string name, double priceForKg, double percentageOfSugar, Filling filling, CaramelShape caramelShape) : base(weight, calories, name, priceForKg, percentageOfSugar, filling)
        {
            CaramelShape = caramelShape;
        }

        public override string GetInfo()
        {
            return "this is Chocolate Candy " + this.Name + " Weight: " + this.Weight;
        }
    }
}
