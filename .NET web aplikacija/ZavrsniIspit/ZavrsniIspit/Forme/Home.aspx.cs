using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZavrsniIspit.DLL;
using ZavrsniIspit.Model;

namespace ZavrsniIspit.Aplikacija
{
    public partial class ZavrsniIspit : System.Web.UI.Page
    {
        //dodavanje linka u gridview: u html dokumentu klik na Design -> klik na strelicu u gornjem desnom kutu gridview-a ->
        //Edit Columns -> odabrati HyperLinkField -> Add -> u DataNavigateUrlFields upisati naziv stupca iz kojeg uzimamo podatak koji šaljemo kao
        //parametar -> u DataNavigateUrlFormatString upisati url koji redirecta na novu formu sa parametrom (npr. DnevnaProizvodnja.aspx?Ime={0})
        //link se može dodati i ručno, preko koda

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                PrikaziPasmine();
            }
        }

        protected void lbPasmine_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziKraveOdabranePasmine();
            PrikaziPasmine();
        }

        private void PrikaziPasmine()
        {
            lbPasmine.DataSource = Repozitorij.DohvatiSvePasmine();
            lbPasmine.DataValueField = "IDPasmina";
            lbPasmine.DataTextField = "Naziv";
            lbPasmine.DataBind();
        }

        private void PrikaziKraveOdabranePasmine()
        {
            Repozitorij.PrikaziKraveOdabranePasmine(lbPasmine.SelectedItem.Text, gvKrave);
        }
    }
}