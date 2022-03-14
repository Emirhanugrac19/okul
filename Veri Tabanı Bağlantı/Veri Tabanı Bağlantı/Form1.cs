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

namespace Veri_Tabanı_Bağlantı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataTable dt;
        OleDbCommand com;
        private void Form1_Load(object sender, EventArgs e)
        {
            gridEkle();
        }

        private void gridEkle()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source = personel1.accdb");
            da = new OleDbDataAdapter("select * from Personel", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            com = new OleDbCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into personel (Adi,Soyadi,Ana_adi,Baba_adi) values ('"+txtAdi.Text+"','"+txtSoyadi.Text+"','"+txtAnaAdi.Text+"','"+txtBabaAdi.Text+"')";
            com.ExecuteNonQuery();
            con.Close();
            gridEkle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            com = new OleDbCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "delete from Personel where Personel_id="+txtPersonel_id.Text+"";
            com.ExecuteNonQuery();
            con.Close();
            gridEkle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonel_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAnaAdi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBabaAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            com = new OleDbCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "update Personel set Adi='" + txtAdi.Text + "',Soyadi='" + txtSoyadi.Text + "',Ana_adi='" + txtAnaAdi.Text + "',Baba_adi='" +txtBabaAdi.Text+"' where Personel_id=" + txtPersonel_id.Text + "";
            com.ExecuteNonQuery();
            con.Close();
            gridEkle();
        }
    }
}
