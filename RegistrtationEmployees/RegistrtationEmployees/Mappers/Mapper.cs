using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RegistrtationEmployees.Mappers
{
    public interface Mapper<T>
    {
        T mapRow(SqlDataReader reader);
    }
}