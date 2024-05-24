using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarisCProje
{
    public partial class Yeni : Form
    {
        //MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje;user=root");
       // MySqlConnection baglanti = new MySqlConnection("server=localhost;database=proje;user=root");
        
        //Yeni yeni = new Yeni();
        public Yeni()
        {
            InitializeComponent();
        }

        private void btnbitirmeprojeleri_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnogrenciler_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenciler = new Ogrenciler();
            ogrenciler.ShowDialog();
        }

        private void btnakademisyenler_Click(object sender, EventArgs e)
        {
            Akademisyenler akademisyenler = new Akademisyenler();
            akademisyenler.ShowDialog();
        }

        private void btngenelliste_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
