using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using RegistrtationEmployees.dao;
using RegistrtationEmployees.Models;

namespace RegistrtationEmployees.Services
{
    public class TemplateService<T, K>
        where K:adoTemplate<T>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        K dao;

        public List<T> getAll()
        {
            dao = (K)Activator.CreateInstance(typeof(K));
            List<T> entityList = new List<T>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                entityList = dao.getAll(connection);

            }

            return entityList;
        }
        public void createOrUpdate(T entity)
        {
            dao = (K)Activator.CreateInstance(typeof(K));
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dao.createOrUpdate(connection, entity);

            }
        }
        public void delete(int id)
        {
            dao = (K)Activator.CreateInstance(typeof(K));
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dao.delete(connection, id);

            }
        }

    }
}