using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Data
{
    public class Datalayer
    {
      static public void add(string fn, string ln, string g, string e)
      {
        string info = "datasource=127.0.0.1;port=3306;username=root;password=;database=tut4";
        MySqlConnection conn = new MySqlConnection(info);
        string rs = $"INSERT INTO `ujportal` (`fname`,`lname`,`gender`,`email`) VALUES('{fn}','{ln}','{g}','{e}')";
        try
        {
          MySqlCommand commandObj = new MySqlCommand(rs, conn);
          conn.Open();
          MySqlDataReader readObj = commandObj.ExecuteReader();
          readObj.Close(); 
          conn.Close();
        }
        catch (Exception ex) {
          Console.WriteLine(ex);
        }
      }
      static public DataTable fetch()
      {
        string info = "datasource=127.0.0.1;port=3306;username=root;password=;database=tut4";
        MySqlConnection conn = new MySqlConnection(info);
        string q = $"SELECT * FROM `ujportal`";
        try
        {
          conn.Open();
          MySqlDataAdapter adapter = new MySqlDataAdapter();
          DataTable table = new DataTable();
          adapter.SelectCommand = new MySqlCommand(q, conn);
          adapter.Fill(table);
          conn.Close();
          return table;
        }
            catch (Exception )
            {
                return null;
            }
        }
      static public void update(string fn, string ln, string g, string e, string id )
      {
        string info = "datasource=127.0.0.1;port=3306;username=root;password=;database=tut4";
        MySqlConnection conn = new MySqlConnection(info);
        string q=$"UPDATE `ujportal` SET `fname`='{fn}',`lname`='{ln}',`gender`='{g}',`email`='{e}' WHERE `id`='{id}'";
        try
        {
          MySqlCommand commandObj = new MySqlCommand(q, conn);
          conn.Open();
          MySqlDataReader readObj = commandObj.ExecuteReader();
          readObj.Close();
          conn.Close();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex);
        }
      }
      static public void delete(string id)
      { 
        string info = "datasource=127.0.0.1;port=3306;username=root;password=;database=tut4";
        MySqlConnection conn= new MySqlConnection(info);
        string q = $"DELETE FROM `ujportal` WHERE `id`='{id}'";
        try
        {
          MySqlCommand commandObj = new MySqlCommand(q, conn);
          conn.Open();
          MySqlDataReader readObj = commandObj.ExecuteReader();
          readObj.Close();
          conn.Close();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex);
        }
      }
  }
}