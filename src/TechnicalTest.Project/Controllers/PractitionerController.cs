using Microsoft.AspNetCore.Mvc;

using TechnicalTest.Project.Domain;
using TechnicalTest.Project.Infrastructure.Repositories;

namespace TechnicalTest.Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PractitionerController : BaseAbstractController<Practitioner>
    {
        public PractitionerController(IRepository<Practitioner> repository) : base(repository)
        {
        }
    }
}