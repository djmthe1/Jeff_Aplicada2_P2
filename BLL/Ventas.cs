using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Ventas : ClaseMaestra
    {
        public int VentaId { get; set; }
        public string Fecha { get; set; }
        public int Monto { get; set; }
        public List<VentasDetalle> detalle { get; set; }

        public Ventas(int ventaId, string fecha, int monto)
        {
            this.VentaId = ventaId;
            this.Fecha = fecha;
            this.Monto = monto;
        }

        public Ventas()
        {
            detalle = new List<VentasDetalle>();
        }

        public void AgregarArticulos(int ventaId, int articuloId, int cantidad, int precio)
        {
            this.detalle.Add(new VentasDetalle(ventaId, articuloId, cantidad, precio));
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            int retorno = 0;
            object Identity;
            try
            {
                Identity = conexion.ObtenerValor(string.Format("INSERT INTO Ventas (Fecha, Monto) VALUES ('{0}',{1}) SELECT @@Identity", this.Fecha, this.Monto));
                int.TryParse(Identity.ToString(), out retorno);
                if (retorno > 0)
                {
                    foreach (VentasDetalle articulos in detalle)
                    {
                        conexion.Ejecutar(string.Format("INSERT INTO VentasDetalle (VentaId, ArticuloId, Cantidad, Precio) VALUES ({0},{1},{2},{3})", retorno, articulos.ArticuloId, articulos.Cantidad, articulos.Precio));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno > 0;
        }

        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("UPDATE Ventas SET Fecha='{0}', Monto={1} WHERE VentaId={2}", this.Fecha, this.Monto, this.VentaId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("DELETE FROM VentasDetalle WHERE VentaId={0}", this.VentaId));
                    foreach (VentasDetalle articulos in detalle)
                    {
                        conexion.Ejecutar(string.Format("INSERT INTO VentasDetalle (VentaId, ArticuloId, Cantidad, Precio) VALUES ({0},{1},{2},{3})", retorno, articulos.ArticuloId, articulos.Cantidad, articulos.Precio));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("DELETE FROM VentasDetalle WHERE VentaId={0}", this.VentaId));
                if(retorno)
                    conexion.Ejecutar(string.Format("DELETE FROM Ventas WHERE VentaId={0}", this.VentaId));
                
            }
            catch (Exception e)
            {
                throw e;
            }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            DataTable dtArticulos = new DataTable();
            dt = conexion.ObtenerDatos("SELECT * FROM Ventas WHERE VentaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.VentaId = (int)dt.Rows[0]["VentaId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.Monto = (int)dt.Rows[0]["Monto"];

                dtArticulos = conexion.ObtenerDatos("SELECT * FROM VentasDetalle WHERE VentaId=" + IdBuscado);
                foreach (DataRow row in dtArticulos.Rows)
                {
                    this.AgregarArticulos((int)dt.Rows[0]["VentaId"], (int)dt.Rows[0]["ArticuloId"], (int)dt.Rows[0]["Cantidad"], (int)dt.Rows[0]["Precio"]);
                }
            }
            return dt.Rows.Count > 0;

        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            return conexion.ObtenerDatos(("SELECT " + Campos + " FROM Ventas WHERE " + Condicion + Orden));
        }
    }
}
