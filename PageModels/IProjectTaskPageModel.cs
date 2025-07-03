using CommunityToolkit.Mvvm.Input;
using RichiMaui.Models;

namespace RichiMaui.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}