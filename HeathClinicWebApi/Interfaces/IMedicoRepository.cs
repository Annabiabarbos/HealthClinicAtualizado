using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        void Atualizar(Guid id, Medico medico);

        void Deletar(Guid Id);

        List<Medico> Listar();
    }
}
