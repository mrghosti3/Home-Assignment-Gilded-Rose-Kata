﻿using System.Collections.Generic;

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
                else if (Items[i].Name.StartsWith("Sulfuras"))
                {
                    //
                }
            }
        }

        /*
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
        */
    }
}
