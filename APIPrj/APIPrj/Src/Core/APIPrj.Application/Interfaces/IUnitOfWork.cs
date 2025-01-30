using System.Threading.Tasks;

namespace APIPrj.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
