using System;
using System.Collections.Generic;

namespace TH8201S.Db
{
    public class DbBridge
    {
        public Dictionary<string, DbSource> Sources { get; private set; } = new Dictionary<string, DbSource>();

        private static DbBridge _instance;

        public static DbBridge Instance { get { return _instance = _instance ?? (_instance = new DbBridge());} }

        public string SourceName { get; private set; }

        public string ConnStr { get; set; }

        public DbBridge()
        {
            Sources.Add("May-NCM", new DbSource("localhost", "", "th8201s", "root", "manh123"));
            Sources.Add("May-Cuong", new DbSource("localhost", "", "th8201s", "root", "Adatek2vn@server3"));
            Sources.Add("Server-Cuong", new DbSource("222.252.4.119", "1433", "th8201s", "root", "Adatek2vn@server3"));

            LoadSettings();
            SourceName = Properties.Settings.Default.DbSrc;

            if (Sources.ContainsKey(SourceName))
            {
                ConnStr = Sources[SourceName].ConnectionString;
            }
            else
            {
                ConnStr = Sources["May-Cuong"].ConnectionString;
                SourceName = "May-Cuong";
            }
        }

        public void SetSource(string name)
        {
            if (Sources.ContainsKey(name))
            {
                SourceName = name;
                ConnStr = Sources[name].ConnectionString;
            }
        }

        public void LoadSettings()
        {
             SourceName = Properties.Settings.Default.DbSrc;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.DbSrc = SourceName;
            Properties.Settings.Default.Save();
        }
    }

    public class DbSource
    {
        public string ConnectionString { get; private set; }

        public string Server { get; set; }
        public string Port {  get; set; }
        public string Database { get; set; }
        public string UId {  get; set; }
        public string Pwd { get; set; }

        public DbSource() { }

        public DbSource(string srv, string port, string db, string uid, string pw)
        {
            Server = srv;
            Database = db;
            UId = uid;
            Pwd = pw;
            GenConnStr();
        }

        public void GenConnStr()
        {
            if (Server == "localhost")
            {
                ConnectionString = string.Format("Server={0};Database={1};UId={2};Pwd={3};Pooling=false;Character Set=utf8;", Server, Database, UId, Pwd);
            }
            else
            {
                ConnectionString = string.Format("Server={0};Port={1};Database={2};UId={3};Pwd={4};Pooling=false;Character Set=utf8;", Server, Port, Database, UId, Pwd);
            }
        }
    }
}
