using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZavrsniIspit.DLL
{
    public static class Repozitorij
    {
        public static void PrikaziSveKrave(ListBox lbKrave)
        {
            lbKrave.Items.Clear();
            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                var krave = context.Kravas;
                foreach(Krava krava in krave)
                {
                    lbKrave.Items.Add(krava.Ime);
                }
            }
        }

        public static void PrikaziDetaljeOdabraneKrave(ListBox lbKrave, Form1 forma)
        {
            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                var krava = context.Kravas.First(k => k.Ime == lbKrave.Text);
                forma.SetIme(krava.Ime);
                forma.SetDatumRodjenja(krava.DatumRodjenja.ToShortDateString());
                forma.SetJedinstveniVeterinarskiBroj(krava.JedinstveniVeterinarskiBroj);
                forma.SetDatumDolaskaNaFarmu(krava.DatumDolaskaNaFarmu.ToShortDateString());
                forma.SetBrojTeladi(krava.BrojTeladi);
            }
        }

        public static void PrikaziPasminuOdabraneKrave(Form1 forma, TextBox txtIme)
        {
            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                var pasmina = from p in context.Pasminas
                              join k in context.Kravas on p.IDPasmina equals k.PasminaID
                              where k.Ime == txtIme.Text
                              select new
                              {
                                  p.Naziv
                              };
                //da se vraća više vrijednosti, bilo bi select p
                forma.SetPasmina(pasmina.First().Naziv);    //first se uvijek koristi za dohvacanje samo jednog retka
            }
        }

        public static void AzurirajKravu(TextBox txtIme, TextBox txtPasmina, TextBox txtDatumRodjenja, TextBox txtJedinstveniVeterinarskiBroj, TextBox txtDatumDolaskaNaFarmu, NumericUpDown txtBrojTeladi)
        {
            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                try
                {
                    string ime = txtIme.Text;
                    var krava = context.Kravas.First(k => k.Ime == ime);
                    krava.Ime = ime;
                    krava.JedinstveniVeterinarskiBroj = txtJedinstveniVeterinarskiBroj.Text;
                    krava.DatumRodjenja = Convert.ToDateTime(txtDatumRodjenja.Text);
                    krava.DatumDolaskaNaFarmu = Convert.ToDateTime(txtDatumDolaskaNaFarmu.Text);
                    krava.BrojTeladi = int.Parse(txtBrojTeladi.Value.ToString());
                    krava.Pasmina.Naziv = txtPasmina.Text;
                    context.SaveChanges();
                }
                
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void UmetniKravu(TextBox txtIme, TextBox txtPasmina, TextBox txtDatumRodjenja, TextBox txtJedinstveniVeterinarskiBroj, TextBox txtDatumDolaskaNaFarmu, NumericUpDown txtBrojTeladi)
        {
            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                try
                {
                    Krava krava = new Krava();
                    krava.Ime = txtIme.Text;
                    krava.JedinstveniVeterinarskiBroj = txtJedinstveniVeterinarskiBroj.Text;
                    krava.DatumRodjenja = Convert.ToDateTime(txtDatumRodjenja.Text);
                    krava.DatumDolaskaNaFarmu = Convert.ToDateTime(txtDatumDolaskaNaFarmu.Text);
                    krava.BrojTeladi = int.Parse(txtBrojTeladi.Value.ToString());
                    krava.Pasmina.Naziv = txtPasmina.Text;
                    context.Kravas.Add(krava);
                    context.SaveChanges();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void ObrisiKravu(TextBox txtIme)
        {
            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                try
                {
                    string ime = txtIme.Text;
                    var krava = context.Kravas.First(k => k.Ime == ime);
                    context.Kravas.Remove(krava);
                    context.SaveChanges();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }
    }
}
