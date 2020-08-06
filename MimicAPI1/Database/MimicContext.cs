using Microsoft.EntityFrameworkCore;
using MimicAPI.Models;

namespace MimicAPI1.DateContext
{
    public class MimicContext : DbContext
    {
        public MimicContext(DbContextOptions<MimicContext> options) :base(options)
        {

        }

        public DbSet<WordModels> Word { get; set; }
    }
}
