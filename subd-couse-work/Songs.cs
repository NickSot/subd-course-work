using System;
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
    class Songs
    {
        public static DataRow Find(int id)
        {
            return DbManager.Find("Songs", id);
        }

        public static DataTable Where(Dictionary<string, string> dict)
        {
            return DbManager.Where("Songs", dict);
        }

        public static void Insert(Dictionary<string, string> dict)
        {
            DbManager.Insert("Songs", dict);
        }

        public static void Update(int id, Dictionary<string, string> dict)
        {
            DbManager.Update("Songs", id, dict);
        }

        public static void Delete(Dictionary<string, string> dict)
        {
            DbManager.Delete("Songs", dict);
        }
    }
}
