using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static HeathClinicWebApi.Domains.TiposUsuario;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HeathClinicWebApi.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
        {
            [Key]
            public Guid? IdUsuario { get; set; } = Guid.NewGuid();

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "Nome Completo do usuário obrigatório!")]
            public string? NomeCompleto { get; set; }

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "Email do usuário obrigatório!")]
            public string? Email { get; set; }

            [Column(TypeName = "CHAR(60)")]
            [Required(ErrorMessage = "Senha obrigatória!")]
            [StringLength(60, MinimumLength = 6, ErrorMessage = "Senha deve conter de 6 a 60 caracteres")]
            public string? Senha { get; set; }


            [Column(TypeName ="DATE")]
            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
            public DateTime? DataNascimento { get; set; }


            //ref.tabela TiposUSuario = FK
            [Required(ErrorMessage = "Informe o tipo do usuário!")]
            public Guid? IdTipoUsuario { get; set; }


            [ForeignKey(nameof(IdTipoUsuario))]
            public TiposUsuario? TiposUsuario { get; set;}
        
    }
}
    
     



