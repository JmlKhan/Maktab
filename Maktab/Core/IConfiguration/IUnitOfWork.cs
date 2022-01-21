using Maktab.Core.IRepositories;

namespace Maktab.Core.IConfiguration
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        Task CompleteAsync();
    }
}
