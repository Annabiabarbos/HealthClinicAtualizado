using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        void Atualizar (Guid id , Paciente paciente);

        void Deletar(Guid id);

        List<Paciente> Listar();
    }
}
