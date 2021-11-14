using NUnit.Framework;

namespace CdWarehouse.Test
{
    public class CdWarehoueTests
    {
       public class BuyCdTest
       {
           [Test]
           public void EnoughStock()
           {
               CD cd = new CD(10);
               cd.Buy(1);
               Assert.AreEqual(9,cd.StockCount);
           }
       }
    }

    public class CD
    {
        public CD(int initialStock)
        {
            StockCount = initialStock;
        }

        public int StockCount { get; private set; }

        public void Buy(int quantity)
        {
            StockCount -= quantity;
        }
    }
    //  [Test]
    //        public void CdCreatedWithInitialStock()
    //        {
    //            CD cd = new CD(10);
    //            Assert.AreEqual(10, cd.StockCount);
    //        }
    // public class CD
    // {
    //     public CD(int initialStock)
    //     {
    //         StockCount = initialStock;
    //     }
    //     public double StockCount { get; private set; }
    // }
}