using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        void Deletar(Guid id);

        void Atualizar(Guid id, Usuario usuario);


    }
}

