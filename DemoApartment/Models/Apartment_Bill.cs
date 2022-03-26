#nullable disable
namespace DemoApartment.Models
{
    public class Apartment_Bill
    {
        public DateTime CreateDate { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public int BillId { get; set; }
        public Bill Bill { get; set; }
    }
}
