using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Visibilidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(cbFigura.SelectedIndex)
            {
                case 0: //circulo
                    txtRadio.Visibility = Visibility.Visible;
                    lblRadio.Visibility = Visibility.Visible;
                    break;

                case 1: // triangulo
                    lblbase.Visibility = Visibility.Visible;
                    txtBase.Visibility = Visibility.Visible;

                    lblAltura.Visibility = Visibility.Visible;
                    txtAltura.Visibility = Visibility.Visible;

                    lblRadio.Visibility = Visibility.Hidden;
                    txtRadio.Visibility = Visibility.Hidden;
                    break;

                default:
                    break;

            }
        }
    }
}
