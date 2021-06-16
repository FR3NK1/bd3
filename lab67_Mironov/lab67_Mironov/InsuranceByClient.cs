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
    public partial class InsuranceByClient : Form
    {
        public InsuranceByClient()
        {
            InitializeComponent();
        }

        string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=sberbank;password=1234";

        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                using (MySqlCommand cmd = new MySqlCommand("select insurance.type, insurance.date_of_time " +
                    "from client " +
                    "join insurance on client.idClient = insurance.idClient " +
                    "where client.full_name like @Full_name", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Full_name", '%' + FullNameEdit.Text + '%');
                    DataTable dt = new DataTable();

                    con.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                        dt.Load(sdr);
                    InsuranceGrid.DataSource = dt;
                }
            }
        }

        private void InsuranceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
