using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        List<Paciente> ListarTodos();

        void Atualizar (Guid id , Paciente paciente);

        void Deletar(Guid id);
    }
}
