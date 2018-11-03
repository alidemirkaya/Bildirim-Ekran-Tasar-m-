using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp31
{
    public partial class MesajGonder : Form
    {
        public MesajGonder()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            PersonelKayıt();
        }
        public void PersonelKayıt()
        {
            Form1 fr = new Form1();
            fr.Baslik = "Personel Kayıt";
            fr.Buton1Baslik = "Kaydet";
            fr.Buton2Baslik = "İptal";
            fr.Mesaj = "Personel, \n"+textBox1.Text + textBox2.Text+"\n"+"kaydını onaylıyor musunuz ?" ;
            fr.Show();

        }
    }
}
