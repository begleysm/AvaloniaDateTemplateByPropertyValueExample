using Avalonia.Controls;
using Avalonia.Controls.Templates;
using DateTemplateByPropertyValueExample.Enums;
using ReactiveUI;

namespace DateTemplateByPropertyValueExample.ViewModels;



public class EmployeeViewModel : ViewModelBase
{
    public Role EmployeeRole { get => employeeRole; set => this.RaiseAndSetIfChanged(ref employeeRole, value); }
    private Role employeeRole;

    public EmployeeViewModel(Role employee_role)
    {
        EmployeeRole = employee_role;
    }
}