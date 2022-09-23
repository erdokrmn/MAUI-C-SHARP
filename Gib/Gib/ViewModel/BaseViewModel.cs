using CommunityToolkit.Mvvm.ComponentModel;


namespace Gib.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        [ObservableProperty]
        bool isBusy;

        [ObservableProperty]
        string title;

        public bool IsNotBusy => !IsBusy;
    }
}
