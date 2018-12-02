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
    public class LoginDapperRepository:DapperRepositoryBase<int,Login>
    {
        public Login Login(string login, string password)
        {
            var sql = "[select-usuario-login]";
            return _sqlConnection.Query<Login>(sql, new { login,password }, commandType: CommandType.StoredProcedure).FirstOrDefault();

        }
    }
}
