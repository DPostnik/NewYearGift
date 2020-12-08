using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewYearGift.model.gift;
using NewYearGift.model.sweets;
using NewYearGift.model.sweets.candy;

namespace NewYearGift.service
{
    interface IGiftService
    {
        List<Candy> GetCandiesBySugarRange(int min, int max, Gift gift); //gift
        IOrderedEnumerable<Sweet> SortSweetsByName(Gift gift);
        IOrderedEnumerable<Sweet> SortSweetsByPrice(Gift gift);
        IOrderedEnumerable<Sweet> SortSweetsByWeight(Gift gift);

    }
}
