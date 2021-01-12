using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Project.Domain;
using TechnicalTest.Project.Infrastructure.Repositories;

namespace TechnicalTest.Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthFacilityController : BaseAbstractController<HealthFacility>
    {
        public HealthFacilityController(IRepository<HealthFacility> repository) : base(repository)
        {
        }
    }
}