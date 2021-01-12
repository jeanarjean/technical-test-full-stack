using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Project.Infrastructure.Repositories;

namespace TechnicalTest.Project.Controllers
{
    public class BaseAbstractController<T> : ControllerBase
    {
        protected readonly IRepository<T> _repository;

        public BaseAbstractController(IRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            var test = await _repository.GetIncludingRelationships(id);
            return new OkObjectResult(await _repository.GetIncludingRelationships(id));
        }

        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            return new OkObjectResult(await _repository.ListAsync(x => true));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(T entity)
        {
            if (await _repository.CreateAsync(entity) != null)
                return new NoContentResult();
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(T entity)
        {
            if (await _repository.UpdateAsync(entity) != null)
                return new NoContentResult();
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(T entity)
        {
            _repository.Delete(entity);
            return Ok();
        }
    }
}