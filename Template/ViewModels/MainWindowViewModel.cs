using Template.Models.DataModels;

namespace Template.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ApplicationPage _currentApplicationPage = ApplicationPage.ManagerMain;

        public ApplicationPage CurrentApplicationPage
        {
            get => _currentApplicationPage;
            set => SetProperty(ref _currentApplicationPage, value);
        }
    }
}