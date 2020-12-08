using System;
using System.Collections.Generic;
using NewYearGift.model;
using NewYearGift.model.gift;
using NewYearGift.model.sweets;
using NewYearGift.model.sweets.candy;
using NewYearGift.model.sweets.candy.caramelCandy;
using NewYearGift.model.sweets.candy.chocolateCandy;
using NewYearGift.model.sweets.fruit;
using NewYearGift.model.sweets.waffle;
using NewYearGift.service;
using Type = NewYearGift.model.Type;

namespace NewYearGift
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweet candy = new Candy(1,1,"Аленка", 12,0.5,Filling.Jelly);
            Sweet candy1 = new ChocolateCandy(2,2,"Буренка", 13,1.2,Filling.Nut,1);
            Sweet candy2 = new CaramelCandy(2,2,"Буренка", 13,1.2,Filling.Nut,CaramelShape.Lollipops);
            Sweet sweet = new Waffle(1,15,"Голандские",33,Type.Holland,true);
            Sweet sweet1 = new Fruit(1,312,"Яблоко",12,Season.Fall,Vitamin.А);
            List<Sweet> sweets = new List<Sweet>();
            sweets.Add(sweet);
            sweets.Add(sweet1);
            sweets.Add(candy);
            sweets.Add(candy1);
            sweets.Add(candy2);
            Gift git = new Gift(sweets, "Рождественский");
            GiftService giftService = new GiftService();
            giftService.SerializeGift(git);
        }
    }
}
