using System;
using System.Collections.Generic;
using System.IO;
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

namespace _100uam.Views
{
    /// <summary>
    /// Interaction logic for ViewEvent.xaml
    /// </summary>
    public partial class ViewEvent : UserControl
    {
        string configPath;
        string questID;
        MainWindow mainWindow;
        public ViewEvent(string configPath, string questID, MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.questID = questID;
            this.configPath = configPath;
            InitializeComponent();
            SetEvent();
        }

        void SetEvent()
        {
            string[] lines = File.ReadAllLines(configPath + @"questData\quest" + questID + ".txt");
            MessageBox.Show(configPath + @"questData\quest" + questID + ".txt");
            //quest description from separate file
            questDescription.Text = File.ReadAllText(configPath + @"questData\questDescription" + questID + ".txt", Encoding.Default);
            //quest title from 1st line
            questTitle.Text = lines[0];
            //quest avatar directory from 2nd line
            eventAvatar.Source = new BitmapImage(new Uri(configPath + lines[1]));
            //quest cost from next 3 (doubled) lines, if no data then skip
            int lineCounter = 2;
            for (int i = 0; i < 3; i++)
            {
                if (lines[lineCounter] == "none")
                    lineCounter++;
                else
                {
                    ViewEventResource viewEventResource = new ViewEventResource(lines[lineCounter], lines[lineCounter + 1], configPath);
                    costStackPanel.Children.Add(viewEventResource);
                    lineCounter += 2;
                }
            }
            //quest reward from next 3 (doubled) lines, if no data then skip
            for (int i = 0; i < 3; i++)
            {
                if (lines[lineCounter] == "none")
                    lineCounter++;
                else
                {
                    ViewEventResource viewEventResource = new ViewEventResource(lines[lineCounter], lines[lineCounter + 1], configPath);
                    rewardStackPanel.Children.Add(viewEventResource);
                    lineCounter += 2;
                }
            }
        }

        private void questDeclineButtonClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void questAcceptButtonbClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
