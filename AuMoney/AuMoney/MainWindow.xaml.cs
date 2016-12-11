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

namespace AuMoney
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private int version = 100;
        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private KiwoomCode kiwoomCode;

        //Constructor
        public MainWindow()
        {
            InitializeComponent();
        }

        //Open OCX(Active X) via winform lib
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //initialize windows
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.axKHOpenAPI1.OnEventConnect += axKHOpenAPI_OnEventConnect;
            windowsFormHostKiwoom.Child = this.axKHOpenAPI1;
            
            //connecting
            textBoxLog.Text = "connectung to server...";
            if (axKHOpenAPI1.CommConnect() == 0)
            {
                textBoxLog.Text = "Success connecting server";
            }
            else
            {
                textBoxLog.Text = "Fail connecting server";
            }
        }

        private void axKHOpenAPI_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            string str = "";
            
            str += kiwoomCode.getErrorMsgString(e.nErrCode);

            MessageBox.Show(str);
        }

        //Destructor
        ~MainWindow()
        {
            //if still connected with server, terminate connection
            if (this.axKHOpenAPI1.GetConnectState() == 1)
            {
                this.axKHOpenAPI1.CommTerminate();
                textBoxLog.Text = "connection is terminated";
            }
        }
    }
}
