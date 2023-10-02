using HeathClinicWebApi.Context;
using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;

namespace HeathClinicWebApi.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        
        private readonly HealthContext _healthContext;

        public ClinicaRepository()
        {
            _healthContext = new HealthContext();
        }
       
        public void Atualizar(Guid id, Clinica clinica)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Clinica clinica)
        {
            _healthContext.Clinica.Add(clinica);

            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
