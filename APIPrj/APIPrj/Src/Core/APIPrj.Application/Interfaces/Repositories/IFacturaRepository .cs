using APIPrj.Application.DTOs;
using APIPrj.Domain.Factura.DTOs;
using APIPrj.Domain.Factura.Entities;
using APIPrj.Domain.Products.DTOs;
using APIPrj.Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPrj.Application.Interfaces.Repositories
{
    public interface IFacturaRepository : IGenericRepository<TblFactura>
    {
        Task<PaginationResponseDto<TblFacturaDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
