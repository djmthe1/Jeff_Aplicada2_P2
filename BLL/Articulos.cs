using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Articulos : ClaseMaestra
    {
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public int Precio { get; set; }

        public Articulos(int articuloId, string descripcion, int existencia, int precio)
        {
            this.ArticuloId = articuloId;
            this.Descripcion = descripcion;
            this.Existencia = existencia;
            this.Precio = precio;
        }

        public Articulos()
        {

        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("INSERT INTO Articulos (Descripcion, Existencia, Precio) VALUES ('{0}',{1},{2})", this.Descripcion, this.Existencia, this.Precio));
                return retorno;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("UPDATE Articulos SET Descripcion='{0}', Existencia={1}, Precio={2} WHERE ArticuloId={3}", this.Descripcion, this.Existencia, this.Precio, this.ArticuloId));
                return retorno;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno;
            try
            {
                retorno = conexion.Ejecutar(string.Format("DELETE FROM Articulos WHERE ArticuloId={0}", this.ArticuloId));
                return retorno;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("SELECT * FROM Articulos WHERE ArticuloId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.ArticuloId = (int)dt.Rows[0]["ArticuloId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Existencia = (int)dt.Rows[0]["Existencia"];
                this.Precio = (int)dt.Rows[0]["Precio"];
            }
            return dt.Rows.Count > 0;
            throw new NotImplementedException();
        }
        
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            return conexion.ObtenerDatos(("SELECT " + Campos + " FROM Articulos WHERE " + Condicion + Orden));
        }
    }
}
