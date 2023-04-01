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

namespace SalesManagment2Project
{
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet7.musteribil' table. You can move, or remove it, as needed.
            this.musteribilTableAdapter1.Fill(this.database1DataSet7.musteribil);
            // TODO: This line of code loads data into the 'database1DataSet1.musteribil' table. You can move, or remove it, as needed.
            this.musteribilTableAdapter.Fill(this.database1DataSet1.musteribil);
            frm1.musteriListele();
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Müşteri Adı";
                dataGridView1.Columns[1].HeaderText = "Müşteri Soyadı";
                dataGridView1.Columns[2].HeaderText = "Tc Kimlik";
                dataGridView1.Columns[3].HeaderText = "Cep Tel";
                dataGridView1.Columns[4].HeaderText = "Ev Tel";
                dataGridView1.Columns[5].HeaderText = "Adres";
            }
            catch
            {
                ;
            }
        }
       

        private void ekle_click(object sender, EventArgs e)
        {
            frm1.frm5.ShowDialog();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz",
               "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes &&
               dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
                {
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "DELETE from musteribil WHERE tcKimlik='" +
                    dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    frm1.musteriListele();
                }
            }
            catch
            {
               
                 ;
            }

        }

        private void Kapat(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void ara_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select musteriAdi, musteriSoyadi, tcKimlik, cepTel, evTel, adres From musteribil", frm1.bag);
 string alan = "";
            if (comboBox1.Text == "Müşteri Adı") alan = "musteriAdi";
            //eğer combo1 in metni Müşteri Adı ise alan değişkine musteriAdi a eşitle  yani combo1 de Müşteri Adı seçeneği seçiliyse
 else if (comboBox1.Text == "Müşteri Soyadı") alan = "musteriSoyadi";
            else if (comboBox1.Text == "Tc Kimlik") alan = "tcKimlik";
            else if (comboBox1.Text == "Cep Tel") alan = "cepTel";
            else if (comboBox1.Text == "Ev Tel") alan = "evTel";
            else if (comboBox1.Text == "Adres") alan = "adres";
            if (comboBox1.Text == "Tümü")//eğer texbox boş ise
            {
                frm1.bag.Open();
                frm1.tabloMusteri.Clear();
                frm1.kmt.Connection = frm1.bag;
                frm1.kmt.CommandText = "Select musteriAdi,musteriSoyadi,tcKimlik,cepTel,evTel,adres from musteribil";//tüm kayıtları seç
            adtr.SelectCommand = frm1.kmt;
                adtr.Fill(frm1.tabloMusteri);
                frm1.bag.Close();
            }
            if (alan != "")
            {
                frm1.bag.Open();
                adtr.SelectCommand.CommandText = " Select musteriAdi,musteriSoyadi,tcKimlik,cepTel,evTel,adres From musteribil" + " where(" + alan + 
           " like '%" + textBox1.Text + "%' )";
                // textbox1 e girilen değerin belitilen alan içinde geçenleri seç
                frm1.tabloMusteri.Clear();
                adtr.Fill(frm1.tabloMusteri);//tabloMusteri sanal tablosunu adaptör ile doldur.
                 frm1.bag.Close();
            }
        }
    }
}
