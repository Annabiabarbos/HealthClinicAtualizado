using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HeathClinicWebApi.Domains;
using static HeathClinicWebApi.Domains.UsuarioDomain;

namespace HeathClinicWebApi.Domains
{
    public class ConsultaDomain
    {
        [Table(nameof(Consulta))]

        public class Consulta
        {
            [Key]

            public Guid? IdConsulta { get; set; }

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "Prontuario obrigatorio!")]
            public string? Prontuario { get; set; }

            [Column(TypeName = "DATE")]
            [Required(ErrorMessage = "Data obrigatoria!")]
            public TimeOnly? DataConsulta { get; set; }

            [Column(TypeName = "VARCHAR (50)")]
            [Required(ErrorMessage = "Nome do medico obrigatorio!")]
            public string? NomeMedico { get; set; }

            [Required(ErrorMessage = "Informar o paciente!")]
            public Guid? IdPaciente { get; set; }

            [ForeignKey(nameof(IdPaciente))]
            public PacienteDomain? Paciente { get; set; }

            [Required(ErrorMessage = "Informar os comentarios!")]
            public Guid? IdComentario { get; set; }

            [ForeignKey(nameof(IdComentario))]
            public ComentariosDomain? Comentarios { get; set; }
        }
    }
}