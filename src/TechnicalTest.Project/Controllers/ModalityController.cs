using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Project.Domain.Modality;
using TechnicalTest.Project.Infrastructure.Repositories;
using TechnicalTest.Project.Stores;

namespace TechnicalTest.Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModalityController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTask()
        {
            var test= GenericStore.ReadAll<Modality>();
            return new OkObjectResult(test);
        }

    }
}