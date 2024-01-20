using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace notepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FormatDT();
        }

        

        private void btn_addnew_Click(object sender, RoutedEventArgs e)
        {
            txtb_invoeren.Focus();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            txtb_invoeren.Text = string.Empty;
        }

        private void chckb_bolt_Checked(object sender, RoutedEventArgs e)
        {
            if (chckb_bolt.IsChecked == true)
            {

                txtb_invoeren.FontWeight = FontWeights.Bold;
            }
            else
            {

                txtb_invoeren.FontWeight = FontWeights.Normal;
            }
        }

        private void chckb_italian_Checked(object sender, RoutedEventArgs e)
        {
            if (chckb_italian.IsChecked == true)

            {
                txtb_invoeren.FontStyle = FontStyles.Italic;
            }
            else
            {
                txtb_invoeren.FontStyle = FontStyles.Normal;
            }

        }

        private void chckb_Underlined_Checked(object sender, RoutedEventArgs e)
        {
            if (chckb_Underlined.IsChecked == true)
            {

                txtb_invoeren.TextDecorations = TextDecorations.Underline;
            }
            else
            {

                txtb_invoeren.TextDecorations = null;
            }
        }

        private void chckb_red_Checked(object sender, RoutedEventArgs e)
        {
            if (chckb_red.IsChecked == true)
            {
                txtb_invoeren.Foreground = Brushes.Red;
            }
            else
            {
                txtb_invoeren.ClearValue(TextBlock.ForegroundProperty);
            }

        }

        private void chckb_orange_Checked(object sender, RoutedEventArgs e)
        {
            if (chckb_orange.IsChecked == true)
            {
                txtb_invoeren.Foreground = Brushes.Red;
            }
            else
            {
                txtb_invoeren.ClearValue(TextBlock.ForegroundProperty);
            }

        }

        private void chckb_yellow_Checked(object sender, RoutedEventArgs e)
        {
            if (chckb_yellow.IsChecked == true)
            {
                txtb_invoeren.Foreground = Brushes.Red;
            }
            else
            {
                txtb_invoeren.ClearValue(TextBlock.ForegroundProperty);
            }
        }

        private void chckb_green_Checked(object sender, RoutedEventArgs e)
        {
            if (chckb_green.IsChecked == true)
            {
                txtb_invoeren.Foreground = Brushes.Red;
            }
            else
            {
                txtb_invoeren.ClearValue(TextBlock.ForegroundProperty);
            }
        }

        private void chckb_blue_Checked(object sender, RoutedEventArgs e)
        {
            if (chckb_blue.IsChecked == true)
            {
                txtb_invoeren.Foreground = Brushes.Red;
            }
            else
            {
                txtb_invoeren.ClearValue(TextBlock.ForegroundProperty);
            }
        }

        private void chckb_purple_Checked(object sender, RoutedEventArgs e)
        {
            if (chckb_purple.IsChecked == true)
            {
                txtb_invoeren.Foreground = Brushes.Purple;
            }
            else
            {
                txtb_invoeren.ClearValue(TextBlock.ForegroundProperty);
            }
        }

        private void btn_copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtb_invoeren.Text);
        }

        private void btn_paste_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                
                txtb_invoeren.Text += Clipboard.GetText();
            }
        }

        void FormatDT()
        {
            var dt = DateTime.Now;
            txtb_datum_tijd.Text = dt.ToString();
        }




    }
}

