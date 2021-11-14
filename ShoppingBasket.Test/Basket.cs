using System.Collections.Generic;

namespace ShoppingBasket.Test
{
    public class Basket
    {
        private readonly List<Item> _items;

        public Basket(List<Item> items)
        {
            _items = items;
        }

        public double Total => _items.Count > 0 ? _items[0].Price : 0;
    }
}