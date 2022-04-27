using AFP.Core.Entities;
using AFP.Infrastructure.ParamsDTO;
using AutoMapper;

namespace AFP.Infrastructure.Mapping
{
    public class InfrastructureMapping : Profile
    {
        #region CONSTRUCTOR
        public InfrastructureMapping()
        {
            Mapping();
        }
        #endregion

        #region METODOS
        public void Mapping()
        {
            CreateMap<CausaCita, CausaCitaDto>().ReverseMap();
            CreateMap<Cita, CitaDto>().ReverseMap();
            CreateMap<Diagnostico, DiagnosticoDto>().ReverseMap();
            CreateMap<Medico, MedicoDto>().ReverseMap();
            CreateMap<Paciente, PacienteDto>().ReverseMap();
            CreateMap<Vocacion, VocacionDto>().ReverseMap();
        }
        #endregion
    }
}
