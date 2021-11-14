using NUnit.Framework;

namespace CdWarehouse.Test
{
    public class CdWarehoueTests
    {
       public class BuyCdTest
       {
           [Test]
           public void CdCreatedWithInitialStock()
           {
               CD cd = new CD(10);
               Assert.AreEqual(10, cd.StockCount);
           }
       }
    }

    public class CD
    {
        public CD(int initialStock)
        {
            StockCount = initialStock;
        }
        public double StockCount { get; private set; }
    }
}