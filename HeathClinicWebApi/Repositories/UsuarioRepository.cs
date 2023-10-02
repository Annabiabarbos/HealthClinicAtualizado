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
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            
            _healthContext.Usuario.Add(usuario);

            _healthContext.SaveChanges();

        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }

}  
