using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SwagOrderingApp
{
    public class SwagT
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        public string name { get; set; }
        public bool gender { get; set; }

        public bool tShirt { get; set; }

        public string date { get; set; }

        public bool tColour { get; set; }

        public string address { get; set; }

    }
}
