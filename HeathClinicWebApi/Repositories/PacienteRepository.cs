using HeathClinicWebApi.Context;
using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;

namespace HeathClinicWebApi.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {

        private readonly HealthContext _healthContext;

        public PacienteRepository()
        {
            _healthContext = new HealthContext();
        }

        public void Atualizar(Guid id, Paciente paciente)
        {

            Paciente pacienteBuscado = _healthContext.Paciente.Find(id);

            if (pacienteBuscado != null)
            {
                pacienteBuscado.Telefone = paciente.Telefone;
                pacienteBuscado.Endereco = paciente.Endereco;
            }

            _healthContext.Paciente.Update(pacienteBuscado);

            _healthContext.Update(pacienteBuscado);
        }

        public void Cadastrar(Paciente paciente)
        {
            _healthContext.Paciente.Add(paciente);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {

            Paciente paciente = _healthContext.Paciente.Find(id);
            _healthContext.Paciente.Remove(paciente);
            _healthContext.SaveChanges();
        }
    }
}
