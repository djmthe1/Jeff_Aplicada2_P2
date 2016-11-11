using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jeff_Aplicada2_P2
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegistroVentasButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroVentas.aspx");
        }

        protected void RegistroArticulosButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroArticulos.aspx");
        }

        protected void ConsultaVentasButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultas/ConsultaArticulos.aspx");
        }

        protected void ConsultaArticulosButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultas/ConsultaVentas.aspx");
        }
    }
}