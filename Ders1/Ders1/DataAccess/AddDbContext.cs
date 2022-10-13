using Ders1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ders1.DataAccess
{
    public class AddDbContext : DbContext
    {
      public  DbSet<Books> books { get; set; }
        public AddDbContext(DbContextOptions <AddDbContext> option) : base(option)
        {

        }
    }
}
