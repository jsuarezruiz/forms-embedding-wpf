using FormsEmbedding.Views;
using System.Windows;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF.Extensions;

namespace FormsEmbedding.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            WPFButton.Click += OnWPFButtonClick;
        }

        private void OnWPFButtonClick(object sender, RoutedEventArgs e)
        {
            var frameworkElement = new SettingsView().ToFrameworkElement();
            FormsEmbeddingPanel.Children.Add(frameworkElement);
        }
    }
}