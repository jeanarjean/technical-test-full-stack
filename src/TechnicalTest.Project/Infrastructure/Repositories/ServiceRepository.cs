﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechnicalTest.Project.Domain;

namespace TechnicalTest.Project.Infrastructure.Repositories
{
    public class ServiceRepository : BaseAbstractRepository<Service>
    {
        public ServiceRepository(TestDbContext context) : base(context)
        {
        }

        public override async Task<Service> GetIncludingRelationships(string id)
        {
            return await _context.Services.Where(x => x.Id == id).Include(x => x.HealthFacilityServices)
                .Include(x => x.PractitionerServices)
                .FirstAsync();
        }
    }
}