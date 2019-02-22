using System.Threading.Tasks;
using Abp.Application.Services;
using SimpleTaskSystem.Configuration.Dto;

namespace SimpleTaskSystem.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}