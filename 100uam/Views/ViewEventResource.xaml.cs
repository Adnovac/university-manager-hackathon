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
using _100uam.Elements;

namespace _100uam.Views
{
    /// <summary>
    /// Interaction logic for ViewEventResource.xaml
    /// </summary>
    public partial class ViewEventResource : UserControl
    {
        string eventResourceType;
        string eventResourceValueString;
        string configPath;
        public ViewEventResource(string eventResourceType, string eventResourceValueString, string configPath)
        {
            this.eventResourceType = eventResourceType;
            this.eventResourceValueString = eventResourceValueString;
            this.configPath = configPath + "eventImages/icons/";
            InitializeComponent();
            SetEventResource();
        }
        void SetEventResource()
        {
            Parser parser = new Parser();
            eventResourceValue.Text = parser.ParseNumber(eventResourceValueString);

            switch (eventResourceType)
            {
                case "money":
                    eventResourceIcon.Source = new BitmapImage(new Uri(configPath + @"money.png"));
                    break;
                case "prestige":
                    eventResourceIcon.Source = new BitmapImage(new Uri(configPath + @"prestige.png"));
                    break;
                case "happiness":
                    eventResourceIcon.Source = new BitmapImage(new Uri(configPath + @"happiness.png"));
                    break;
                case "income":
                    eventResourceIcon.Source = new BitmapImage(new Uri(configPath + @"income.png"));
                    break;
                default: break;
            }
        }
    }
}
