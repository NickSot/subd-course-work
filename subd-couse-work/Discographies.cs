﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace subd_couse_work
{
    class Discographies
    {
        public static DataRow Find(int id)
        {
            return DbManager.Find("Discographies", id);
        }

        public static DataTable Where(Dictionary<string, Object> dict)
        {
            return DbManager.WhereAnd("Discographies", dict);
        }

        public static DataTable WhereOr(Dictionary<string, Object> dict)
        {
            return DbManager.WhereOr("Discographies", dict);
        }

        public static void Insert(Dictionary<string, Object> dict)
        {
            DbManager.Insert("Discographies", dict);
        }

        public static void Update(int id, Dictionary<string, Object> dict)
        {
            DbManager.Update("Discographies", id, dict);
        }

        public static void Delete(Dictionary<string, Object> dict)
        {
            DbManager.Delete("Discographies", dict);
        }

        public static DataTable All()
        {
            return DbManager.All("Discographies");
        }
    }
}
