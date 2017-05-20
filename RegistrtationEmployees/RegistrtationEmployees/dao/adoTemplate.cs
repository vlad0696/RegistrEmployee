using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using RegistrtationEmployees.Mappers;
using RegistrtationEmployees.Setters;

namespace RegistrtationEmployees.dao
{
    public class adoTemplate<T>
    {
        
        protected List<T> getAll(SqlConnection connection, string query, Mapper<T> mapper)
        {
            List<T> entities = new List<T>();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) 
            {
                while (reader.Read())
                {
                    entities.Add(mapper.mapRow(reader));
                }
            }
                return entities;    
        }

        protected void createOrUpdate(SqlConnection connection, string query, Setter<T> setter, T entity)
        {
            query = setter.getquery(query, entity);
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
        }
        protected void delete(SqlConnection connection, string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
        }

        public virtual void createOrUpdate(SqlConnection connectinon, T entity) { }
        public virtual void delete(SqlConnection connectinon, int id) { }
        public virtual List<T> getAll(SqlConnection connection)
        {

            return null;
        }

    }
}