using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class VentasDetalle
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ArticuloId { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public VentasDetalle(int ventaId, int articuloId, int cantidad, int precio)
        {
            this.VentaId = ventaId;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        public VentasDetalle()
        {

        }
    }
}
