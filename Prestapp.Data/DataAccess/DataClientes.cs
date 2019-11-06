using Prestapp.Data.DataAccess.Generic;
using PrestApp.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prestapp.Data.DataAccess
{
    public class DataClientes : GenericData<clClientes>
    {
        public DataClientes(SQLiteAsyncConnection db) : base(db)
        {
        }
    }
}
