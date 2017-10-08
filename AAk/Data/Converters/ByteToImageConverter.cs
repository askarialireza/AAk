
namespace AAk.Data.Converters
{
    public class ByteToImageConverter : System.Windows.Markup.MarkupExtension, System.Windows.Data.IValueConverter
    {
        public static ByteToImageConverter _byteToImageConverter;

        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((value is byte[]) == false)
            {
                return null;
            }

            else
            {
                System.Windows.Media.Imaging.BitmapImage biImg = new System.Windows.Media.Imaging.BitmapImage();

                System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])value);

                biImg.BeginInit();

                biImg.StreamSource = ms;

                biImg.EndInit();

                System.Windows.Media.ImageSource imgSrc = biImg as System.Windows.Media.ImageSource;

                return imgSrc;
            }
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            System.Windows.Media.Imaging.BmpBitmapEncoder oBmpBitmapEncoder = new System.Windows.Media.Imaging.BmpBitmapEncoder();

            byte[] bytes = null;

            System.Windows.Media.Imaging.BitmapSource oBitmapSource = value as System.Windows.Media.Imaging.BitmapSource;

            if (oBitmapSource != null)
            {
                oBmpBitmapEncoder.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(oBitmapSource));

                using (System.IO.MemoryStream oMemoryStream = new System.IO.MemoryStream())
                {
                    oBmpBitmapEncoder.Save(oMemoryStream);

                    bytes = oMemoryStream.ToArray();
                }
            }

            return bytes;
        }

        public override object ProvideValue(System.IServiceProvider serviceProvider)
        {
            if (_byteToImageConverter == null)
            {
                _byteToImageConverter = new ByteToImageConverter();
            }

            return _byteToImageConverter;
        }
    }
}
