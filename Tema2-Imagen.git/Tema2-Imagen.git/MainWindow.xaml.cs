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

namespace Tema2_Imagen.git
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

        private void OpacidadChecked(object sender, RoutedEventArgs e) => 
            Imagen.Opacity = (sender as RadioButton).Content switch
            {
                "Alta" => 1,
                "Media" => 0.6,
                "Baja" => 0.3,
            };
        

        private void AjusteChecked(object sender, RoutedEventArgs e) => 
            Imagen.Stretch = (sender as RadioButton).Content switch
            {
                "Fill" => Stretch.Fill,
                "Uniform to Fill" => Stretch.UniformToFill,
                "Uniform" => Stretch.Uniform,
                "None" => Stretch.None,
            };
        
    }
}
