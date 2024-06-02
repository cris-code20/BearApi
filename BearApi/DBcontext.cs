using BearApi.Model;
using Microsoft.EntityFrameworkCore;

namespace BearApi
{
    public class DBcontext : DbContext
    {
        public DbSet<Bear> bears {  get; set; }
        
        public DBcontext(DbContextOptions<DBcontext> options) : base(options) { }
    }
}
