using System.ComponentModel.DataAnnotations;

namespace EShop.Web.Models
{
    public class Concert
    {
        [Key]
        public Guid Id { get; set; }
        public string ? ConcertName { get; set; }
        public DateTime ? ConcertDate { get; set; }
        public int ? ConcertPrice { get; set; }
        public string ? ConcertPlace { get; set; }
        public ICollection<Tickets> ? Tickets { get; set; }
    }
}
