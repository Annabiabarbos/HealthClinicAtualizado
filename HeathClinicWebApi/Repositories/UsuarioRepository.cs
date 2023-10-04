using HeathClinicWebApi.Context;
using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;
using HeathClinicWebApi.Repositories;
using HeathClinicWebApi.Utils;

namespace HeathClinicWebApi.Repositories
     
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthContext _healthContext;
        public UsuarioRepository()
        {
            _healthContext = new HealthContext();
        }
        public void Atualizar(Guid id, Usuario usuario)
        {

            Usuario usuarioBuscado = _healthContext.Usuario.Find(id);

            if (usuarioBuscado != null)
            {
                usuarioBuscado.Email = usuario.Email;
                usuarioBuscado.Senha = usuario.Senha;
            }

            _healthContext.Usuario.Update(usuarioBuscado);

            _healthContext.SaveChanges();
        }

        public void Cadastrar(Usuario usuario)
        {
            
            _healthContext.Usuario.Add(usuario);

            _healthContext.SaveChanges();

        }

        public void Deletar(Guid id)
        {
            Usuario usuarioBuscado = _healthContext.Usuario.Find(id);
            _healthContext.Usuario.Remove(usuarioBuscado);
            _healthContext.SaveChanges();


        }
    }

}  
