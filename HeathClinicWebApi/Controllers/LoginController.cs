using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;
using HeathClinicWebApi.Repositories;
using HeathClinicWebApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeathClinicWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
       private readonly IUsuarioRepository _usuarioRepository;

       public LoginController()
        {
         _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel usuario)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmailESenha(usuario.Email!, usuario.Senha!);

                if (usuarioBuscado == null)
                {

                    return StatusCode(401, "Email ou senha invalidos!");
                }
            }
              
        }

    }
}


