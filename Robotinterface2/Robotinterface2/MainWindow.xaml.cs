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
using System.Windows.Threading;

namespace Robotinterface2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>



    public partial class MainWindow : Window
    {
        
        ReliableSerialPort serialPort1;
        DispatcherTimer timerAffichage;

        private string receivedtext;
        private string receivedtextAnt;


        public MainWindow()
        {
            InitializeComponent();
            /*----------------------------Init du port série + évenement datareceived------------------------------------*/
            serialPort1 = new ReliableSerialPort("COM8", 115200, Parity.None, 8, StopBits.One); //entrée USB à droite
            serialPort1.DataReceived += SerialPort1_DataReceived;
            serialPort1.Open();
            /*-----------------------------------------------------------------------------------------------------------*/

            /*-----------------------------------Init Timer-------------------------*/
            timerAffichage = new DispatcherTimer(); 
            timerAffichage.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timerAffichage.Tick += TimerAffichage_Tick;
            timerAffichage.Start();
        }   /*-----------------------------------------------------------------------*/

        private void TimerAffichage_Tick(object sender, EventArgs e)
        {
            if (receivedtext != receivedtextAnt)
            {
                textBoxReception.Text = receivedtext;
                receivedtextAnt = receivedtext;
            }
        }

        private void SerialPort1_DataReceived(object sender, DataReceivedArgs e)
        {
            receivedtext += Encoding.UTF8.GetString(e.Data, 0, e.Data.Length);
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

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxReception.Clear();
            receivedtext = "";
        }




        void Sendmessage()
        {
            string texteE = textBoxEmission.Text;
            serialPort1.WriteLine(texteE);
            textBoxEmission.Clear();
        }
    }
}
