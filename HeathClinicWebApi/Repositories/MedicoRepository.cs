using HeathClinicWebApi.Context;
using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;

namespace HeathClinicWebApi.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthContext _healthContext;

        public MedicoRepository()
        {
            _healthContext = new HealthContext();
        }
        public void Atualizar(Guid id, Medico medico)
        {
            Medico medicoBuscado = _healthContext.Medico.Find(id);

            if (medicoBuscado !=null)
            {
                medicoBuscado.Contato = medico.Contato;
                medicoBuscado.Especialidade = medico.Especialidade;
                medicoBuscado.Clinica = medico.Clinica;
            }

            _healthContext.Medico.Update(medicoBuscado);

            _healthContext.SaveChanges();
        }

        public void Cadastrar(Medico medico)
        {
            _healthContext.Medico.Add(medico);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid Id)
        {
            Medico medicoBuscado = _healthContext.Medico.Find();
            _healthContext.Medico.Remove(medicoBuscado);
            _healthContext.SaveChanges();
        }

      
    }
}
