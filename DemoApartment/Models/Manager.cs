#nullable disable
using DemoApartment.Models.Common;

namespace DemoApartment.Models
{
    public class Manager : BaseEntity
    {
        public string FullName { get; set; }
        //public byte[] PasswordHash { get; set; }
        //public byte[] PasswordSalt { get; set; }
    }
}
