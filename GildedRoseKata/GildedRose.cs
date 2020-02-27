using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        //Data
        IList<Item> Items;

        //Constructor
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        //Methods
        public void UpdateQuality(int day)
        {
            for (int i = 0; i < Items.Count; ++i)
            {
                if (Items[i].Name == "Aged Brie" && Items[i].Quality < 50)
                {
                    ++Items[i].Quality;
                }
                else if (Items[i].Name.StartsWith("Backstage passes"))
                {
                    int daysTillConcert = Items[i].SellIn - day;

                    if (daysTillConcert < 0)
                    {
                        Items[i].Quality = 0;
                    }
                    else if (daysTillConcert <= 5)
                    {
                        Items[i].Quality += 3;
                    }
                    else if (daysTillConcert <= 10)
                    {
                        Items[i].Quality += 2;
                    }
                    else
                    {
                        ++Items[i].Quality;
                    }
                }
                else if (Items[i].Name.StartsWith("Conjured"))
                {
                    if (Items[i].SellIn < day)
                    {
                        Items[i].Quality -= 4;
                    }
                    else
                    {
                        Items[i].Quality -= 2;
                    }
                }
            }
        }
    }
}
