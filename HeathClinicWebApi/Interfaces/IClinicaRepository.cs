using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface IClinicaRepository
    {
        
      void Cadastrar(Clinica clinica);

      void Atualizar(Guid id, Clinica clinica);

      void Deletar(Guid id);
    
    }
}
