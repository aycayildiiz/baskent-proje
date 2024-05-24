using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarisCProje
{
    internal class Frmakademisyen
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje;user=root");
        MySqlDataReader read;
        MySqlCommand komut;
        Yeni yeni = new Yeni();

        public MySqlDataReader akademisyen(ComboBox eposta, TextBox sifre)
        {
            baglanti.Open();
            komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM giris WHERE eposta='" + eposta.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    yeni.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata1");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz", "Hata2");
            }
            baglanti.Close();
            return read;
        }
    }
}
