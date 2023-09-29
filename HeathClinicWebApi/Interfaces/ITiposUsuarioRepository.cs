using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface ITiposUsuarioRepository
    {
        Usuario BuscarUsuario(string email, string senha);

        void Cadastrar(Usuario usuario);


    }
}
