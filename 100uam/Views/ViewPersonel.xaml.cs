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
    /// Logika interakcji dla klasy ViewPersonel.xaml
    /// </summary>
    public partial class ViewPersonel : UserControl
    {

        Wydzialy wydzial;
        MainWindow mainWindow;
        public ViewPersonel(Wydzialy wydzial, MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.wydzial = wydzial;
            InitializeComponent();
            ilosc.Text = wydzial.LiczbaPersonelu.ToString();
        }

        private void ZatrudnijButton_Click(object sender, RoutedEventArgs e)
        {
            var myWin = (MainWindow)Application.Current.MainWindow;
            wydzial.AddPersonel();
            ilosc.Text = wydzial.LiczbaPersonelu.ToString();
            myWin.wydatki = myWin.wydatki + 200;
            myWin.Aktualizacja();
        }

        private void ZwolnijButton_Click(object sender, RoutedEventArgs e)
        {
            var myWin = (MainWindow)Application.Current.MainWindow;
            if (wydzial.LiczbaPersonelu > 0)
                wydzial.DeletePersonel();
            else
                MessageBox.Show("Nie masz pracowników!");
            ilosc.Text = wydzial.LiczbaPersonelu.ToString();
            myWin.wydatki = myWin.wydatki - 200;
            myWin.Aktualizacja();
        }
    }
}
