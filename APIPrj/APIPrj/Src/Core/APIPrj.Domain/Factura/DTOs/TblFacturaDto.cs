using System;
using System.Collections.Generic;
using System.Text;

namespace APIPrj.Domain.Factura.DTOs
{
    public class TblFacturaDto
    {
        public int Id { get; set; }
        public DateTime FechaEmisionFactura { get; set; }
        public int IdCliente { get; set; }
        public int NumeroFactura { get; set; }
        public int NumeroTotalArticulos { get; set; }
        public decimal SubTotalFacturas { get; set; }
        public decimal TotalImpuestos { get; set; }
        public decimal TotalFactura { get; set; }
    }
}
