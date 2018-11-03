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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Baslik { get; set; }
        public string Buton1Baslik { get; set; }
        public string Buton2Baslik { get; set; }
        public string Mesaj { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelbaslik.Text = Baslik;
            label1.Text = Mesaj;
            bunifuFlatButton1.Text = Buton1Baslik;
            bunifuFlatButton2.Text = Buton2Baslik;
        }
    }
}
