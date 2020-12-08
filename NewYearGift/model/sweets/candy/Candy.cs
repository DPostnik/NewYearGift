using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.model.sweets.candy
{
    [Serializable]
    public class Candy : Sweet
    {
        public double PercentageOfSugar { get; set; }
        public Filling Filling { get; set; }

        protected Candy(){}
        public Candy(double weight, int calories, string name, double priceForKg, double percentageOfSugar, Filling filling) : base(weight, calories, name, priceForKg)
        {
            this.PercentageOfSugar = percentageOfSugar;
            this.Filling = filling;
        }

        public override string GetInfo()
        {
            return "this is Candy " + this.Name + " Weight: " + this.Weight;
        }
    }
}
