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

        public SimpleClient<Models.Result> ResultDB { get { return new SimpleClient<Models.Result>(db); } }

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

            if (!System.IO.File.Exists(Config.DB_File))
            {
                System.Data.SQLite.SQLiteConnection.CreateFile(Config.DB_File);
                db.Ado.ExecuteCommand(sql);
                return "新建数据库成功";
            }
            
            return "已经有数据库了，不能新建了";

        }

        public void CreateClassFile()
        {
            db.DbFirst.CreateClassFile("Result");
        }

    }
}
