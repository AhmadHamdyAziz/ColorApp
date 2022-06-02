using System.Threading.Tasks;
using Abp.Application.Services;
using ColorApp.Authorization.Accounts.Dto;

namespace ColorApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
