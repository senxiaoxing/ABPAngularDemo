using System.Threading.Tasks;
using ABPAngular.Configuration.Dto;

namespace ABPAngular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
