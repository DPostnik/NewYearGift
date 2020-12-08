using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.model.sweets.fruit
{
    public enum Season
    {
        Winter, Spring, Summer, Fall
    }

    public enum Vitamin
    {
        А, В, С, Е, К, Н, РР,
    }
    public class Fruit: Sweet
    {
        public Season Season { get; set; }
        public Vitamin[] Vitamins { get; set; }

        public Fruit(double weight, int calories, string name, double priceForKg, Season season, Vitamin[] vitamins) : base(weight, calories, name, priceForKg)
        {
            this.Season = season;
            this.Vitamins = vitamins;
        }

        public override string getInfo()
        {
            return "this is Fruit " + this.Name + " Weight: " + this.Weight;
        }
    }
}
