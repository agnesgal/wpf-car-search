using DataAccess;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        private IDataHandler DataHandler;

        public MainWindow()
        {
            InitializeComponent();
            DataHandlerFactory dataHandlerFactory = new DataHandlerFactory();
            DataHandler = dataHandlerFactory.CreateDataHandler(ConfigurationManager.AppSettings["DataSourceType"]);
        }

        private void boxFilling(List<Car> cars)
        {
            MyBox.Items.Clear();
            for (int i = 0; i < cars.Count; i++)
            {
                string Type = "Type: " + cars[i].Type;
                string PlateNumber = "Plate Number: " + cars[i].PlateNumber;
                string Color = "Color: " + cars[i].Color;
                string Driver = "Driver: " + cars[i].Driver;
               
                MyBox.Items.Add(
                    Type + "\r\n" + 
                    PlateNumber + "\r\n" + 
                    Color + "\r\n" + 
                    Driver + 
                    "\r\n-----------");
            }
        }

        private void Button1ClickEventHandler(object sender, RoutedEventArgs e)
        {         
            boxFilling(DataHandler.SearchByColor("Red"));
          
        }

        private void Button2ClickEventHandler(object sender, RoutedEventArgs e)
        {
            boxFilling(DataHandler.SearchByDriver("Janos"));
        }
    }
}
