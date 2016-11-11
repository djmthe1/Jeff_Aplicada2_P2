using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Jeff_Aplicada2_P2
{
    public partial class RegistroArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        private void Limpiar()
        {
            ArticuloIdTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            ExistenciaTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
        }

        private void ObtenerValores(Articulos articulo)
        {
            int id, existencia, precio = 0;
            int.TryParse(ArticuloIdTextBox.Text, out id);
            articulo.ArticuloId = id;
            articulo.Descripcion = DescripcionTextBox.Text;
            int.TryParse(ExistenciaTextBox.Text, out existencia);
            articulo.Existencia = existencia;
            int.TryParse(PrecioTextBox.Text, out precio);
            articulo.Precio = precio;
        }

        private void DevolverValores(Articulos articulo)
        {
            ArticuloIdTextBox.Text = articulo.ArticuloId.ToString();
            DescripcionTextBox.Text = articulo.Descripcion;
            ExistenciaTextBox.Text = articulo.Existencia.ToString();
            PrecioTextBox.Text = articulo.Precio.ToString();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();
            ObtenerValores(articulo);
            if (ArticuloIdTextBox.Text == "")
            {
                Response.Write("<script>alert('Debe insertar un Id, Error al Buscar')</script>");
            }
            else
            {
                if (articulo.Buscar(articulo.ArticuloId))
                {
                    DevolverValores(articulo);
                }
                else
                {
                    Response.Write("<script>alert('Id no encontrado')</script>");
                    Limpiar();
                }
            }
        }
        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();
            ObtenerValores(articulo);
            if (ArticuloIdTextBox.Text == "")
            {
                if (DescripcionTextBox.Text != "" && ExistenciaTextBox.Text != "" && PrecioTextBox.Text != "")
                {
                    if (articulo.Insertar())
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
                if (DescripcionTextBox.Text != "" && ExistenciaTextBox.Text != "" && PrecioTextBox.Text != "")
                {
                    if (articulo.Editar())
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
            Articulos articulo = new Articulos();
            ObtenerValores(articulo);
            if (ArticuloIdTextBox.Text == "")
            {
                Response.Write("<script>alert('Debe insertar un Id')</script>");
            }
            else
            {
                if (articulo.Buscar(articulo.ArticuloId))
                {
                    if (articulo.Eliminar())
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