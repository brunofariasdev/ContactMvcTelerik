using Contact.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ContactModel>? Contacts { get; set; } 

        
    }
}
