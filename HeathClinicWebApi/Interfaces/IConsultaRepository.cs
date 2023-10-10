using HeathClinicWebApi.Domains;

namespace HeathClinicWebApi.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);

        void Atualizar (Guid id , Consulta consulta);

        void Deletar(Guid id);

        List<Consulta> Listar();
    }
}
