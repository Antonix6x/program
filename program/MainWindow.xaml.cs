using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace program
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CenterText_Click(object sender, RoutedEventArgs e)
        {
            if (tekst != null)
            {
                tekst.TextAlignment = TextAlignment.Center;                 //wyśrodkowanie
            }
        }
        private void AlignLeft_Click(object sender, RoutedEventArgs e)
        {
            if (tekst != null)
            {
                tekst.TextAlignment = TextAlignment.Left;                   //równanie do lewej
            }
        }
        private void AlignRight_Click(object sender, RoutedEventArgs e)
        {
            if (tekst != null)
            {
                tekst.TextAlignment = TextAlignment.Right;                  //równanie do prawej
            }
        }
        private void AlignJustify_Click(object sender, RoutedEventArgs e)
        {
            if (tekst !=null)
            {
                tekst.TextAlignment= TextAlignment.Justify;                 //Justowanie
            }
        }
        private void pogrub_Checked(object sender, RoutedEventArgs e)
        {
            tekst.FontWeight = FontWeights.Bold;            //pogrubienie
        }
        private void pogrub_Unchecked(object sender, RoutedEventArgs e)
        {
            tekst.FontWeight = FontWeights.Normal;  
        }
       
        private void podkreśl_Checked(object sender, RoutedEventArgs e)
        {
            tekst.TextDecorations = TextDecorations.Underline;
        }
        private void podkreśl_Unchecked(object sender, RoutedEventArgs e)
        {
            tekst.TextDecorations = null;
        }
        private void kursywa_Checked(object sender, RoutedEventArgs e)
        {
            tekst.FontStyle = FontStyles.Italic;
        }
        private void kursywa_Unchecked(object sender, RoutedEventArgs e)
        {
            tekst.FontStyle = FontStyles.Normal;
        }
        private void kolortekstu_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;

            if (selectedRadioButton.Content.ToString() == "czerwony")
            {
                tekst.Foreground = Brushes.Red;
            }
            else if (selectedRadioButton.Content.ToString()=="różowy")
            {
                tekst.Foreground= Brushes.Pink;
            }
            else if (selectedRadioButton.Content.ToString()=="zielony")
            {
                tekst.Foreground = Brushes.Green;
            }
            else if(selectedRadioButton.Content.ToString()=="żółty")
            {
                tekst.Foreground = Brushes.Yellow;
            }
            else if (selectedRadioButton.Content.ToString() == "niebieski")
            {
                tekst.Foreground = Brushes.Blue;
            }
            
        }

        
    }

}