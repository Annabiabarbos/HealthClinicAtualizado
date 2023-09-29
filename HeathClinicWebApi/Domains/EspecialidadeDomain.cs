using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeathClinicWebApi.Domains
{
    [Table(nameof(Especialidade))]
    public  class Especialidade
    {
            [Key]
            public Guid? IdEspecialidade { get; set; }

            [Column(TypeName = "VARCHAR(30)")]
            [Required(ErrorMessage = "Especialidade obrigatoria!")]
            public string? Area { get; set; } 
    }
}

