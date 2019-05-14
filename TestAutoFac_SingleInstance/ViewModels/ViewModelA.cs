using Prism.Mvvm;
using System.Collections.ObjectModel;
using TestAutoFac_SingleInstance.Models;

namespace TestAutoFac_SingleInstance.ViewModels
{

    public class ViewModelA : BindableBase, IViewModelA
    {
        private MyClassList _myClass;

        public ObservableCollection<MyClass> MyClassCollection { get; private set; }
        public ViewModelA(MyClassList myClassList)
        {
            _myClass = myClassList;
            MyClassCollection = new ObservableCollection<MyClass>(_myClass.myClassList);
        }


    }
}
