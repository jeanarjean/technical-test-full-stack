using Microsoft.AspNetCore.Mvc;

using TechnicalTest.Project.Domain;
using TechnicalTest.Project.Infrastructure.Repositories;

namespace TechnicalTest.Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : BaseAbstractController<Service>
    {
        public ServiceController(IRepository<Service> repository) : base(repository)
        {
        }
    }
}