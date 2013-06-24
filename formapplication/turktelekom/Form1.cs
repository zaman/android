using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using turktelekom.model;


namespace turktelekom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            TurkTelekomEntities dbContext = new TurkTelekomEntities();

            var kampanya = new Kampanya();

            try
            {
                kampanya.baslik = txtBoxBaslik.Text;
                kampanya.icerik = TxtBoxIcerik.Text;
                kampanya.secenek = comboSecenek.Text;
                kampanya.tur = txtComboTur.Text;

                dbContext.Kampanyas.Add(kampanya);
                dbContext.SaveChanges();

                MessageBox.Show("Kaydedildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxTur_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
