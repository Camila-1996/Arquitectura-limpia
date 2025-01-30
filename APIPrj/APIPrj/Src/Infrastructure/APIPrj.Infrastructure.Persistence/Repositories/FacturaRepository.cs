using APIPrj.Application.DTOs;
using APIPrj.Application.Interfaces.Repositories;
using APIPrj.Domain.Factura.DTOs;
using APIPrj.Domain.Factura.Entities;
using APIPrj.Domain.Products.DTOs;
using APIPrj.Domain.Products.Entities;
using APIPrj.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPrj.Infrastructure.Persistence.Repositories
{
    public class FacturaRepository(ApplicationDbContext dbContext) : GenericRepository<TblFactura>(dbContext), IFacturaRepository
    {
        public async Task<PaginationResponseDto<TblFacturaDto>> GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            var query = dbContext.TblFacturas.OrderBy(p => p.Id).AsQueryable();

            return await Paged(
                query.Select(p => new TblFacturaDto()),
                pageNumber,
                pageSize);
        }

        Task<PaginationResponseDto<TblFacturaDto>> IFacturaRepository.GetPagedListAsync(int pageNumber, int pageSize, string name)
        {
            throw new NotImplementedException();
        }
    }
