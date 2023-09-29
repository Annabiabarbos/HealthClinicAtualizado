using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        List<Medico>ListarTodos();

        void Atualizar(Guid id, Medico medico);

        void Deletar(Guid Id);

       
    }
}
