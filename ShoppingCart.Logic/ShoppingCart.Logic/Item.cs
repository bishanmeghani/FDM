namespace Shopping
{
    public class Item
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public int getProductId()
        {
            return ProductId;
        }

        public string getName()
        {
            return Name;
        }

        public double getPrice()
        {
            return Price;
        }

        public int getQuantity()
        {
            return Quantity;
        }
    }
}