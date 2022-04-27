namespace AFP.Core.Entities
{
    public class Cita
    {
        public int Opcion { get; set; }
        public int Id { get; set; }
        public int Paciente { get; set; }
        public int Medico { get; set; }
        public DateTime Horario { get; set; }
        public int CausaCita { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
