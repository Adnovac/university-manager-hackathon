using _100uam.Elements;
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

namespace _100uam.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ViewWykladowca.xaml
    /// </summary>
    public partial class ViewWykladowca : UserControl
    {
        string configPath;
        Wydzialy wydzial;
        public ViewWykladowca(Wydzialy wydzial , string configPath,MainWindow mainWindow)
        {
            this.configPath = configPath;
            this.wydzial = wydzial;
            InitializeComponent();
            ilosc.Text = wydzial.LiczbaWykladowcow.ToString();
            avatar.Source = new BitmapImage(new Uri(configPath + "staff002.png"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var myWin = (MainWindow)Application.Current.MainWindow;
            wydzial.AddWykladowca();
            ilosc.Text = wydzial.LiczbaWykladowcow.ToString();
            myWin.wydatki = myWin.wydatki + 500;
            myWin.Aktualizacja();
        }

        private void ZwolnijButton_Click(object sender, RoutedEventArgs e)
        {
            var myWin = (MainWindow)Application.Current.MainWindow;
            if (wydzial.LiczbaWykladowcow > 0)
                wydzial.DeleteWykladowca();
            else
                MessageBox.Show("Nie masz pracowników!");
            ilosc.Text = wydzial.LiczbaWykladowcow.ToString();
            myWin.wydatki = myWin.wydatki - 500;
            myWin.Aktualizacja();
        }

    }
}
