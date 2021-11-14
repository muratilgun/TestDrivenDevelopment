using System.Collections.Generic;
using NUnit.Framework;

namespace ShoppingBasket.Test
{
    public class BasketTest
    {
        [Test]
        public void TotalOfEmptyBasket()
        {
            Basket basket = new Basket(new List<Item>());
            Assert.AreEqual(0.0,basket.Total);
        }
    }
}