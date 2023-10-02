using HeathClinicWebApi.Context;
using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;

namespace HeathClinicWebApi.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly HealthContext _healthContext;

        public TiposUsuarioRepository()
        {
            _healthContext = new HealthContext();
        }
        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            _healthContext.TiposUsuario.Add(tiposUsuario);

            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposUsuario tiposUusarioBuscado = _healthContext.TiposUsuario.Find(id);

            _healthContext.TiposUsuario.Remove(tiposUusarioBuscado);

            _healthContext.SaveChanges();
        }
    }
}

