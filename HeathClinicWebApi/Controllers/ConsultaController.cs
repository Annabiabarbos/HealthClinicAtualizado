using HeathClinicWebApi.Controllers;
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

    public class ConsultaController : ControllerBase
    {
        private readonly ConsultaRepository _consultaRepository;
        

        public ConsultaController()
        {
           _consultaRepository = new ConsultaRepository();
        }

        [HttpPost]
        public IActionResult Post ( Consulta consulta)
        {
            try
            {
                _consultaRepository.Cadastrar(consulta);
                return StatusCode(201);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _consultaRepository.Deletar(id);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest (e.Message);
            }
        }

        [HttpPut]
        public IActionResult Update (Guid id , Consulta consulta)
        {
            try
            {
                _consultaRepository.Atualizar(id, consulta);
                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
