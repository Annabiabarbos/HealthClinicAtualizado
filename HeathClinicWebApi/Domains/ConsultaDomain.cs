namespace HeathClinicWebApi.Domains
{
    public class ConsultaDomain
    {
        public Guid IdConslta { get; set; } 

        public Guid?  IdPaciente { get; set; }

        public Guid? IdMedico { get; set; }

        public Guid ? IdConsulta { get; set; }

        public Guid? IdComentario { get; set; }

        public string Prontuario { get; set; }

        public string DataConsulta { get; set; }

        public string NomeMedico { get; set; }
    }
}

