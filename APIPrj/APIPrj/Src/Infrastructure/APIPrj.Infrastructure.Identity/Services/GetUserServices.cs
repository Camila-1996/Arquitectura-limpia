using System.Linq;
using System.Threading.Tasks;
using APIPrj.Application.DTOs;
using APIPrj.Application.DTOs.Account.Requests;
using APIPrj.Application.DTOs.Account.Responses;
using APIPrj.Application.Interfaces.UserInterfaces;
using APIPrj.Application.Wrappers;
using APIPrj.Infrastructure.Identity.Contexts;
using Microsoft.EntityFrameworkCore;

namespace APIPrj.Infrastructure.Identity.Services
{
    public class GetUserServices(IdentityContext identityContext) : IGetUserServices
    {
        public async Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model)
        {
            var skip = (model.PageNumber - 1) * model.PageSize;

            var users = identityContext.Users
                .Select(p => new UserDto()
                {
                    Name = p.Name,
                    Email = p.Email,
                    UserName = p.UserName,
                    PhoneNumber = p.PhoneNumber,
                    Id = p.Id,
                    Created = p.Created,
                });

            if (!string.IsNullOrEmpty(model.Name))
            {
                users = users.Where(p => p.Name.Contains(model.Name));
            }

            return new PaginationResponseDto<UserDto>(
                await users.Skip(skip).Take(model.PageSize).ToListAsync(),
                await users.CountAsync(),
                model.PageNumber,
                model.PageSize);

        }
    }
}
