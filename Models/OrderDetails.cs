namespace E_Commerce.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }

    }
}
