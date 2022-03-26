#nullable disable
using DemoApartment.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApartment.Models
{
    public class Apartment : BaseEntity
    {
        public string Block { get; set; }
        public int Floor { get; set; }
        public int DoorNumber { get; set; }
        public bool IsAvailable { get; set; }
        public string Type { get; set; }
        public bool IsOwner { get; set; }
        public bool IsDeleted { get; set; } = false;

        // ***** one renter ***** //
        [ForeignKey("Renter")]
        public int RenterId { get; set; }
        public Renter Renter { get; set; }

        // ***** many bills ***** //
        public List<Apartment_Bill> Apartments_Bills { get; set; }
    }
}
