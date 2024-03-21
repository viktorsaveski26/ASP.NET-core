using System.ComponentModel.DataAnnotations;

namespace EShop.Web.Models
{
    public class Tickets
    {
        [Key]
        public Guid Id { get; set; }
        public int ? NumberOfPeople { get; set; }

        public Users ? users {  get; set; }
        public Concert ? concert { get; set; }
        public Guid ? ConcertId { get; set; }
    }
}
