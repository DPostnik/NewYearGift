using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NewYearGift.model.gift;
using NewYearGift.model.sweets;
using NewYearGift.model.sweets.candy;

namespace NewYearGift.service
{
    public class GiftService : IGiftService
    {
        public List<Candy> GetCandiesBySugarRange(int min, int max, Gift gift)
        {
            var candies = new List<Candy>();
            foreach (var sweet in gift.Sweets)
            {
                if (sweet is Candy)
                {
                    Candy candy = (Candy)sweet;
                    if (candy.PercentageOfSugar > min && candy.PercentageOfSugar < max)
                    {
                        candies.Add(candy);
                    }
                }
            }

            return candies;
        }

        public IOrderedEnumerable<Sweet> SortSweetsByName(Gift gift)
        {
            var sweets = gift.Sweets.ToList();
            var sortedSweets = sweets.OrderBy(sweet => sweet.Name);
            return sortedSweets;
        }

        public IOrderedEnumerable<Sweet> SortSweetsByPrice(Gift gift)
        {
            var sweets = gift.Sweets.ToList();
            var sortedSweets = sweets.OrderBy(sweet => sweet.TotalPrice);
            return sortedSweets;
        }

        public IOrderedEnumerable<Sweet> SortSweetsByWeight(Gift gift)
        {
            var sweets = gift.Sweets.ToList();
            var sortedSweets = sweets.OrderBy(sweet => sweet.Weight);
            return sortedSweets;
        }

        public void SerializeGift(Gift gift)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Gift));
            using (FileStream fs = new FileStream("gift.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, gift);
            }
        }

        public Gift DeserializeGift()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Gift));
            Gift gift = null;
            using (FileStream fs = new FileStream("gift.xml", FileMode.OpenOrCreate))
            {
                gift = (Gift)formatter.Deserialize(fs);
            }

            return gift;
        }
    }
}
