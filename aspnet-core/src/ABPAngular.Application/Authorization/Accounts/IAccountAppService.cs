using System.Threading.Tasks;
using Abp.Application.Services;
using ABPAngular.Authorization.Accounts.Dto;

namespace ABPAngular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
