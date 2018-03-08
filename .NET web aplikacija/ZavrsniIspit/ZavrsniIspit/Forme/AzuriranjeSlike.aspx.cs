using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZavrsniIspit.DLL;

namespace ZavrsniIspit.Forme
{
    public partial class AzuriranjeSlike : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String krava = Request.QueryString["Ime"];
            Repozitorij.PrikaziPutanjuDoSlikeOdabraneKrave(krava, lblPutanjaDoSlike);
        }

        protected void btnSpremiPutanju_Click(object sender, EventArgs e)
        {
            String krava = Request.QueryString["Ime"];

            try
            {
                Repozitorij.SpremiPutanju(txtPutanjaDoSlike, lblPutanjaDoSlike);
                lblInfo.ForeColor = Color.Green;
                lblInfo.Text = "Putanja do slike uspješno uređena!";
            }           
            catch(Exception ex)
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Greška kod uređivanja putanje do slike!";
            }

            Repozitorij.PrikaziPutanjuDoSlikeOdabraneKrave(krava, lblPutanjaDoSlike);
            txtPutanjaDoSlike.Text = "";
        }
    }
}