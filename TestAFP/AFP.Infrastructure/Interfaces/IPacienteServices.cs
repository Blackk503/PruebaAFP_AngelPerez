using AFP.Core.Entities;

namespace AFP.Infrastructure.Services
{
    public interface IPacienteServices
    {
        Task<int> ActualizarPaciente(Paciente paciente);
        Task<int> CrearPaciente(Paciente paciente);
        Task<List<Paciente>> GetPacientes(Paciente paciente);
        Task<Paciente> GetRegPaciente(Paciente paciente);
    }
}