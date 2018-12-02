using Dapper;
using ENG3.Consultorio.Doman.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Repository.Dapper
{
    public class MaterialDapperRepository:DapperRepositoryBase<int, Material>
    {
        public Material InsetConsultaMaterial(int consultaId, Material material)
        {
            material.Id = (int)Add(material);
            var sql = "[Insert-ConsultaMaterial]";
            _sqlConnection.Execute(sql, new { consultaId, materialId = material.Id}, commandType: System.Data.CommandType.StoredProcedure);
            return material;
        }
        public IEnumerable<Material> GetMateriaisByConsultaId(int consultaId)
        {
            var sql = "[Select-Contacts-Material-ConsultaId]";
            return _sqlConnection.Query<Material>(sql, new { consultaId }, commandType: CommandType.StoredProcedure);

        }
    }
}
