#nullable disable
using DemoApartment.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace DemoApartment.Models
{
    public class Bill : BaseEntity
    {
        // ***** enums ***** //
        public BillType BillType { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        public decimal AmountPayable { get; set; }
        public bool IsPaid { get; set; } = false;
        public DateTime DueDate { get; set; }

        // ***** many apartments ***** //
        public List<Apartment_Bill> Apartments_Bills { get; set; }
    }
}
