using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.model.sweets.fruit
{
    [Serializable]
    public class Fruit: Sweet
    {
        public Season Season { get; set; }
        public Vitamin Vitamin { get; set; }
        private Fruit(){}

        public Fruit(double weight, int calories, string name, double priceForKg, Season season, Vitamin vitamin) : base(weight, calories, name, priceForKg)
        {
            this.Season = season;
            this.Vitamin = vitamin;
        }

        public override string GetInfo()
        {
            return "this is Fruit " + this.Name + " Weight: " + this.Weight;
        }
    }
}
