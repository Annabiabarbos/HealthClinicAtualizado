using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface IComentariosRepository
    {
        void Cadastrar(Comentarios comentario);
        void Deletar(Guid id);

        void Atualizar(Guid id, Comentarios comentario);

        List<Comentarios> Listar();
    }
}
