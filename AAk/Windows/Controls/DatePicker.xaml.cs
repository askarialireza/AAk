
namespace AAk.Windows.Controls
{
    public partial class DatePicker : System.Windows.Controls.UserControl
    {
        public static readonly System.Windows.DependencyProperty SelectedPersianDateTimeProperty =
            System.Windows.DependencyProperty.Register("SelectedPerisanDateTime", typeof(AAk.Utils.PersianDate), typeof(DatePicker));

        public static readonly System.Windows.DependencyProperty SelectedDateTimeProperty =
            System.Windows.DependencyProperty.Register("SelectedDateTime", typeof(System.DateTime), typeof(DatePicker));

        public static readonly System.Windows.DependencyProperty TextProperty =
            System.Windows.DependencyProperty.Register("Text", typeof(string), typeof(DatePicker));

        public string Text
        {
            get
            {
                return (string)base.GetValue(TextProperty);
            }
            set
            {
                base.SetValue(TextProperty, value);
            }
        }


        public AAk.Utils.PersianDate SelectedPersianDateTime
        {
            get
            {
                return (AAk.Utils.PersianDate)base.GetValue(SelectedPersianDateTimeProperty);
            }
            set
            {
                base.SetValue(SelectedPersianDateTimeProperty, value);
            }
        }

        public System.DateTime SelectedDateTime
        {
            get
            {
                return (System.DateTime)base.GetValue(SelectedDateTimeProperty);
            }
            set
            {
                base.SetValue(SelectedDateTimeProperty, value);
            }
        }

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

                MonthView.SelectedDateTime = oPersianDate;

                MonthView.GoToDate(oPersianDate);

                SelectedDateTime = AAk.Utils.PersianDateConverter.ToGregorianDateTime(oPersianDate);

                SelectedPersianDateTime = oPersianDate;

                DatePickerPopup.IsOpen = true;
            }
            else
            {
                MonthView.GoToDate(SelectedPersianDateTime);

                SelectedDateTime = AAk.Utils.PersianDateConverter.ToGregorianDateTime(AAk.Utils.PersianDate.Today);

                SelectedPersianDateTime = AAk.Utils.PersianDate.Today;
            }

            Text = PersianDateTextBox.Text;
        }

        private void MonthView_SelectedDateTimeChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            PersianDateTextBox.Text = MonthView.SelectedDateTime.ToString("d");

            Text = PersianDateTextBox.Text;

            SelectedDateTime = AAk.Utils.PersianDateConverter.ToGregorianDateTime(MonthView.SelectedDateTime);

            SelectedPersianDateTime = MonthView.SelectedDateTime;
        }

        private void MonthView_DoubleClick(object sender, System.Windows.RoutedEventArgs e)
        {
            DatePickerPopup.IsOpen = false;
        }
    }
}
