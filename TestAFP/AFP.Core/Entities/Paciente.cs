namespace AFP.Core.Entities
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
