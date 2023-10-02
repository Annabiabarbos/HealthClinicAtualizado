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
    public class ComentariosController : ControllerBase
    {
        private readonly ComentariosRepository _comentariosRepository;
        
        public ComentariosController()
        {
            _comentariosRepository = new ComentariosRepository();
        }


        [HttpPost]
        public IActionResult Post(Comentarios comentarios)
        {
            try
            {
                _comentariosRepository.Cadastrar(comentarios);
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
               _comentariosRepository.Deletar(id);
                return Ok();
            }
            catch (Exception e )
            {

                return BadRequest(e.Message);
            }
        }
    }
}
