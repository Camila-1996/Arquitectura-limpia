using System;
using System.Collections.Generic;
using System.Text;

namespace APIPrj.Domain.Factura.Entities
{
    public class TblCliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; } = string.Empty;
        public int IdTipoCliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string RFC { get; set; } = string.Empty;

        public CatTipoCliente TipoCliente { get; set; }
    }
}
