using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface ITiposUsuarioRepository
    {
        void Deletar(Guid id);

        void Cadastrar(TiposUsuario tiposUsuario);
    }
}
