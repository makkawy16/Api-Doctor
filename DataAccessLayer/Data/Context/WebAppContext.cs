using DataAccessLayer.Data.Models;
using day2withDB.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace day2withDB.Data.Context.DAL
{
    public class WebAppContext : DbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options): base(options) { }

        public DbSet<Doctor> Doctors { get; set; }
      

    }
}
