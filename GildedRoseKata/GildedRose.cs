using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        /* I rewrote the whole function as it was to complicated to analyze.
         * 
         * There are no calculations for Sulfuras, because there quality doesn't change
         * but if the item is not any of other item specified in the requirements and especialy Sulfuras
         * it will most definetly normal item.
         */
        public void UpdateQuality(int day)
        {
            for (int i = 0; i < Items.Count; ++i)
            {
                if (Items[i].Name == "Aged Brie")
                {
                    if (Items[i].Quality < 50)
                    {
                        if (Items[i].SellIn < day)
                        {
                            Items[i].Quality += 2;
                        }
                        else
                        {
                            ++Items[i].Quality;
                        }
                    }
                    else
                    {
                        Items[i].Quality = 50;
                    }
                }
                else if (Items[i].Name.StartsWith("Backstage passes"))
                {
                    int daysTillConcert = Items[i].SellIn - day;

                    if (daysTillConcert < 0)
                    {
                        Items[i].Quality = 0;
                    }
                    else if (Items[i].Quality < 50)
                    {
                        if (daysTillConcert <= 5)
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
                    
                    if (Items[i].Quality > 50)
                    {
                        Items[i].Quality = 50;
                    }
                }
                else if (Items[i].Name.StartsWith("Conjured"))
                {
                    if (Items[i].Quality < 0)
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

                    if (Items[i].Quality > 0)
                    {
                        Items[i].Quality = 0;
                    }
                }
                else if (!Items[i].Name.StartsWith("Sulfuras"))
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].SellIn < day)
                        {
                            Items[i].Quality -= 2;
                        }
                        else
                        {
                            --Items[i].Quality;
                        }
                    }

                    if (Items[i].Quality < 0)
                    {
                        Items[i].Quality = 0;
                    }
                }
            }
        }
    }
}
