using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeathClinicWebApi.Domains
{
    public partial class EspecialidadeDomain
    {
        [Table (nameof(Especialidade))]
        public class Especialidade
        {
            [Key]
            public Guid IdEspecialidade { get; set; }

            [Column(TypeName = "VARCHAR(30)")]
            [Required]
            public string? Area { get; set; }
        }
    }
}

