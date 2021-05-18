using System.ComponentModel;
using System.Runtime.CompilerServices;
using Template.Annotations;

namespace Template.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        protected void SetProperty<T>([NotNull] ref T destination, T value, [CallerMemberName] string prop = null)
        {
            destination = value;
            OnPropertyChanged(prop);
        }
    }
}