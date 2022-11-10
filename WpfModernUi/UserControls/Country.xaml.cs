using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfModernUi.UserControls
{
    /// <summary>
    /// Interaction logic for Country.xaml
    /// </summary>
    public partial class Country : UserControl
    {
        public Country()
        {
            InitializeComponent();
        }

        public string CountryName
        {
            get { return (string)GetValue(CountryNameProperty); }
            set { SetValue(CountryNameProperty, value); }
        }

        public static readonly DependencyProperty CountryNameProperty =
            DependencyProperty.Register("CountryName", typeof(string), typeof(Country));

        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(string), typeof(Country));

        public bool IsLevelUp
        {
            get { return (bool)GetValue(IsLevelUpProperty); }
            set { SetValue(IsLevelUpProperty, value); }
        }

        public static readonly DependencyProperty IsLevelUpProperty =
            DependencyProperty.Register("IsLevelUp", typeof(bool), typeof(Country));

        public string Flag
        {
            get { return (string)GetValue(FlagProperty); }
            set { SetValue(FlagProperty, value); }
        }

        public static readonly DependencyProperty FlagProperty =
            DependencyProperty.Register("Flag", typeof(string), typeof(Country));
    }
}
