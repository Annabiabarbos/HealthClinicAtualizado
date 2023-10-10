using HeathClinicWebApi.Context;
using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;

namespace HeathClinicWebApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext _healthContext;

        public ConsultaRepository()
        {
            _healthContext = new HealthContext();
        }
        public void Atualizar(Guid id, Consulta consulta)
        {
            Consulta consultaBuscada = _healthContext.Consulta.Find(id);

            if(consultaBuscada  != null)
            {
                consultaBuscada.Prontuario = consulta.Prontuario;

                consultaBuscada.DataConsulta = consulta.DataConsulta;
            }

            _healthContext.Consulta.Update(consultaBuscada);

            _healthContext.SaveChanges();
        }

        public void Cadastrar(Consulta consulta)
        {
            _healthContext.Add(consulta);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Consulta consultaBuscada = _healthContext.Consulta.Find(id);
            _healthContext.Consulta.Remove(consultaBuscada);
            _healthContext.SaveChanges();
        }
    }
}

