using System;
using System.Collections.Generic;
using System.Text;
using NewYearGift.model.sweets;
using NewYearGift.model.sweets.candy;

namespace NewYearGift.service
{
    public class GiftService : IGiftService
    {
        public List<Candy> getCandiesBySugarRange(int min, int max, List<Sweet> sweets)
        {
            
            List<Candy> candies = new List<Candy>();
            foreach (var sweet in sweets)
            {
                if (sweet is Candy)
                {
                    Candy candy = (Candy) sweet;
                    if (candy.PercentageOfSugar > min && candy.PercentageOfSugar < max)
                    {
                        candies.Add(candy);
                    }
                }
            }

            return candies;
        }

        public List<Sweet> sortSweetsByName(List<Sweet> sweets)
        {
            bool log = false;
            Sweet temp;
            List<Sweet> sortedSweets = sweets;
            while (!log)
            {
                log = true;
                for (int start = 0; start + 1 < sortedSweets.Count; ++start)
                {
                    int compare = sortedSweets[start].Name.CompareTo(sortedSweets[start + 1].Name);
                    if (compare == -1)
                    {
                        log = false;
                        temp = sortedSweets[start];
                        sortedSweets[start] = sortedSweets[start + 1];
                        sortedSweets[start + 1] = temp;
                    }
                }
            }

            return sortedSweets;
        }

        public List<Sweet> SortSweetsByPrice(List<Sweet> sweets)
        {
            bool log = false;
            Sweet temp;
            List<Sweet> sortedSweets = sweets;
            while (!log)
            {
                log = true;
                for (int start = 0; start + 1 < sortedSweets.Count; ++start)
                {
                    if (sortedSweets[start].PriceForKg < sortedSweets[start + 1].PriceForKg)
                    {
                        log = false;
                        temp = sortedSweets[start];
                        sortedSweets[start] = sortedSweets[start + 1];
                        sortedSweets[start + 1] = temp;
                    }
                }
            }

            return sortedSweets;
        }

        public List<Sweet> SortSweetsByWeight(List<Sweet> sweets)
        {
            bool log = false;
            Sweet temp;
            List<Sweet> sortedSweets = sweets;
            while (!log)
            {
                log = true;
                for (int start = 0; start + 1 < sortedSweets.Count; ++start)
                {
                    if (sortedSweets[start].Weight < sortedSweets[start + 1].Weight)
                    {
                        log = false;
                        temp = sortedSweets[start];
                        sortedSweets[start] = sortedSweets[start + 1];
                        sortedSweets[start + 1] = temp;
                    }
                }
            }

            return sortedSweets;
        }
    }
}
