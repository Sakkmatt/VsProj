using VsProj.Models;
using VsProj.Persistence;

namespace VsProj.Services
{
    public class PartnerService : IPartnerService
    {
        private readonly VsDbContext _context;

        public PartnerService(VsDbContext context)
        {
            _context = context;
        }

        public List<PartnerInfo> GetPartnerInfos()
        {
            return _context.PartnerInfos
                .ToList();
        }
    }
}
