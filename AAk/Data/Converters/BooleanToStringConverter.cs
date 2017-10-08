
namespace AAk.Data.Converters
{
    public class BooleanToStringConverter : System.Windows.Markup.MarkupExtension, System.Windows.Data.IValueConverter
    {
        public static BooleanToStringConverter _BooleanToStringConverter;

        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((value is bool) == false)
            {
                return string.Empty;
            }

            System.Globalization.CultureInfo oPersianCultureInfo = new System.Globalization.CultureInfo("fa-IR");

            System.Globalization.CultureInfo oEnglishCultureInfo = new System.Globalization.CultureInfo("en-US");

            if (culture == oPersianCultureInfo)
            {
                switch ((bool)value)
                {
                    case true:
                        {

                            return "بله";
                        }

                    case false:
                        {
                            return "خیر";
                        }
                }
            }

            if (culture == oEnglishCultureInfo)
            {
                switch ((bool)value)
                {
                    case true:
                        {

                            return "Yes";
                        }

                    case false:
                        {
                            return "No";
                        }
                }
            }

            return null;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string strValue = (string)value;

            System.Globalization.CultureInfo oPersianCultureInfo = new System.Globalization.CultureInfo("fa-IR");

            System.Globalization.CultureInfo oEnglishCultureInfo = new System.Globalization.CultureInfo("en-US");

            if (culture == oPersianCultureInfo)
            {
                switch (strValue)
                {
                    case "بله":
                        {
                            return true;
                        }

                    case "خیر":
                        {
                            return false;
                        }
                }
            }

            if (culture == oEnglishCultureInfo)
            {
                switch (strValue)
                {
                    case "YES":
                    case "yes":
                    case "Yes":
                        {
                            return true;
                        }

                    case "NO":
                    case "no":
                    case "No":
                        {
                            return false;
                        }
                }
            }

            return null;
        }

        public override object ProvideValue(System.IServiceProvider serviceProvider)
        {
            if (_BooleanToStringConverter == null)
            {
                _BooleanToStringConverter = new BooleanToStringConverter();
            }

            return (_BooleanToStringConverter);
        }
    }
}
