using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Veri_Tabanı_Bağlantı2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable table;
        OleDbCommand command;
        private void gridEkle()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source = Başvuru.accdb");
            dataAdapter = new OleDbDataAdapter("select * from Bilgiler", connection);
           
            connection.Open();
            table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;

            connection.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            command = new OleDbCommand();
            
            connection.Open();
            command.Connection = connection;
            command.CommandText = "insert into Bilgiler (Adi,Soyadi,DoğumTarihi,KardesSayisi,Cinsiyet,NotOrtalamasi,AylikGeliri,EgitimDurumu,DahaOnceBasvuruYaptiMi) values(@adi,@soyadi,@dogumTarihi,@kardesSayisi,@cinsiyet,@notOrtalamasi,@aylikGelir,@egitimDurumu,@basvuru)";
            command.Parameters.AddWithValue("@adi", txtAdi.Text);
            command.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
            command.Parameters.AddWithValue("@dogumTarihi", dtpDogumTarihi.Value.ToShortDateString());
            command.Parameters.AddWithValue("@kardesSayisi", int.Parse(txtKardesSayisi.Text));
            if (rdbErkek.Checked)
                command.Parameters.AddWithValue("@cinsiyet", rdbErkek.Text);
            else if(rdbKadin.Checked)
                command.Parameters.AddWithValue("@cinsiyet", rdbKadin.Text);
            command.Parameters.AddWithValue("@notOrtalamasi", double.Parse(txtNotOrtalamasi.Text));
            command.Parameters.AddWithValue("@aylikGeliri", decimal.Parse(txtAylikGeliri.Text));
            command.Parameters.AddWithValue("@egitimDurumu", cmbEgitimDurumu.Text);
            if (chbDahaOnceBasvuruYaptiMi.Checked)
                command.Parameters.AddWithValue("@basvuru", true);
            else
                command.Parameters.AddWithValue("@basvuru", false);
            command.ExecuteNonQuery();
            connection.Close();
            gridEkle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridEkle();
        }
    }
}
