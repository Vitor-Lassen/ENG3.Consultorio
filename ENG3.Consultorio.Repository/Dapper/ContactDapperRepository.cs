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
    public class ContactDapperRepository: DapperRepositoryBase<int,Contact>
    {
        public Contact InsetDoctorContacts(int crm, Contact contact )
        {
            contact.Id = (int)Add(contact);
            var sql = "[Insert-MEDICO_TELEFONE]";
            _sqlConnection.Execute(sql, new { crm, TelefoneId = contact.Id },commandType:System.Data.CommandType.StoredProcedure);
            return contact;
        }
        public IEnumerable<Contact> GetDoctorContacts (int crm)
        {
            var sql = "[Select-Contacts-medico-byCrm]";
            return _sqlConnection.Query<Contact>(sql, new { crm }, commandType: CommandType.StoredProcedure);
            
        }
        public Contact InsetSecretaryContacts(long cpf, Contact contact)
        {
            contact.Id = (int)Add(contact);
            var sql = "[Insert-Secretaria_TELEFONE]";
            _sqlConnection.Execute(sql, new { cpf, TelefoneId = contact.Id }, commandType: System.Data.CommandType.StoredProcedure);
            return contact;
        }

        public IEnumerable<Contact> GetSecretaryContacts(long cpf)
        {
            var sql = "[Select-Contacts-Secretaria-byCpf]";
            return _sqlConnection.Query<Contact>(sql, new { cpf }, commandType: CommandType.StoredProcedure);

        }

        public Contact InsetPatientContacts(long cpf, Contact contact)
        {
            contact.Id = (int)Add(contact);
            var sql = "[Insert-Paciente_TELEFONE]";
            _sqlConnection.Execute(sql, new { cpf, TelefoneId = contact.Id }, commandType: System.Data.CommandType.StoredProcedure);
            return contact;
        }

        public IEnumerable<Contact> GetPatientContacts(long cpf)
        {
            var sql = "[Select-Contacts-Paciente-byCpf]";
            return _sqlConnection.Query<Contact>(sql, new { cpf }, commandType: CommandType.StoredProcedure);

        }
    }
}
