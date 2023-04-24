using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace At_Yarışı_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Birnumaralıat, İkinumaralıat, Üçnumaralıat, Dörtnumartalıat, Beşnumaralıat, Altınumaralıat;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinize Eminmisiniz..", "Enes Doğan", MessageBoxButtons.YesNo);
            if (sonuc==DialogResult.Yes)
            {
                e.Cancel = false;
                return;
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
         
            pictureBox1.Left = Birnumaralıat;
            pictureBox2.Left = İkinumaralıat;
            pictureBox3.Left = Üçnumaralıat;
            pictureBox4.Left = Dörtnumartalıat;
            pictureBox5.Left = Beşnumaralıat;
            pictureBox6.Left = Altınumaralıat;
      

            label9.Text = "";
            label10.Text = "0";
            timer1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece;
            derece= int.Parse(label10.Text);
            derece++;
            label10.Text = derece.ToString();


            int birinciatıngenıslıgı = pictureBox1.Width;
            int ikinciatıngenıslıgı = pictureBox2.Width;
            int ücüncüatıngenıslıgı = pictureBox3.Width;
            int dortuncuatıngenıslıgı = pictureBox4.Width;
            int besıncıatıngenıslıgı = pictureBox5.Width;
            int altıncıatıngenıslıgı = pictureBox6.Width;

            int bıtısuzaklıgı = label8.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next (5,15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(5, 15);
            pictureBox5.Left = pictureBox5.Left + rastgele.Next(5, 15);
            pictureBox6.Left = pictureBox6.Left + rastgele.Next(5, 15);


            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label9.Text = "1 Numaralı ABDÜLHAMİT Yarışı Önde Götürüyor.";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label9.Text = "2 Numaralı ABAT OĞLU Yarışı Öne Geçti.";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label9.Text = "3 Numaralı A RED RAY Yarışı Ele Geçirdi. ";
            }
            if (pictureBox4.Left > pictureBox2.Left + 5 && pictureBox4.Left > pictureBox3.Left + 5)
            {
                label9.Text = "4 Numaralı ABDİ AĞA Yarışda herkesi geçti. ";
            }
            if (pictureBox5.Left > pictureBox1.Left + 5 && pictureBox5.Left > pictureBox3.Left + 5)
            {
                label9.Text = "5 Numaralı ABAHAN Yarışda öne gecti.. ";
            }
            if (pictureBox6.Left > pictureBox1.Left + 5 && pictureBox6.Left > pictureBox2.Left + 5)
            {
                label9.Text = "6 Numaralı ABANA BEYİ Yarışda çok koşuyor... ";
            }


            if (birinciatıngenıslıgı + pictureBox1.Left >= bıtısuzaklıgı)
            {
                timer1.Enabled = false;
                label9.Text = "1 Numaralı ABDÜLHAMİT Yarışı Kazandı...";
            }
            if (ikinciatıngenıslıgı + pictureBox2.Left >= bıtısuzaklıgı)
            {
                timer1.Enabled = false;
                label9.Text = "2 Numaralı ABAT OĞLU Yarışı Kazandı...";
            }
            if (ücüncüatıngenıslıgı + pictureBox3.Left >= bıtısuzaklıgı)
            {
                timer1.Enabled = false;
                label9.Text = "3 Numaralı A RED RAY Yarışı Kazandı";
            }
            if (dortuncuatıngenıslıgı + pictureBox4.Left >= bıtısuzaklıgı)
            {
                timer1.Enabled = false;
                label9.Text = "4 Numaralı ABDİ AĞA Yarışı Kazandı";
            }
            if (besıncıatıngenıslıgı + pictureBox5.Left >= bıtısuzaklıgı)
            {
                timer1.Enabled = false;
                label9.Text = "5 Numaralı ABAHAN Yarışı Kazandı";
            }
            if (altıncıatıngenıslıgı + pictureBox6.Left >= bıtısuzaklıgı)
            {
                timer1.Enabled = false;
                label9.Text = "6 Numaralı ABANA BEYİ Yarışı Kazandı";
            }
            
        }

        Random rastgele = new Random();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Birnumaralıat = pictureBox1.Left;
            İkinumaralıat = pictureBox2.Left;
            Üçnumaralıat = pictureBox3.Left;
            Dörtnumartalıat = pictureBox4.Left;
            Beşnumaralıat = pictureBox5.Left;
            Altınumaralıat = pictureBox6.Left;


           
        }
    }
}
