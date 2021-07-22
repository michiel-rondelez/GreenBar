using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Name = "+25 Strength Gloves", SellIn = 10, Quality = 20, ItemType = ItemType.Default},
                new Item {Name = "Old Camembert", SellIn = 2, Quality = 0, ItemType = ItemType.Camembert},
                new Item {Name = "Superior Elixir of QuickFix", SellIn = 5, Quality = 7, ItemType = ItemType.Default},
                new Item {Name = "Thunderfury, Blessed Blade of the Windseeker", SellIn = 0, Quality = 80, ItemType = ItemType.Legendary},
                new Item {Name = "Thunderfury, Blessed Blade of the Windseeker", SellIn = -1, Quality = 80, ItemType = ItemType.Legendary},
                new Item
                {
                    Name = "VIP passes to Yesterdayland concert",
                    SellIn = 15,
                    Quality = 20,
                    ItemType = ItemType.VIPPasses
                },
                new Item
                {
                    Name = "VIP passes to Yesterdayland concert",
                    SellIn = 10,
                    Quality = 49,
                    ItemType = ItemType.VIPPasses
                },
                new Item
                {
                    Name = "VIP passes to Yesterdayland concert",
                    SellIn = 5,
                    Quality = 49,
                    ItemType = ItemType.VIPPasses
                },
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6, ItemType = ItemType.Conjured}
            };

            var app = new GreenBar(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
