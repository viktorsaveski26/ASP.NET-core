using EShop.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EShop.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Users>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Concert> Concerts { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
