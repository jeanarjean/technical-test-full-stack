using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechnicalTest.Project.Domain;

namespace TechnicalTest.Project.Infrastructure.Repositories
{
    public class PractitionerRepository : BaseAbstractRepository<Practitioner>
    {
        public PractitionerRepository(TestDbContext context) : base(context)
        {
        }

        public override async Task<Practitioner> GetIncludingRelationships(string id)
        {
            return await _context.Practitioners.Where(x => x.Id == id).Include(x => x.HealthFacility)
                .Include(x => x.PractitionerServices)
                .FirstAsync();
        }
    }
}