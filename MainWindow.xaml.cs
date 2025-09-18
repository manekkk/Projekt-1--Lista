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

namespace PierwszyProjektLista
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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox1.SelectedItem;

            if (selectedItem != null)
            {
                string wybor = selectedItem.Content.ToString();

                if (wybor == "Muzyka")
                {
                    MessageBox.Show("Lubisz muzykę, oby nie Disco Polo");
                }
                else if (wybor == "Podróże")
                {
                    MessageBox.Show("Podróże kształcą, warto poznawać świat");
                }
                else if (wybor == "Sport")
                {
                    MessageBox.Show("Sport to zdrowie");
                }
               
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnej opcji.");
            }
        }


    }
}