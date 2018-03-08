using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZavrsniIspit.DLL;

namespace ZavrsniIspit.Aplikacija
{
    public partial class DnevnaProizvodnja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String krava = Request.QueryString["Ime"];
            Repozitorij.DohvatiDnevneProizvodnjeMlijeka(krava, gvProizvodnjaMlijeka);
        }
    }
}