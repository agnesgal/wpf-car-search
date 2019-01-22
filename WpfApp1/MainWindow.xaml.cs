using DataAccess;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        public IDataHandler DataHandler;
        public string dataPath = ConfigurationManager.AppSettings["DataPath"];

        public MainWindow()
        {
            InitializeComponent();
            DataHandlerFactory dataHandlerFactory = new DataHandlerFactory();
            DataHandler = dataHandlerFactory.manageData(dataPath);
        }

        private void boxFilling(List<Car> list)
        {
            MyBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string Type = "Type: " + list[i].Type;
                string PlateNumber = "Plate Number: " + list[i].PlateNumber;
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
            boxFilling(DataHandler.SearchByRedColor());
          
        }

        private void Btn_Click_2(object sender, RoutedEventArgs e)
        {
            boxFilling(DataHandler.SearchByJanosDriver());
        }
    }
}
