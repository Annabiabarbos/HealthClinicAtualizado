using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;
using HeathClinicWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeathClinicWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PacienteController : ControllerBase
    {

        private readonly IPacienteRepository _pacienteRepository;

        public PacienteController()
        {
            _pacienteRepository = new PacienteRepository();
        }

        [HttpPost]
        public IActionResult Post (Paciente paciente)
        {
            try
            {
                _pacienteRepository.Cadastrar(paciente);
                return StatusCode(201);

            }
            catch (Exception e )
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Deletar(Guid Id)
        {
            try
            {
                _pacienteRepository.Deletar(Id);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        
    }
}
