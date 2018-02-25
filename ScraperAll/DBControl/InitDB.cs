using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace ScraperAll.DBControl
{
    public class DBControl
    {
        private SqlSugarClient db;

        public DBControl()
        {
            db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString,
                DbType = DbType.Sqlite,
                IsAutoCloseConnection = true
            });
        }

        public string BuildDB()
        {
            string sql = @"
            create table result(
            id INTEGER PRIMARY key AUTOINCREMENT,
            c0 text UNIQUE,
            c1 text,
            c2 text,
            c3 text,
            c4 text,
            c5 text,
            c6 text,
            c7 text,
            c8 text,
            c9 text
            )";

            db.Ado.ExecuteCommand(sql);

            return "";

        }

    }
}
