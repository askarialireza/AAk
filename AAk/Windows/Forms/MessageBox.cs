
namespace AAk.Windows.Forms
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

        public static System.Windows.Forms.DialogResult Show(string text)
        {
            return System.Windows.Forms.MessageBox.Show(text: text);
        }


        public static System.Windows.Forms.DialogResult Show(string text, string caption)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: System.Windows.Forms.MessageBoxOptions.RtlReading | System.Windows.Forms.MessageBoxOptions.RightAlign);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options, string helpFilePath)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options, bool displayHelpButton)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, displayHelpButton: displayHelpButton);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, string helpFilePath, System.Windows.Forms.HelpNavigator navigator)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: System.Windows.Forms.MessageBoxOptions.RtlReading | System.Windows.Forms.MessageBoxOptions.RightAlign, helpFilePath: helpFilePath, navigator: navigator);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options, string helpFilePath, System.Windows.Forms.HelpNavigator navigator)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath, navigator: navigator);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, string helpFilePath, string keyword)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath, keyword: keyword);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options, string helpFilePath, string keyword)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath, keyword: keyword);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, string helpFilePath, System.Windows.Forms.HelpNavigator navigator, object param)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath, navigator: navigator, param: param);
        }

        public static System.Windows.Forms.DialogResult Show(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options, string helpFilePath, System.Windows.Forms.HelpNavigator navigator, object param)
        {
            return System.Windows.Forms.MessageBox.Show(text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath, navigator: navigator, param: param);
        }
        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: System.Windows.Forms.MessageBoxOptions.RtlReading | System.Windows.Forms.MessageBoxOptions.RightAlign);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, string helpFilePath)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: System.Windows.Forms.MessageBoxOptions.RtlReading | System.Windows.Forms.MessageBoxOptions.RightAlign, helpFilePath: helpFilePath);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options, string helpFilePath)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, string helpFilePath, System.Windows.Forms.HelpNavigator navigator)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: System.Windows.Forms.MessageBoxOptions.RtlReading | System.Windows.Forms.MessageBoxOptions.RightAlign, helpFilePath: helpFilePath, navigator: navigator);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options, string helpFilePath, System.Windows.Forms.HelpNavigator navigator)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath, navigator: navigator);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, string helpFilePath, string keyword)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath, keyword: keyword);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options, string helpFilePath, string keyword)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath, keyword: keyword);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, string helpFilePath, System.Windows.Forms.HelpNavigator navigator, object param)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: System.Windows.Forms.MessageBoxOptions.RtlReading | System.Windows.Forms.MessageBoxOptions.RightAlign, helpFilePath: helpFilePath, navigator: navigator, param: param);
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon, System.Windows.Forms.MessageBoxDefaultButton defaultButton, System.Windows.Forms.MessageBoxOptions options, string helpFilePath, System.Windows.Forms.HelpNavigator navigator, object param)
        {
            return System.Windows.Forms.MessageBox.Show(owner: owner, text: text, caption: caption, buttons: buttons, icon: icon, defaultButton: defaultButton, options: options | System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading, helpFilePath: helpFilePath, navigator: navigator, param: param);
        }

    }
}
