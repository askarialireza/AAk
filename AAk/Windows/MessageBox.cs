
namespace AAk.Windows
{
    public static class MessageBox
    {
        static MessageBox()
        {
            AAk.Utils.MessageBox.ButtonManager.OK = "تایید";

            AAk.Utils.MessageBox.ButtonManager.No = "خیر";

            AAk.Utils.MessageBox.ButtonManager.Retry = "تلاش مجدد";

            AAk.Utils.MessageBox.ButtonManager.Yes = "بله";

            AAk.Utils.MessageBox.ButtonManager.Ignore = "ادامه";

            AAk.Utils.MessageBox.ButtonManager.Cancel = "لغو";

            AAk.Utils.MessageBox.ButtonManager.Register();
        }

        public static System.Windows.MessageBoxResult Show(string messageBoxText)
        {
            return System.Windows.MessageBox.Show(messageBoxText: messageBoxText);
        }

        public static System.Windows.MessageBoxResult Show(string messageBoxText, string caption)
        {
            return System.Windows.MessageBox.Show(messageBoxText: messageBoxText, caption: caption);
        }

        public static System.Windows.MessageBoxResult Show(string messageBoxText, string caption, System.Windows.MessageBoxButton button)
        {
            return System.Windows.MessageBox.Show(messageBoxText: messageBoxText, caption: caption, button: button);
        }

        public static System.Windows.MessageBoxResult Show(string messageBoxText, string caption, System.Windows.MessageBoxButton button, System.Windows.MessageBoxImage icon)
        {
            return System.Windows.MessageBox.Show(messageBoxText: messageBoxText, caption: caption, button: button, icon: icon);
        }

        public static System.Windows.MessageBoxResult Show(string messageBoxText, string caption, System.Windows.MessageBoxButton button, System.Windows.MessageBoxImage icon, System.Windows.MessageBoxResult defaultResult)
        {
            return System.Windows.MessageBox.Show(messageBoxText: messageBoxText, caption: caption, button: button, icon: icon, defaultResult: defaultResult, options: System.Windows.MessageBoxOptions.RightAlign | System.Windows.MessageBoxOptions.RtlReading);
        }

        public static System.Windows.MessageBoxResult Show(string messageBoxText, string caption, System.Windows.MessageBoxButton button, System.Windows.MessageBoxImage icon, System.Windows.MessageBoxResult defaultResult, System.Windows.MessageBoxOptions options)
        {
            return System.Windows.MessageBox.Show(messageBoxText: messageBoxText, caption: caption, button: button, icon: icon, defaultResult: defaultResult, options: options | System.Windows.MessageBoxOptions.RightAlign | System.Windows.MessageBoxOptions.RtlReading);
        }
        
    }
}
