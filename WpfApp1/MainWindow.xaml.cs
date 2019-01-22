using DataAccess;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        public string DataPath = ConfigurationManager.AppSettings["DataPath"];
        public IDataHandler DataHandler;

        public MainWindow()
        {
            InitializeComponent();

            if (DataPath.Split('.').Last() == "xml") DataHandler =  new XMLDataHandler();
        
            else if (DataPath.Split('.').Last() == "csv") DataHandler = new CSVDataHandler();

            else
            {
                //handle MSSQL data and use it for the app.config connection string refresh
                DataHandler = new DBDataHandler();

                //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                //connectionStringsSection.ConnectionStrings["add "].ConnectionString = "Data Source=blah;Initial Catalog=blah;UID=blah;password=blah";
                //config.Save();
                //ConfigurationManager.RefreshSection("connectionStrings");
      
                //XmlDocument XmlDoc = new XmlDocument();
                ////Loading the Config file
                //XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                //// XmlDoc.Load("App.config");
                //foreach (XmlElement xElement in XmlDoc.DocumentElement)
                //{
                //    if (xElement.Name == "connectionStrings")
                //    {
                //        //setting the coonection string
                //        xElement.FirstChild.Attributes[0].Value = "vmi";
                //    }
                //}
                ////writing the connection string in config file
                //XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            }

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
            boxFilling(DataHandler.Search(DataPath, "Color", "Red"));
          
        }

        private void Btn_Click_2(object sender, RoutedEventArgs e)
        {
            boxFilling(DataHandler.Search(DataPath, "Driver", "Janos"));
        }
    }
}
