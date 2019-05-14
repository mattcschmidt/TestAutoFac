using Prism.Mvvm;
using System.Collections.ObjectModel;
using TestAutoFac_SingleInstance.Models;

namespace TestAutoFac_SingleInstance.ViewModels
{
    public class ViewModelB : BindableBase, IViewModelB
    {
        public ObservableCollection<MyClass> MyClassCollection { get; private set; }

        private MyClassList _myClass;

        public ViewModelB(MyClassList myClass)
        {
            _myClass = myClass;
            MyClassCollection = new ObservableCollection<MyClass>(_myClass.myClassList);
            

        }
    }
}
