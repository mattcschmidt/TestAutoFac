namespace TestAutoFac_SingleInstance.ViewModels
{
    public interface IMainViewModel
    {
        IViewModelA ViewModelA { get; }
        IViewModelB ViewModelB { get; }
    }
}