using Microsoft.AspNetCore.Mvc;
using Practikum.Commen.DTOs;
using Practikum.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practikum.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        [HttpGet]
        public async Task<List<ClientDTO>> Get()
        {
            return await _clientService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ClientDTO> Get(int id)
        {
            return await _clientService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<ClientDTO> Post(ClientDTO client)
        {
            return await _clientService.AddAsync(client.Id, client.FName, client.LName, client.IdentityN, client.BornDate, client.MorF, client.HMO, client.Children);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _clientService.DeleteAsync(id);
        }
        [HttpPut]
         
        public async Task Put(ClientDTO client)
        {
            await _clientService.UpdateAsync(client);
        }

    }
}
