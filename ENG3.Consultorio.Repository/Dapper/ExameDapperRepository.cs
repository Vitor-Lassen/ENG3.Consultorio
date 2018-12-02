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
    public class ExameDapperRepository : DapperRepositoryBase<int,Exame>
    {
        public IEnumerable<Exame> GetExamesByConsultaId(int ConsultaId)
        {
            var sql = "[select-exame-byConsultaId]";
            return _sqlConnection.Query<Exame>(sql, new { ConsultaId }, commandType: CommandType.StoredProcedure);

        }
    }
}
