
using System.Windows;

namespace AAk.Windows.Controls
{
    public partial class DatePicker : System.Windows.Controls.UserControl
    {
        public AAk.Utils.PersianDate SelectedPersianDateTime { get; set; }

        public System.DateTime SelectedDateTime { get; set; }

        public string Text { get; set; }

        public DatePicker()
        {
            InitializeComponent();

            SelectedPersianDateTime = AAk.Utils.PersianDate.Now;

            PersianDateTextBox.Text = SelectedPersianDateTime.ToString("d");

            Text = PersianDateTextBox.Text;

            SelectedDateTime = AAk.Utils.PersianDateConverter.ToGregorianDateTime(SelectedPersianDateTime);
        }

        private void ToggleButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(PersianDateTextBox.Text.Trim())==true)
            {
                PersianDateTextBox.Focus();

                return;
            }

            System.Text.RegularExpressions.Regex oRegex =
                new System.Text.RegularExpressions.Regex(AAk.Text.RegularExpressions.Patterns.PersianDate);

            if(oRegex.IsMatch(PersianDateTextBox.Text) == true)
            {
                AAk.Utils.PersianDate oPersianDate = new AAk.Utils.PersianDate(PersianDateTextBox.Text);

                DatePickerPopupCalendar.SelectedDateTime = oPersianDate;

                DatePickerPopupCalendar.GoToDate(oPersianDate);

                SelectedDateTime = AAk.Utils.PersianDateConverter.ToGregorianDateTime(oPersianDate);

                SelectedPersianDateTime = oPersianDate;

                DatePickerPopup.IsOpen = true;
            }
            else
            {
                DatePickerPopupCalendar.GoToDate(SelectedPersianDateTime);

                SelectedDateTime = AAk.Utils.PersianDateConverter.ToGregorianDateTime(AAk.Utils.PersianDate.Today);

                SelectedPersianDateTime = AAk.Utils.PersianDate.Today;
            }

            Text = PersianDateTextBox.Text;
        }

        private void DatePickerPopupCalendar_SelectedDateTimeChanged_1(object sender, RoutedEventArgs e)
        {
            PersianDateTextBox.Text = DatePickerPopupCalendar.SelectedDateTime.ToString("d");

            DatePickerPopup.IsOpen = false;

            Text = PersianDateTextBox.Text;

            SelectedDateTime = AAk.Utils.PersianDateConverter.ToGregorianDateTime(DatePickerPopupCalendar.SelectedDateTime);

            SelectedPersianDateTime = DatePickerPopupCalendar.SelectedDateTime;
        }
    }
}
