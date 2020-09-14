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

namespace Robotinterface2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void buttonEnvoyer_Click(object sender, RoutedEventArgs e)
        {
            String prevtexteR = textBoxReception.Text;
            String texteE = textBoxEmission.Text;
            textBoxReception.Text = prevtexteR + "Reçu : " + texteE + "\n";
            textBoxEmission.Text = "";

        }
        
    }
}
