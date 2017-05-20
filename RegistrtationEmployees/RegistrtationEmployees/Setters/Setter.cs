using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrtationEmployees.Setters
{
    public interface Setter<T>
    {
        string getquery(string query, T entity);
    }
}