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
    public partial class Form3 : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje;user=root");
        MySqlDataReader read;
        MySqlCommand komut;
        Yeni yeni = new Yeni();
        public Form3()
        {
            InitializeComponent();
            this.textBoxOgrenci = new System.Windows.Forms.TextBox();
            this.textBoxProje = new System.Windows.Forms.TextBox();
            this.textBoxDanisman = new System.Windows.Forms.TextBox();
            this.textBoxjüri1 = new System.Windows.Forms.TextBox();
            this.textBoxjüri2 = new System.Windows.Forms.TextBox();
            this.textBoxjüri3 = new System.Windows.Forms.TextBox();
            this.textBoxjüri4 = new System.Windows.Forms.TextBox();
            this.textBoxadsoyad = new System.Windows.Forms.TextBox();
            this.textBoxno = new System.Windows.Forms.TextBox();
            this.richTextBoxpadı = new System.Windows.Forms.RichTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelAverageScore = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(12, 12);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentID.TabIndex = 0;
            this.textBoxStudentID.Text = "Öğrenci ID";

            // (Repeat for other textboxes and labels)

            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Criteria,
            this.Score});
            this.dataGridView.Location = new System.Drawing.Point(12, 150);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(400, 150);
            this.dataGridView.TabIndex = 5;

            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(150, 320);
            this.buttonCalculate.Name = "Hesapla";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 30);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Ortalama Hesapla";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.btnhesap_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.textBoxProjectID);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.textBoxStudentNumber);
            this.Controls.Add(this.textBoxProjectTitle);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelAverageScore);
            this.Name = "MainForm";
            this.Text = "Graduation Project Evaluation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            int totalScore = 0;
            int criteriaCount = dataGridView1.Rows.Count;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalScore += Convert.ToInt32(row.Cells["Score"].Value);
            }
            double averageScore = (double)totalScore / criteriaCount;
            labelAverageScore.Text = "Average Score: " + averageScore.ToString("F2");
        }

        private TextBox textBoxStudentID;
        private TextBox textBoxProjectID;
        private TextBox textBoxStudentName;
        private TextBox textBoxStudentNumber;
        private TextBox textBoxProjectTitle;
        private DataGridView dataGridView;
        private Label labelAverageScore;
        private Button buttonCalculate;
    }
} 
    
