using Dapper;
using ENG3.Consultorio.Doman.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Repository.Dapper
{
    public class ConsultaDapperRepository: DapperRepositoryBase<int,Consulta>
    {
        public IEnumerable<Consulta> GetConsultasByDoctorId(int doctorId)
        {
            var sql = "[select-consulta-byDoctor]";
            return _sqlConnection.Query<Consulta>(sql, new { doctorId }, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<Consulta> GetConsultasByDate(DateTime date)
        {
            var sql = "[select-consulta-byDate]";
            return _sqlConnection.Query<Consulta>(sql, new { date }, commandType: CommandType.StoredProcedure);

        }
    }
}
