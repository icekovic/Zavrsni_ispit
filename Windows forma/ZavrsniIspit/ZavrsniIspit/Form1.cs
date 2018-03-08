using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZavrsniIspit.DLL;

namespace ZavrsniIspit
{
    public partial class Form1 : Form
    {
        //broj teladi je NumericUpDown

        public Form1()
        {
            InitializeComponent();
        }

        public void SetIme(String Ime)
        {
            txtIme.Text = Ime;
        }

        public void SetPasmina(String Pasmina)
        {
            txtPasmina.Text = Pasmina;
        }

        public void SetDatumRodjenja(String DatumRodjenja)
        {
            txtDatumRodjenja.Text = DatumRodjenja;
        }

        public void SetJedinstveniVeterinarskiBroj(String JedinstveniVeterinarskiBroj)
        {
            txtJedinstveniVeterinarskiBroj.Text = JedinstveniVeterinarskiBroj;
        }

        public void SetDatumDolaskaNaFarmu(String DatumDolaskaNaFarmu)
        {
            txtDatumDolaskaNaFarmu.Text = DatumDolaskaNaFarmu;
        }

        public void SetBrojTeladi(int BrojTeladi)
        {
            txtBrojTeladi.Text = BrojTeladi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Repozitorij.PrikaziSveKrave(lbKrave);
        }

        private void lbKrave_SelectedIndexChanged(object sender, EventArgs e)
        {
            Repozitorij.PrikaziDetaljeOdabraneKrave(lbKrave, this);
            Repozitorij.PrikaziPasminuOdabraneKrave(this, txtIme);
            Repozitorij.PrikaziSveKrave(lbKrave);
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Repozitorij.AzurirajKravu(txtIme, txtPasmina, txtDatumRodjenja, txtJedinstveniVeterinarskiBroj, txtDatumDolaskaNaFarmu, txtBrojTeladi);
            Repozitorij.PrikaziSveKrave(lbKrave);

            //insert 
            //Repozitorij.UmetniKravu(txtIme, txtPasmina, txtDatumRodjenja, txtJedinstveniVeterinarskiBroj, txtDatumDolaskaNaFarmu, txtBrojTeladi);

            //delete
            //Repozitorij.ObrisiKravu(txtIme);
        }
    }
}