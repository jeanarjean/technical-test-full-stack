using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using TechnicalTest.Project.Domain;

namespace TechnicalTest.Project.Infrastructure.Repositories
{
    public class HealthFacilityRepository : BaseAbstractRepository<HealthFacility>
    {
        public HealthFacilityRepository(TestDbContext context) : base(context)
        {
        }

        public override async Task<HealthFacility> GetIncludingRelationships(string id)
        {
            return await _context.HealthFacilities.Where(x => x.Id == id)
                .Include(x => x.HealthFacilityServices)
                .FirstAsync();
        }
    }
}