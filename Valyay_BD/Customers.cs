using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Valyay_BD
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            Customers_Load();
        }

        private void Customers_Load()
        {

                dataGridView.DataSource = DBConnect.ShowDB("SELECT * FROM customer");
                dataGridView.Columns[0].HeaderText = "Код клиента";
                dataGridView.Columns[1].HeaderText = "Логин";
                dataGridView.Columns[2].HeaderText = "Пароль";
                dataGridView.Columns[3].HeaderText = "Телефон";
                dataGridView.Columns[4].HeaderText = "E-mail";
                dataGridView.Columns[5].HeaderText = "Адрес";
                dataGridView.Columns[6].HeaderText = "ФИО";
                dataGridView.Columns[7].HeaderText = "IP";
                dataGridView.Columns[8].HeaderText = "Cтатус";
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //textBoxID.Text = "";
                //textBoxL.Text = "";
                //textBoxP.Text = "";
                //textBoxT.Text = "";
                //textBoxE.Text = "";
                //textBoxA.Text = "";
                //textBoxN.Text = "";
                //textBoxIP.Text = "";
                //textBoxS.Text = "";
        }
      }      
 }
