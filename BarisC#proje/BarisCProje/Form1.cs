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
using MySql.Data;

namespace BarisCProje
{
    public partial class Form1 : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje;user=root");
       
        //Yeni yeni = new Yeni();
        public Form1()
        {
            InitializeComponent();
        }
        Frmakademisyen a = new Frmakademisyen();
        private void bttngiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            a.akademisyen(cmbkullaniciadi, txtsifre);
        }

        private void grpboxkullanicigirisi_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
