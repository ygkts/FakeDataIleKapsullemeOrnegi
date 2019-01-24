using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FakeData;

namespace u1_OrnekInsanOzellikleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ogrenci> olist = new List<Ogrenci>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Id = i;
                ogr.Ad = NameData.GetFirstName();   // fakedata dan aldık
                ogr.Soyad = NameData.GetSurname();
                ogr.BolumId = NumberData.GetNumber(10); // 0 la 10 arası numara getirir
                ogr.TcKimlikNo = NumberData.GetNumber(12311232, 999999999);

                ogr.AdresNesnesi.Sokak = PlaceData.GetStreetName();
                ogr.AdresNesnesi.Cadde = NumberData.GetNumber(100);
                ogr.AdresNesnesi.KapiNo = NumberData.GetNumber(200);

                olist.Add(ogr);
            }
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = olist;
            dataGridView1.Columns[5].Visible = false;   // 5. kolonu bize göstermesin 

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Ogrenci secilenOgrenci = (Ogrenci)dataGridView1.CurrentRow.DataBoundItem;
            txtAd.Text = secilenOgrenci.Ad;
            txtSoyad.Text = secilenOgrenci.Soyad;
            txtTcNo.Text = secilenOgrenci.TcKimlikNo.ToString();

            List<string> alist = secilenOgrenci.GetAdres();
            listBoxAdres.Items.Clear();
            foreach (var item in alist)
            {
                listBoxAdres.Items.Add(item);
            }

            string[] adresDizi = new string[3];
            adresDizi = secilenOgrenci.GetAdres1();
            listBoxAdres2.Items.Clear();
            foreach (var item in adresDizi)
            {
                listBoxAdres2.Items.Add(item);
            }
        }
    }
}
