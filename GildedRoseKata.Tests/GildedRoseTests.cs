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
        public void UpdateQuality_BackstagePasses_UpdateCorrect()
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
        public void UpdateQuality_BackstagePasses2_UpdateCorrect()
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
        public void UpdateQuality_BackstagePasses3_UpdateCorrect()
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
        public void UpdateQuality_BackstagePasses4_UpdateCorrect()
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
    }
}
