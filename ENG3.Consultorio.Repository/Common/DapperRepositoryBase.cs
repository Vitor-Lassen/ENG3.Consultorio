using Dommel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;


namespace ENG3.Consultorio.Repository
{
    public class DapperRepositoryBase<TKey, TEntity> : IDisposable
        where TEntity : class
    {
        protected readonly SqlConnection _sqlConnection;

        public DapperRepositoryBase()
        {
            var strCon = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            _sqlConnection = new SqlConnection(strCon);
        }

        public virtual object Add(TEntity obj)
        {
            return _sqlConnection.Insert(obj);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _sqlConnection.GetAll<TEntity>();
        }

        public virtual TEntity GetById(TKey id)
        {
            return _sqlConnection.Get<TEntity>(id);
        }

        public virtual void Remove(TEntity obj)
        {
            _sqlConnection.Delete(obj);
        }

        public virtual void Update(TEntity obj)
        {
            _sqlConnection.Update(obj);
        }

        public void Dispose()
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
