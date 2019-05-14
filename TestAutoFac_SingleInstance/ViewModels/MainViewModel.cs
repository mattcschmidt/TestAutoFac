using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutoFac_SingleInstance.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
        public MainViewModel(IViewModelA viewModelA,
            IViewModelB viewModelB)
        {
            ViewModelA = viewModelA;
            ViewModelB = viewModelB;
        }

        public IViewModelA ViewModelA { get; }
        public IViewModelB ViewModelB { get; }
    }
}
