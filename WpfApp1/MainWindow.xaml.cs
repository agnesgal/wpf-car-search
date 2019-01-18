using DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string DataPath = ConfigurationSettings.AppSettings["DataPath"];
        public DataHandler DataHandler;

        public MainWindow()
        {
            InitializeComponent();

            if (DataPath.Split('.').Last() == "xml") DataHandler =  new XMLDataHandler();
        
            else if (DataPath.Split('.').Last() == "csv") DataHandler = new CSVDataHandler();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ;
        }

        private void boxFilling(List<Car> list)
        {
            MyBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string Type = "Type: " + list[i].Type;
                string PlateNumber = "PlateNumber: " + list[i].PlateNumber;
                string Color = "Color: " + list[i].Color;
                string Driver = "Driver: " + list[i].Driver;
               
                MyBox.Items.Add(
                    Type + "\r\n" + 
                    PlateNumber + "\r\n" + 
                    Color + "\r\n" + 
                    Driver + 
                    "\r\n-----------");
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            boxFilling(DataHandler.SearchColor(DataPath));
          
        }

        private void Btn_Click_2(object sender, RoutedEventArgs e)
        {
            boxFilling(DataHandler.SearchDriver(DataPath));
        }
    }
}
