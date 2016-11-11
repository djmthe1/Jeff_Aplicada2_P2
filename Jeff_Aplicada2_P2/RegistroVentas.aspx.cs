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
                FechaTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
            ObtenerGridView();
        }

        private void ObtenerValores(Ventas venta)
        {
            int id, monto = 0;
            int.TryParse(VentaIdTextBox.Text, out id);
            venta.VentaId = id;
            venta.Fecha = FechaTextBox.Text;
            int.TryParse(MontoTextBox.Text, out monto);
            venta.Monto = monto;
            foreach(GridViewRow row in GridView.Rows)
            {
                venta.AgregarArticulos(Convert.ToInt32(row.Cells[0].Text), Convert.ToInt32(row.Cells[1].Text), Convert.ToInt32(row.Cells[2].Text));
            }
        }

        private void DevolverValores(Ventas venta)
        {
            VentaIdTextBox.Text = venta.VentaId.ToString();
            FechaTextBox.Text = venta.Fecha;
            MontoTextBox.Text = venta.Monto.ToString();
            foreach (var articulo in venta.detalle)
            {
                DataTable dt = (DataTable)ViewState["Articulos"];
                dt.Rows.Add(articulo.ArticuloId, articulo.Cantidad, articulo.Precio);
                ViewState["Articulos"] = dt;
                ObtenerGridView();
            }
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

        private void Monto()
        {
            int Anterior, presente = 0;
            int.TryParse(MontoTextBox.Text, out Anterior);
            int precio, cantidad, total = 0;
            int.TryParse(PrecioTextBox.Text, out precio);
            int.TryParse(CantidadTextBox.Text, out cantidad);
            total = precio * cantidad;
            presente = Anterior + total;
            MontoTextBox.Text = presente.ToString();
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CantidadTextBox.Text != "" && PrecioTextBox.Text != "")
                {
                    DataTable dtArticulos = (DataTable)ViewState["Articulos"];
                    dtArticulos.Rows.Add(DropDownList.SelectedValue, CantidadTextBox.Text, PrecioTextBox.Text);
                    ViewState["Articulos"] = dtArticulos;
                    ObtenerGridView();
                    Monto();
                }
                else
                {
                    Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
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