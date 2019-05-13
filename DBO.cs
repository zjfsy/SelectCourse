using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SelectCourse
{
    public static class DBO
    {
        public static Dictionary<string, string> Search(string cmd)
        {
            MySqlConnection con = new MySqlConnection(ser);
            con.Open();
            MySqlCommand com = new MySqlCommand(cmd, con);
            MySqlDataReader rdr = com.ExecuteReader();
            Dictionary<string, string> dty = new Dictionary<string, string>();
            while (rdr.Read())
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    dty.Add(rdr.GetName(i),rdr.IsDBNull(i) ? "" : rdr.GetString(i));
                }
            }
            return dty;
        }
        public static void Search(string cmd, ListView lvw)
        {
            MySqlConnection con = new MySqlConnection(ser);
            con.Open();
            MySqlCommand com = new MySqlCommand(cmd, con);
            MySqlDataReader rdr = com.ExecuteReader();
            lvw.Clear();
            lvw.Columns.Add("rows", 40, HorizontalAlignment.Center);
            for (int i = 0; i < rdr.FieldCount; i++)
            {
                lvw.Columns.Add(rdr.GetName(i), 60, HorizontalAlignment.Center);
            }
            for (int i = 1; rdr.Read(); i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString("000");
                for (int j = 0; j < rdr.FieldCount; j++)
                {
                    item.SubItems.Add(rdr.IsDBNull(j) ? "null" : rdr.GetString(j));
                }
                lvw.Items.Add(item);
            }
            rdr.Close();
            con.Close();
        }
        public static void Insert(string cmd)
        {
            MySqlConnection con = new MySqlConnection(ser);
            con.Open();
            MySqlCommand com = new MySqlCommand(cmd, con);
            try
            {
                com.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            con.Close();
        }
        public static void Delete(string cmd)
        {
            MySqlConnection con = new MySqlConnection(ser);
            con.Open();
            MySqlCommand com = new MySqlCommand(cmd, con);
            try
            {
                com.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            con.Close();
        }
        public static void Update(string cmd)
        {
            MySqlConnection con = new MySqlConnection(ser);
            con.Open();
            MySqlCommand com = new MySqlCommand(cmd, con);
            try
            {
                com.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            con.Close();
        }
        private static readonly string ser = "server=localhost;port=3306;user id=root;password=ZJF19990107;database=register";
    }
}
