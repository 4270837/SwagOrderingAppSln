using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SwagOrderingApp
{
    public class Constants
    {
        public const string DatabaseFilename = "SwagTSQlite.db3";
        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath 
        {
            get 
            {  var basePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                return  Path.Combine(basePath,DatabaseFilename);
            
            }
        }
    }

    

}

