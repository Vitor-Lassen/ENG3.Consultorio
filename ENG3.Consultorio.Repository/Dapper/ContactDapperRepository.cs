using Dapper;
using ENG3.Consultorio.Doman.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG3.Consultorio.Repository.Dapper
{
    public class ContactDapperRepository: DapperRepositoryBase<int,Contact>
    {
        public Contact InsetDoctorContacts(int crm, Contact contact )
        {
            contact.Id = (int)Add(contact);
            var sql = "[Insert-MEDICO_TELEFONE]";
            _sqlConnection.Execute(sql, new { crm, TelefoneId = contact.Id },commandType:System.Data.CommandType.StoredProcedure);
            return contact;
        }
    }
}
