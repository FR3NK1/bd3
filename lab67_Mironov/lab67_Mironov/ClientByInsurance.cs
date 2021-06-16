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

namespace lab67_Mironov
{
    public partial class ClientByInsurance : Form
    {
        public ClientByInsurance()
        {
            InitializeComponent();
        }

        string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=sberbank;password=1234";

        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                using (MySqlCommand cmd = new MySqlCommand("select client.full_name " +
                    "from insurance " +
                    "join client on insurance.idClient = client.idClient " +
                    "where insurance.type like @Insurance", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Insurance", '%' + InsuranceEdit.Text + '%');
                    DataTable dt = new DataTable();

                    con.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                        dt.Load(sdr);
                    ClientGrid.DataSource = dt;
                }
            }
        }

        private void ClientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
