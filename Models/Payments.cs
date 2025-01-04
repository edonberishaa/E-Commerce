namespace E_Commerce.Models
{
    public class Payments
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
    }
}
