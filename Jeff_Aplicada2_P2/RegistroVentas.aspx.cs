using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace Jeff_Aplicada2_P2
{
    public partial class RegistroVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            if (!IsPostBack)
            {
                LLenarDropDownList();
                LLenarGridView();
            }
        }

        private void LLenarDropDownList()
        {
            Articulos articulo = new Articulos();
            DropDownList.DataSource = articulo.Listado("*", "1=1", "");
            DropDownList.DataTextField = "Descripcion";
            DropDownList.DataValueField = "ArticuloId";
            DropDownList.DataBind();
        }

        private void LLenarGridView()
        {
            DataTable dtArticulos = new DataTable();
            dtArticulos.Columns.AddRange(new DataColumn[3]
            {
              new DataColumn("Descripcion"),
              new DataColumn("Cantidad"),
              new DataColumn("Precio")
            });
            ViewState["Articulos"] = dtArticulos;
        }

        private void ObtenerGridView()
        {
            GridView.DataSource = (DataTable) ViewState["Articulos"];
            GridView.DataBind();
        }

        private void Limpiar()
        {
            VentaIdTextBox.Text = string.Empty;
            FechaTextBox.Text = string.Empty;
            MontoTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            CantidadTextBox.Text = "1";
            LLenarGridView();
        }

        private void ObtenerValores(Ventas venta)
        {
            int id, monto = 0;
            int.TryParse(VentaIdTextBox.Text, out id);
            venta.VentaId = id;
            venta.Fecha = FechaTextBox.Text;
            int.TryParse(MontoTextBox.Text, out monto);
            venta.Monto = monto;
        }

        private void DevolverValores(Ventas venta)
        {
            VentaIdTextBox.Text = venta.VentaId.ToString();
            FechaTextBox.Text = venta.Fecha;
            MontoTextBox.Text = venta.Monto.ToString();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            ObtenerValores(venta);
            if (VentaIdTextBox.Text == "")
            {
                Response.Write("<script>alert('Debe insertar un Id, Error al Buscar')</script>");
            }
            else
            {
                if (venta.Buscar(venta.VentaId))
                {
                    DevolverValores(venta);
                }
                else
                {
                    Response.Write("<script>alert('Id no encontrado')</script>");
                    Limpiar();
                }
            }
        }

        /*private void Monto()
        {

        }*/

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtArticulos = (DataTable) ViewState["Articulos"];
                dtArticulos.Rows.Add(DropDownList.SelectedValue, CantidadTextBox.Text, PrecioTextBox.Text);
                ObtenerGridView();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Error al agregar')</script>");
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            ObtenerValores(venta);
            if (VentaIdTextBox.Text == "")
            {
                if (FechaTextBox.Text != "" && MontoTextBox.Text != "")
                {
                    if (venta.Insertar())
                    {
                        Limpiar();
                        Response.Write("<script>alert('Insertado correctamente')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Error al insertar')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Debe llenar todos los campos, Error al insertar')</script>");
                }
            }
            else
            {
                if (FechaTextBox.Text != "" && MontoTextBox.Text != "")
                {
                    if (venta.Editar())
                    {
                        Limpiar();
                        Response.Write("<script>alert('Modificado correctamente')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Error al modificar')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Debe llenar todos los campos, Error al modificar')</script>");
                }
            }

        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            ObtenerValores(venta);
            if (VentaIdTextBox.Text == "")
            {
                Response.Write("<script>alert('Debe insertar un Id')</script>");
            }
            else
            {
                if (venta.Buscar(venta.VentaId))
                {
                    if (venta.Eliminar())
                    {
                        Response.Write("<script>alert('Eliminado correctamente')</script>");
                        Limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('Error al eliminar')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Id no encontrado')</script>");
                    Limpiar();
                }
            }

        }
    }
}