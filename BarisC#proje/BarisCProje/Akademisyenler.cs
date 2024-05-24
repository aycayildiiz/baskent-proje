using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarisCProje
{
    public partial class Akademisyenler : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje;user=root;");
        DataSet ds = new DataSet();
        public Akademisyenler()
        {
            InitializeComponent();
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM akademisyen", baglanti))
                {
                    adapter.Fill(ds, "akademisyen");

                    dataGridView1.DataSource = ds.Tables["akademisyen"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
    }
}
