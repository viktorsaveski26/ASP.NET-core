using Microsoft.AspNetCore.Identity;

namespace EShop.Web.Models
{
    public class Users : IdentityUser
    {
        public string ? FirstName { get; set; }
        public string ? LastName { get; set; }
        public string ? Address { get; set; }
        public ICollection<Tickets> ? Tickets { get; set; }
    }
}
