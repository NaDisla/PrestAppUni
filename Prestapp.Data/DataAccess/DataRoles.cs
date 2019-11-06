using Prestapp.Data.DataAccess.Generic;
using PrestApp.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prestapp.Data.DataAccess
{
    public class DataRoles : GenericData<Roles>
    {
        public DataRoles(SQLiteAsyncConnection db) : base(db)
        {
        }
    }
}
