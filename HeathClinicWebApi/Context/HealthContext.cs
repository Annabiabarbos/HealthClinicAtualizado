using HeathClinicWebApi.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace HeathClinicWebApi.Context
{
    public  class HealthContext : DbContext
    {
      
        public DbSet<TiposUsuarioDomain> TiposUsuario { get; set; }

        public DbSet<UsuarioDomain> Usuario { get; set; }    

        public DbSet<PacienteDomain> Paciente { get; set; }   

        public DbSet<MedicoDomain> Medico { get; set; }

        public DbSet<EspecialidadeDomain> Especialidade { get; set; }

        public DbSet<ConsultaDomain> Consulta { get; set; }

        public DbSet<ComentariosDomain> Comentario { get; set; }

        public DbSet<ClinicaDomain> Clinica { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE05-S14; Database=Health_Clinic_manha_; user Id=sa; pwd=Senai@134; TrustServerCertificate=true;", x => x.UseDateOnlyTimeOnly());



            base.OnConfiguring(optionsBuilder);
        }
    }


}

