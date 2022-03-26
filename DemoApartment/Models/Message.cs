#nullable disable
using DemoApartment.Models.Common;

namespace DemoApartment.Models
{
    public class Message : BaseEntity
    {
        public string Content { get; set; }
        public string CreatedBy { get; set; }
    }
}