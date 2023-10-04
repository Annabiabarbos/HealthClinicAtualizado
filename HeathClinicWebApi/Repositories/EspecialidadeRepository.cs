using HeathClinicWebApi.Context;
using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;

namespace HeathClinicWebApi.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepsoitory
    {
        private readonly HealthContext _healthContext;
        public EspecialidadeRepository()
        {
            _healthContext = new HealthContext();
        }
        public void Cadastrar(Especialidade especialidade)
        {
            _healthContext.Especialidade.Add(especialidade);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Especialidade especialidadeBuscada = _healthContext.Especialidade.Find(id);
            _healthContext.Especialidade.Remove(especialidadeBuscada);
            _healthContext.SaveChanges();
        }
    }
}
