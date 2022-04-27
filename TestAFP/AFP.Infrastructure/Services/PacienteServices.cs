using Dapper;
using AFP.Core.Entities;
using Microsoft.Data.SqlClient;

namespace AFP.Infrastructure.Services
{
    public class PacienteServices : IPacienteServices
    {
        #region ATTRIBUTES
        private readonly string _conn;
        #endregion

        #region CONSTRUCTOR
        public PacienteServices(string dbConnection)
        {
            _conn = dbConnection;
        }
        #endregion

        #region METHODS
        public async Task<List<Paciente>> GetPacientes(Paciente paciente)
        {
            using var _db = new SqlConnection(_conn);
            string _query = @"EXEC SP_PACIENTE_MANT 
                @OPCION = @Opcion, 
                @ID = @Id, 
                @NOMBRE = @Nombre, 
                @APELLIDO = @Apellido, 
                @FECHA_NACIMIENTO = @Fecha_Nacimiento, 
                @ESTADO = @Estado, 
                @FECHA_REGISTRO = @Fecha_Registro";
            return (await _db.QueryAsync<Paciente>(_query, new { paciente })).AsList();
        }

        public async Task<Paciente> GetRegPaciente(Paciente paciente)
        {
            using var _db = new SqlConnection(_conn);
            string _query = @"EXEC SP_PACIENTE_MANT 
                @OPCION = @Opcion, 
                @ID = @Id, 
                @NOMBRE = @Nombre, 
                @APELLIDO = @Apellido, 
                @FECHA_NACIMIENTO = @Fecha_Nacimiento, 
                @ESTADO = @Estado, 
                @FECHA_REGISTRO = @Fecha_Registro";
            return (await _db.QueryAsync<Paciente>(_query, new { paciente })).FirstOrDefault();
        }

        public async Task<int> CrearPaciente(Paciente paciente)
        {
            using var _db = new SqlConnection(_conn);
            string _query = @"EXEC SP_PACIENTE_MANT 
                @OPCION = @Opcion, 
                @ID = @Id, 
                @NOMBRE = @Nombre, 
                @APELLIDO = @Apellido, 
                @FECHA_NACIMIENTO = @Fecha_Nacimiento, 
                @ESTADO = @Estado, 
                @FECHA_REGISTRO = @Fecha_Registro";
            return await _db.ExecuteAsync(_query, paciente);
        }

        public async Task<int> ActualizarPaciente(Paciente paciente)
        {
            using var _db = new SqlConnection(_conn);
            string _query = @"EXEC SP_PACIENTE_MANT 
                @OPCION = @Opcion, 
                @ID = @Id, 
                @NOMBRE = @Nombre, 
                @APELLIDO = @Apellido, 
                @FECHA_NACIMIENTO = @Fecha_Nacimiento, 
                @ESTADO = @Estado, 
                @FECHA_REGISTRO = @Fecha_Registro";
            return await _db.ExecuteAsync(_query, paciente);
        }
        #endregion
    }
}
