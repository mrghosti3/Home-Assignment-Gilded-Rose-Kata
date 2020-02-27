using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseKata.Tests
{
    [TestClass]
    public class GildedRoseTests
    {
        [TestMethod]
        public void UpdateQuality_AgedBrie_UpdateCorrect()
        {
            // Init
            IList<Item> agedBrie = new List<Item>()
            {
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 }
            };
            GildedRose app = new GildedRose(agedBrie);

            //Action
            app.UpdateQuality(0);

            //Assert
            Assert.IsTrue(agedBrie[0].Quality == 1);
        }

        [TestMethod]
        public void UpdateQuality_AgedBrieX2_UpdateCorect()
        {
            // Init
            IList<Item> agedBrie = new List<Item>()
            {
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 }
            };
            GildedRose app = new GildedRose(agedBrie);

            //Action
            app.UpdateQuality(0);
            app.UpdateQuality(0);

            //Assert
            Assert.IsTrue(agedBrie[0].Quality == 2);
        }

        [TestMethod]
        public void UpdateQuality_BackstagePasses_MoreThan10DaysToConcert()
        {
            //Arrange
            IList<Item> backstagePass = new List<Item>()
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }
            };
            GildedRose app = new GildedRose(backstagePass);

            //Action
            app.UpdateQuality(2);

            //Assert
            Assert.IsTrue(backstagePass[0].Quality == 21);
        }

        [TestMethod]
        public void UpdateQuality_BackstagePasses_10DaysToConcert()
        {
            //Arrange
            IList<Item> backstagePass = new List<Item>()
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }
            };
            GildedRose app = new GildedRose(backstagePass);

            //Action
            app.UpdateQuality(5);

            //Assert
            Assert.IsTrue(backstagePass[0].Quality == 22);
        }

        [TestMethod]
        public void UpdateQuality_BackstagePasses_5DaysToConcert()
        {
            //Arrange
            IList<Item> backstagePass = new List<Item>()
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }
            };
            GildedRose app = new GildedRose(backstagePass);

            //Action
            app.UpdateQuality(10);

            //Assert
            Assert.IsTrue(backstagePass[0].Quality == 23);
        }

        [TestMethod]
        public void UpdateQuality_BackstagePasses_AfterConcert()
        {
            //Arrange
            IList<Item> backstagePass = new List<Item>()
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }
            };
            GildedRose app = new GildedRose(backstagePass);

            //Action
            app.UpdateQuality(16);

            //Assert
            Assert.IsTrue(backstagePass[0].Quality == 0);
        }

        [TestMethod]
        public void UpdateQuality_Conjured_BeforeSellIn()
        {
            // Init
            IList<Item> agedBrie = new List<Item>()
            {
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
            GildedRose app = new GildedRose(agedBrie);

            //Action
            app.UpdateQuality(1);

            //Assert
            Assert.IsTrue(agedBrie[0].Quality == 4);
        }

        [TestMethod]
        public void UpdateQuality_Conjured_AfterSellIn()
        {
            // Init
            IList<Item> agedBrie = new List<Item>()
            {
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
            GildedRose app = new GildedRose(agedBrie);

            //Action
            app.UpdateQuality(4);

            //Assert
            Assert.IsTrue(agedBrie[0].Quality == 2);
        }

        [TestMethod]
        public void UpdateQuality_Sulfuras_OnSellIn()
        {
            // Init
            IList<Item> agedBrie = new List<Item>()
            {
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}
            };
            GildedRose app = new GildedRose(agedBrie);

            //Action
            app.UpdateQuality(0);

            //Assert
            Assert.IsTrue(agedBrie[0].Quality == 80);
        }

        [TestMethod]
        public void UpdateQuality_Sulfuras_AfterSellIn()
        {
            // Init
            IList<Item> agedBrie = new List<Item>()
            {
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 50}
            };
            GildedRose app = new GildedRose(agedBrie);

            //Action
            app.UpdateQuality(4);

            //Assert
            Assert.IsTrue(agedBrie[0].Quality == 50);
        }

        [TestMethod]
        public void UpdateQuality_NormalItem_BeforeSellIn()
        {
            // Init
            IList<Item> agedBrie = new List<Item>()
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
            };
            GildedRose app = new GildedRose(agedBrie);

            //Action
            app.UpdateQuality(1);

            //Assert
            Assert.IsTrue(agedBrie[0].Quality == 4);
        }

        [TestMethod]
        public void UpdateQuality_NormalItem_AfterSellIn()
        {
            // Init
            IList<Item> agedBrie = new List<Item>()
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
            };
            GildedRose app = new GildedRose(agedBrie);

            //Action
            app.UpdateQuality(11);

            //Assert
            Assert.IsTrue(agedBrie[0].Quality == 2);
        }
    }
}
