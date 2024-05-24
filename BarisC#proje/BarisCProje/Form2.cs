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
    public partial class Form2 : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje;user=root");
        MySqlDataReader read;
        MySqlCommand komut;
        Yeni yeni = new Yeni();
        DataSet ds = new DataSet();
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Int32 satir;
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand();
                // Insert Into SQL ile tablomuza formdaki verileri
                // parametreli (@) şekilde  gönderiyoruz
                // parametreler SQL injection a karşı tedbir olarak uygulanır
                // Tırnak işaretleri ile uğraşılmak zorunda kalınmaz    
                komut.CommandText = "INSERT INTO proje (bitirmeprojeıd,projeadı,projedanısman,birincijuri,ikincijuri,ucuncujuri,dorduncujuri,yarıyil,kac)" +
                    "VALUES (@pbitirmeprojeıd,@pprojeadı,@pprojedanısman,@pbirincijuri,@pikincijuri,@pucuncujuri,@pdorduncujuri,@pyarıyil,@pkac)";
                // @ işareti ile başlayan kısım parametreli değişkenlere
                // değerler aktarıyor
                komut.Parameters.AddWithValue("@pbitirmeprojeıd", txtıd.Text);
                komut.Parameters.AddWithValue("@pprojeadı", rtxtadı.Text);
                komut.Parameters.AddWithValue("@pprojedanısman", cmbdanısman.Text);
                komut.Parameters.AddWithValue("@pbirincijuri", cmb1.Text);
                komut.Parameters.AddWithValue("@pikincijuri", cmb2.Text);
                komut.Parameters.AddWithValue("@pucuncujuri", cmb3.Text);
                komut.Parameters.AddWithValue("@pdorduncujuri", cmb4.Text);
                komut.Parameters.AddWithValue("@pyarıyil", cmbsure.Text);
                komut.Parameters.AddWithValue("@pkac", cmbyıl.Text);
                komut.Connection = baglanti;
                satir = komut.ExecuteNonQuery();
                MessageBox.Show(satir + " öğrenci eklendi !");
                komut.Dispose(); // komut nesnesini yoket
                baglanti.Close(); // bağlantıyı kapat
                listele(); //datagrid tazelensin
            }
        }
        private void listele()
        {
            baglanti.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM proje", baglanti);
            adapter.Fill( ds, "proje");
            dataGridView1.DataSource = ds.Tables["proje"];
            adapter.Dispose();
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 satir;
            DialogResult cevap;
            cevap = MessageBox.Show("Silmek istediğinizden emin misiniz bilgiler kalıcı olarak silinecektir", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand();
                // Yine parametreli şekilde göderiyoruz
                komut.CommandText = "DELETE FROM proje WHERE bitirmeprojeıd=@pbitirmeprojeıd";
                // @ işareti ile başlayan kısım parametreli değişkenleri ifade ediyor
                komut.Parameters.AddWithValue("@pbitirmeprojeıd", txtıd.Text);
                komut.Connection = baglanti;
                satir = komut.ExecuteNonQuery();
                MessageBox.Show(satir + " öğrenci silindi !");
                komut.Dispose();
                baglanti.Close();
                listele();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            rtxtadı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbdanısman.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmb1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmb2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmb3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmb4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbsure.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbyıl.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }
    }
}
