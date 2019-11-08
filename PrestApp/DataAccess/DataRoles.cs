using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using PrestApp.Generic;
using PrestApp.Clases;

namespace PrestApp.DataAccess
{
    public class DataRoles : GenericData<Roles>
    {
        public DataRoles(SQLiteAsyncConnection db) : base(db)
        {

        }
    }
}
