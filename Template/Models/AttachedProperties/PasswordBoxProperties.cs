using System.Windows;
using System.Windows.Controls;

namespace Template.Models.AttachedProperties
{
    public class PasswordBoxProperties
    {
        public static readonly DependencyProperty MonitorPasswordProperty = 
            DependencyProperty.RegisterAttached("MonitorPassword", typeof(bool), typeof(PasswordBoxProperties), new PropertyMetadata(false, OnMonitorPasswordChange));

        private static void OnMonitorPasswordChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var passBox = d as PasswordBox;
            if (passBox == null)
                return;


            passBox.PasswordChanged -= PassBoxOnPasswordChanged;
            
            if ((bool) e.NewValue)
            {
                SetHasText(passBox);
                passBox.PasswordChanged += PassBoxOnPasswordChanged;
            }
        }

        private static void PassBoxOnPasswordChanged(object sender, RoutedEventArgs e)
        {
           SetHasText((PasswordBox)sender); 
        }

        public static void SetMonitorPassword(PasswordBox element, bool value)
        {
            element.SetValue( MonitorPasswordProperty, value);
        }

        public static bool GetMonitorPassword(PasswordBox element)
        {
            return (bool)element.GetValue(MonitorPasswordProperty);
        }
        
        
        
        public static readonly DependencyProperty HasTextProperty = 
            DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(PasswordBoxProperties), new PropertyMetadata(false));

        private static void SetHasText(PasswordBox element)
        {
            element.SetValue(HasTextProperty, element.SecurePassword.Length > 0);
        }

        public static bool GetHasText(PasswordBox element)
        {
            return (bool)element.GetValue(HasTextProperty);
        }

    }
}