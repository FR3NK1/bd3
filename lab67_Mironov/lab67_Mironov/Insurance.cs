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
    public partial class Insurance : Form
    {
        public Insurance()
        {
            InitializeComponent();
        }
        public int idInsurance { get; set; }

        string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=sberbank;password=1234";

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Insurance (Type, Date_of_time, idClient) VALUES (@Type, @Date_of_time, @idClient)", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Type", TypeEdit.Text);
                        cmd.Parameters.AddWithValue("@Date_of_time", DateEdit.Text);
                        cmd.Parameters.AddWithValue("@idClient", idClientEdit.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Страховка успешно добавлена", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetInsuranceRecords();
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
            TypeEdit.Clear();
            DateEdit.Clear();
            idClientEdit.Clear();
            idInsurance = 0;
            TypeEdit.Focus();
        }

        private void GetInsuranceRecords()
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Insurance", con))
                {
                    DataTable dt = new DataTable();

                    con.Open();

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                        dt.Load(sdr);


                    InsuranceGrid.DataSource = dt;
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idInsurance > 0)
                {
                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("UPDATE Insurance SET Type = @Type, Date_of_time = @Date_of_time, idClient = @idClient WHERE idInsurance = @idInsurance", con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@Type", TypeEdit.Text);
                            cmd.Parameters.AddWithValue("@Date_of_time", DateEdit.Text);
                            cmd.Parameters.AddWithValue("@idClient", idClientEdit.Text);
                            cmd.Parameters.AddWithValue("@idInsurance", idInsurance);

                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Страховка успешно обновлена.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GetInsuranceRecords();
                            ResetObjects();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите страховку для обновления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (idInsurance > 0)
                {
                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE from Insurance where idInsurance = @idInsurance", con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@idInsurance", idInsurance);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Страховка успешно удалена.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GetInsuranceRecords();
                            ResetObjects();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите страховку для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsuranceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idInsurance = Convert.ToInt32(InsuranceGrid.SelectedRows[0].Cells[0].Value);
            TypeEdit.Text = InsuranceGrid.SelectedRows[0].Cells[1].FormattedValue.ToString();
            DateEdit.Text = InsuranceGrid.SelectedRows[0].Cells[2].Value.ToString();
            idClientEdit.Text = InsuranceGrid.SelectedRows[0].Cells[3].FormattedValue.ToString();
        }

        private void Insurance_Load(object sender, EventArgs e)
        {
            GetInsuranceRecords();
        }
    }
}
