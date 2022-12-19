using Microsoft.EntityFrameworkCore;
using VsProj.Models;

namespace VsProj.Persistence
{
    public class VsDbContext : DbContext
    {
        public VsDbContext(DbContextOptions<VsDbContext> options)
            : base(options)
        {

        }

        public DbSet<PartnerInfo> PartnerInfos { get; set; }
        
    }
}
