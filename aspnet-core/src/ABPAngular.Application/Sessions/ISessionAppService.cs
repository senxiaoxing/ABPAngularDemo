using System.Threading.Tasks;
using Abp.Application.Services;
using ABPAngular.Sessions.Dto;

namespace ABPAngular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
