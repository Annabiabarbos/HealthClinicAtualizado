using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface IComentariosRepository
    {
        void Cadastrar(Comentarios comentario);

        void Atualizar(Guid id , Comentarios comentario);
        void Deletar(Guid id);
    }
}
