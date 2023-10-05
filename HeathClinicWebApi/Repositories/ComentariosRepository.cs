using HeathClinicWebApi.Context;
using HeathClinicWebApi.Domains;
using HeathClinicWebApi.Interfaces;
using System.Runtime.CompilerServices;
using System.Xml;

namespace HeathClinicWebApi.Repositories
{
    public class ComentariosRepository : IComentariosRepository
    {
        private readonly HealthContext _healthContext;

        public ComentariosRepository()
        { 
            _healthContext = new HealthContext();
        }

        public void Atualizar(Guid id, Comentarios comentario)
        {
            Comentarios comentarioBuscado = _healthContext.Comentario.Find(id);
            
            if (comentarioBuscado != null)
            {
                comentarioBuscado.FeedBack = comentario.FeedBack;
            }
            _healthContext.Comentario.Update(comentarioBuscado);

            _healthContext.SaveChanges();
        }

        public void Cadastrar(Comentarios comentario)
        {
            _healthContext.Comentario.Add(comentario);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
             Comentarios comentarios = _healthContext.Comentario.Find(id);
            _healthContext.Comentario.Remove(comentarios);
            _healthContext.SaveChanges();
        }
    }
}
