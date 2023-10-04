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
            Clinica ClinicaBuscada = _healthContext.Clinica.Find(id);

            if (ClinicaBuscada != null)
            {
                ClinicaBuscada.DescricaoClinica = clinica.DescricaoClinica;
                ClinicaBuscada.RazaoSocial = clinica.RazaoSocial;
                ClinicaBuscada.CNPJ = clinica.CNPJ;
                ClinicaBuscada.Endereco = clinica.Endereco;
            }

            _healthContext.Clinica.Update(ClinicaBuscada);

            _healthContext.SaveChanges();
        }

        public void Cadastrar(Clinica clinica)
        {
            _healthContext.Clinica.Add(clinica);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Clinica clinicaBuscada = _healthContext.Clinica.Find(id);
            _healthContext.Clinica.Remove(clinicaBuscada);
            _healthContext.SaveChanges();

        }
    }
}

