using Microsoft.AspNetCore.Mvc;
using Practikum.Commen.DTOs;
using Practikum.Services.Interfaces;

namespace Practikum.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;
        public ChildController(IChildService childService)
        {
            _childService = childService;
        }
        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(int id)
        {
            return await _childService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<ChildDTO> Post(ChildDTO child)
        {
            return await _childService.AddAsync(child.Id, child.FName, child.IdentityN, child.BornDate);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childService.DeleteAsync(id);
        }
        [HttpPut]

        public async Task Put(ChildDTO child)
        {
            await _childService.UpdateAsync(child);
        }
    }
}
