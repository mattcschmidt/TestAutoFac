using System.Collections.ObjectModel;
using TestAutoFac_SingleInstance.Models;

namespace TestAutoFac_SingleInstance.ViewModels
{
    public interface IViewModelB
    {
        ObservableCollection<MyClass> MyClassCollection { get; }
    }
}