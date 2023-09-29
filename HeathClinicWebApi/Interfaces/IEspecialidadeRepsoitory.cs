using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface IEspecialidadeRepsoitory
    {
        void Cadastrar(Especialidade especialidade);

        void Deletar(Guid id);
    }
}
