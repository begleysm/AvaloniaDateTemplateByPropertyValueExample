using Avalonia.Controls;
using Avalonia.Controls.Templates;
using DateTemplateByPropertyValueExample.Enums;
using DateTemplateByPropertyValueExample.ViewModels;

namespace DateTemplateByPropertyValueExample.Selectors;

public class EmployeeTemplateSelector : IDataTemplate
{
    public IDataTemplate ExecutiveTemplate { get; set; }
    public IDataTemplate ManagerTemplate { get; set; }
    public IDataTemplate WorkerTemplate { get; set; }

    public Control Build(object? param)
    {
        if (param is EmployeeViewModel { EmployeeRole: Role.Executive })
        {
            return ExecutiveTemplate.Build(param);
        }
        if (param is EmployeeViewModel { EmployeeRole: Role.Manager })
        {
            return ManagerTemplate.Build(param);
        }
        if (param is EmployeeViewModel { EmployeeRole: Role.Worker })
        {
            return WorkerTemplate.Build(param);
        }

        return new TextBlock() { Text = "TextBlock: Unsupported Role" }; // Or throw exception
    }

    public bool Match(object? data)
    {
        return data is EmployeeViewModel;
    }
}