using System.Threading.Tasks;
using LibraryProject.Configuration.Dto;

namespace LibraryProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
