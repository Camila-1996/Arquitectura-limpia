using System.Threading.Tasks;
using APIPrj.Application.DTOs.Account.Requests;
using APIPrj.Application.DTOs.Account.Responses;
using APIPrj.Application.Wrappers;

namespace APIPrj.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
