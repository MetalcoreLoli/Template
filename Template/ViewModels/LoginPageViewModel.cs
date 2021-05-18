namespace Template.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        private string _loginLabelText = "Login";
        private string _passwordLabelText = "Password";
        private string _enterButtonText = "Enter";

        public string LoginLabelText
        {
            get => _loginLabelText;
            set => SetProperty(ref _loginLabelText, value);
        }

        public string PasswordLabelText
        {
            get => _passwordLabelText;
            set => SetProperty(ref _passwordLabelText, value);
        }
        
        public string EnterButtonText
        {
            get => _enterButtonText;
            set => SetProperty(ref _enterButtonText, value);
        }
    }
}