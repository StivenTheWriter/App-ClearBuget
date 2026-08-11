using CommunityToolkit.Mvvm.Input;
using ProyectMoney.FrontView.Models;

namespace ProyectMoney.FrontView.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}