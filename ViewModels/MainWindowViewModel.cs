using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using DateTemplateByPropertyValueExample.Enums;
using ReactiveUI;

namespace DateTemplateByPropertyValueExample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<EmployeeViewModel> Employees { get => employees; set => this.RaiseAndSetIfChanged(ref employees, value); }
    private ObservableCollection<EmployeeViewModel> employees;

    public MainWindowViewModel()
    {
        Employees = new ObservableCollection<EmployeeViewModel>()
        {
            new EmployeeViewModel(Role.Executive),
            new EmployeeViewModel(Role.Manager),
            new EmployeeViewModel(Role.Worker),
            new EmployeeViewModel(Role.Undefined),
        };
    }
}