using System;
using System.Collections.Generic;
using System.Text;
using NewYearGift.model.sweets;
using NewYearGift.model.sweets.candy;

namespace NewYearGift.service
{
    interface IGiftService
    {
        List<Candy> getCandiesBySugarRange(int min, int max, List<Sweet> sweets); //gift
        List<Sweet> sortSweetsByName(List<Sweet> sweets);
        List<Sweet> SortSweetsByPrice(List<Sweet> sweets);
        List<Sweet> SortSweetsByWeight(List<Sweet> sweets);

    }
}
