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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        public int idClient { get; set; }

        string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=sberbank;password=1234";

        private void ClientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idClient = Convert.ToInt32(ClientGrid.SelectedRows[0].Cells[0].Value);
            FullNameEdit.Text = ClientGrid.SelectedRows[0].Cells[1].FormattedValue.ToString();
            PlaceEdit.Text = ClientGrid.SelectedRows[0].Cells[2].FormattedValue.ToString();
            PlaceWorkEdit.Text = ClientGrid.SelectedRows[0].Cells[3].FormattedValue.ToString();
            BirthdateEdit.Text = ClientGrid.SelectedRows[0].Cells[4].FormattedValue.ToString();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
               using (MySqlConnection con = new MySqlConnection(connection))
                 {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Client (Full_name, Place_of_residence, Place_of_work, Date_of_Birth) VALUES (@Full_name, @Place_of_residence, @Place_of_work, @Date_of_Birth)", con))
                        {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Full_name", FullNameEdit.Text);
                        cmd.Parameters.AddWithValue("@Place_of_residence", PlaceEdit.Text);
                        cmd.Parameters.AddWithValue("@Place_of_work", PlaceWorkEdit.Text);
                        cmd.Parameters.AddWithValue("@Date_of_Birth", BirthdateEdit.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Клиент успешно добавлен", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetClientRecords();
                        ResetObjects();
                        }
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetObjects()
        {
            idClient = 0;
            PlaceEdit.Clear();
            PlaceWorkEdit.Clear();
            FullNameEdit.Clear();
            BirthdateEdit.Clear();
            FullNameEdit.Focus();
        }

        private void GetClientRecords()
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Client", con))
                {
                    DataTable dt = new DataTable();

                    con.Open();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                        dt.Load(sdr);


                    ClientGrid.DataSource = dt;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idClient > 0)
                {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            using (MySqlCommand cmd = new MySqlCommand("UPDATE Client SET Full_name = @Full_name, Place_of_residence = @Place_of_residence, Place_of_work = @Place_of_work, Date_of_Birth = @Date_of_Birth WHERE idClient = @idClient", con))
                            {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Full_name", FullNameEdit.Text);
                            cmd.Parameters.AddWithValue("@Place_of_residence", PlaceEdit.Text);
                            cmd.Parameters.AddWithValue("@Place_of_work", PlaceWorkEdit.Text);
                            cmd.Parameters.AddWithValue("@Date_of_Birth", BirthdateEdit.Text);
                            cmd.Parameters.AddWithValue("@idClient", idClient);

                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Клиент успешно обновлен.", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                GetClientRecords();
                                ResetObjects();
                            }
                        }
                }
                else
                {
                    MessageBox.Show("Выберите клиента для обновления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idClient > 0)
                {
                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Client WHERE IDClient = @IDClient", con))
                        {
                            using (MySqlCommand cmd1 = new MySqlCommand("select Client.IDClient, Insurance.IDClient " +
                                "from client " +
                                "join insurance on client.idClient = insurance.idClient " +
                                "where insurance.IDClient = @IDClient; ", con))
                            {
                                DataTable dt = new DataTable();
                                cmd1.CommandType = CommandType.Text;
                                cmd1.Parameters.AddWithValue("IDClient", idClient);
                                con.Open();
                                using (MySqlDataReader sdr = cmd1.ExecuteReader())
                                    dt.Load(sdr);
                                con.Close();

                                if (dt.Rows.Count != 0)
                                {
                                    DialogResult result = MessageBox.Show("Удаление этого клиента повлечет за собой удаление связанных с ним страховок. Вы хотите продолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result == DialogResult.No)
                                        return;
                                }

                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@IDClient", idClient);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Клиент успешно удален.", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                GetClientRecords();
                                ResetObjects();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите клиента для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            GetClientRecords();
        }
    }
}
