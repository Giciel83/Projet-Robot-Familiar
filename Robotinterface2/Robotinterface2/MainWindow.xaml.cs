using System;
using System.IO.Ports;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
using ExtendedSerialPort;

namespace Robotinterface2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>



    public partial class MainWindow : Window
    {

        ReliableSerialPort serialPort1;

        public MainWindow()
        {
            InitializeComponent();
            serialPort1 = new ReliableSerialPort("COM8", 115200, Parity.None, 8, StopBits.One); //entrée USB à droite
            serialPort1.DataReceived += SerialPort1_DataReceived;
            serialPort1.Open();
        }

        private void SerialPort1_DataReceived(object sender, DataReceivedArgs e)
        {
            textBoxReception.Text += Encoding.UTF8.GetString(e.Data, 0, e.Data.Length);
        }

        void Sendmessage()
        {
            String texteE = textBoxEmission.Text;
            serialPort1.WriteLine(texteE);
           /* textBoxReception.Text = "Reçu : " + texteE + "\n";
            textBoxEmission.Text = "";*/
        }

        
        private void buttonEnvoyer_Click(object sender, RoutedEventArgs e)
        {
            Sendmessage();
        }

        private void textBoxEmission_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Sendmessage();
            }
        }
    }
}
