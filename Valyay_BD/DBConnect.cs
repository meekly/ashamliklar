using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Valyay_BD
{
    class DBConnect
    {
        static MySqlConnection connection;
        static MySqlCommand command;
        static string com = "Server=127.0.0.1;Database=valyay_v2;port=3306;Uid=root;password=admin;";

        private void ConnectTo()
        {
            connection = new MySqlConnection(com);
            command = connection.CreateCommand();
        }
        public DBConnect()
        {
            ConnectTo();
        }
        public static bool Contains(string commC)
        {
            try
            {
                DataTable table = DBConnect.ShowDB(commC);
                if (table.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }
        public static DataTable ShowDB(string cc)
        {
            DataTable table = new DataTable();
            try
            {

                connection = new MySqlConnection(com);
                MySqlCommand cmd = new MySqlCommand(cc, connection);
                connection.Open();
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                MessageBox.Show("Подключение прошло успешно!");
            }
            return table;
        }
        public static void InsertDeleteDB(string cc)
        {
            try
            {
                connection = new MySqlConnection(com);
                MySqlCommand cmd = new MySqlCommand(cc, connection);
                cmd.CommandType = CommandType.Text;
                connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
