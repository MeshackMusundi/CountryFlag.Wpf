using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CountryFlag.Wpf
{
    /// <summary>
    /// Interaction logic for CountryFlag.xaml
    /// </summary>
    public partial class CountryFlag : UserControl
    {
        public CountryFlag()
        {
            InitializeComponent();
        }

        public string CountryCode
        {
            get => (string)GetValue(CountryCodeProperty);
            set => SetValue(CountryCodeProperty, value);
        }

        public static readonly DependencyProperty CountryCodeProperty =
            DependencyProperty.Register("CountryCode", typeof(string),
                typeof(CountryFlag), new PropertyMetadata("AD", new PropertyChangedCallback(CountryCodeChange)));

        private static void CountryCodeChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            string countryCode = e.NewValue as string;
            string flag = $"Flags/{countryCode.ToLower(CultureInfo.InvariantCulture)}.png";
            (d as CountryFlag).FlagImage.Source = new BitmapImage(new Uri(flag, UriKind.Relative));
        }
    }
}
