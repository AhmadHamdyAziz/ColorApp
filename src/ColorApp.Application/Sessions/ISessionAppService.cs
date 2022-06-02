using System.Threading.Tasks;
using Abp.Application.Services;
using ColorApp.Sessions.Dto;

namespace ColorApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
