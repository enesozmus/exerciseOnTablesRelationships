#nullable disable
using DemoApartment.Models.Common;

namespace DemoApartment.Models
{
    public class Renter : BaseEntity
    {
        public Renter()
        {
            Apartments = new HashSet<Apartment>();
            //Images = new HashSet<Image>();
        }

        public string FullName { get; set; }
        public string IdentityNumber { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsHomeOwner { get; set; } = false;
        public bool IsCarOwner { get; set; } = false;
        public string CarPlate { get; set; }
        //public byte[] PasswordHash { get; set; }
        //public byte[] PasswordSalt { get; set; }
        public bool IsDeleted { get; set; }


        // ***** many apartments ***** //
        public ICollection<Apartment> Apartments { get; set; }

        // ***** Image Part ***** //
        //[NotMapped]
        //public IFormFile[] ImageFiles { get; set; }
        //public ICollection<Image> Images { get; set; }
        //public ChatGroup ChatGroup { get; set; }
    }
}