using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab67_Mironov
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toClientBtn_Click(object sender, EventArgs e)
        {
            Form toClient = new Client();
            toClient.Owner = this;
            toClient.Show();
        }

        private void toInsuranceBtn_Click(object sender, EventArgs e)
        {
            Form toInsurance = new Insurance();
            toInsurance.Owner = this;
            toInsurance.Show();
        }

        private void showClientsBtn_Click(object sender, EventArgs e)
        {
            Form showClients = new ClientByInsurance();
            showClients.Owner = this;
            showClients.Show();
        }

        private void showInsuranceBtn_Click(object sender, EventArgs e)
        {
            Form showInsurance = new InsuranceByClient();
            showInsurance.Owner = this;
            showInsurance.Show();
        }
    }
}
