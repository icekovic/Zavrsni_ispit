using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using ZavrsniIspit.Model;

namespace ZavrsniIspit.DLL
{
    public static class Repozitorij
    {
        public static List<Pasmina> DohvatiSvePasmine()
        {
            List<Pasmina> pasmineLista = new List<Pasmina>();

            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                var pasmine = context.Pasminas;

                foreach(Pasmina pasmina in pasmine)
                {
                    pasmineLista.Add(pasmina);
                }
            }

            return pasmineLista;
        }

        public static void PrikaziKraveOdabranePasmine(string odabranaPasmina, GridView gvKrave)
        {
            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                var krave = from k in context.Kravas
                            join p in context.Pasminas                          
                            on k.PasminaID equals p.IDPasmina
                            join s in context.Slikas
                            on k.SlikaID equals s.IDSlika
                            where p.Naziv.Equals(odabranaPasmina)
                            select new
                            {
                                s.Putanja,
                                k.Ime,
                                p.Naziv,
                                k.DatumRodjenja,
                                k.JedinstveniVeterinarskiBroj,
                                k.DatumDolaskaNaFarmu,
                                k.BrojTeladi
                            };

                gvKrave.DataSource = krave.ToList();
                gvKrave.DataBind();
            }
        }

        public static void DohvatiDnevneProizvodnjeMlijeka(string krava, GridView gvProizvodnjaMlijeka)
        {
            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                var dnevnaKolicinaMlijeka = from kolicina in context.DnevnaProizvodnjaMlijekas
                                            join k in context.Kravas
                                            on kolicina.KravaID equals k.IDKrava
                                            where k.Ime.Equals(krava)
                                            select new
                                            {
                                                k.Ime,
                                                kolicina.DatumMuznje,
                                                kolicina.DnevnaKolicinaMlijekaLitre
                                            };

                gvProizvodnjaMlijeka.DataSource = dnevnaKolicinaMlijeka.ToList();
                gvProizvodnjaMlijeka.DataBind();
            }
        }

        public static void PrikaziPutanjuDoSlikeOdabraneKrave(string krava, Label lblPutanjaDoSlike)
        {
            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                var putanja = from s in context.Slikas
                              join k in context.Kravas
                              on s.IDSlika equals k.SlikaID
                              where k.Ime.Equals(krava)
                              select s;
                lblPutanjaDoSlike.Text = putanja.First().Putanja;
            }
        }

        public static void SpremiPutanju(TextBox txtPutanjaDoSlike, Label lblPutanjaDoSlike)
        {
            using (ZavrsniIspitEntities context = new ZavrsniIspitEntities())
            {
                string dohvacenaPutanjaDoSlike = lblPutanjaDoSlike.Text;
                string novaPutanjaDoSlike = "/" + txtPutanjaDoSlike.Text;

                var slika = context.Slikas.First(s => s.Putanja == dohvacenaPutanjaDoSlike);
                slika.Putanja = novaPutanjaDoSlike;
                context.SaveChanges();
            }
        }
    }
}