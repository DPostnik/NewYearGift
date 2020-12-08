using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift.model.sweets.waffle
{
    [Serializable]
    public class Waffle: Sweet
    {
        public Type Type { get; set; }
        public bool IsFilling { get; set; }
        
        private Waffle(){}

        public Waffle(double weight, int calories, string name, double priceForKg, Type type, bool isFilling) : base(weight, calories, name, priceForKg)
        {
            this.Type = type;
            this.IsFilling = isFilling;
        }

        public override string GetInfo()
        {
            return "this is Waffle " + this.Name + " Weight: " + this.Weight;
        }
    }
}
