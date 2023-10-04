using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;
using HeathClinicWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace HeathClinicWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ClinicaController : ControllerBase
    {
        private readonly IClinicaRepository _clinicaRepository;

        public ClinicaController()
        {
            _clinicaRepository= new ClinicaRepository();
        }


        [HttpPost]
        public IActionResult Post (Clinica clinica)
        {
            try
            {
                _clinicaRepository.Cadastrar(clinica);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete (Guid id)
        {
            try
            {
                _clinicaRepository.Deletar(id);
                return Ok ();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(Guid id, Clinica clinica)
        {
            try
            {
               
                _clinicaRepository.Atualizar(id, clinica);

                return NoContent();
                
               
            }
            catch (Exception e)
            {

               return BadRequest(e.Message);
            }
        }
    }
}
