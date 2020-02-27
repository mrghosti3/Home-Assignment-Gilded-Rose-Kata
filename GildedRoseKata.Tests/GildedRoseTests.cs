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
            app.UpdateQuality();

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
            app.UpdateQuality();
            app.UpdateQuality();

            //Assert
            Assert.IsTrue(agedBrie[0].Quality == 2);
        }
    }
}
