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

namespace Contador_Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
private int conteo;

        public MainWindow()
        {
            InitializeComponent();
            conteo = 0;
        }
        private void contarButton_Click(object sender, RoutedEventArgs e)
        {
            //Bueno aquí está de mas dar a entender que estos algoritmos son para que tengan funcionalidad los botones, contar//
            //reiniciar y salir//

            conteo++;
            conteoLabel.Content = Convert.ToString(conteo);
        }
        //el object sender se genera automaticamente con el evento, lo que hace el sender es que convierte un objeto en tipo botón//

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            conteo = 0;
            conteoLabel.Content = Convert.ToString(conteo);
        }
        private void salirButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
       
        
    
}
