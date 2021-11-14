namespace ShoppingBasket.Test
{
    public class Item
    {
        public int Quantity { get; }
        public double Price { get; }

        public Item(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double Subtotal()
        {
            return this.Quantity * this.Price;
        }
    }
}