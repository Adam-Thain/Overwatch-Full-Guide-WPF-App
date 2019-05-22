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
using Overwatch_Full_Guide_WPF_App.Pages.Maps;

namespace Overwatch_Full_Guide_WPF_App.Pages
{
    /// <summary>
    /// Interaction logic for MapSelect.xaml
    /// </summary>
    public partial class MapSelect : Page
    {
        MainWindow Mainwindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public MapSelect()
        {
            InitializeComponent();
        }

        private void Overwatch_Home_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MainMenu();
        }

        private void BtnClickHanamura(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Hanamura");
        }

        private void BtnClickHorizonLunarColony(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("HorizonLunarColony");
        }

        private void BtnClickTempleOfAnubis(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("TempleOfAnubis");
        }

        private void BtnClickVolskayaIndustries(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("VolskayaIndustries");
        }

        private void BtnClickDorado(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Dorado");
        }

        private void BtnClickJunkertown(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Junkertown");
        }

        private void BtnClickRialto(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Rialto");
        }

        private void BtnClickRoute66(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Route66");
        }

        private void BtnClickWatchpointGibraltar(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("WatchpointGibraltar");
        }

        private void BtnClickBlizzardWorld(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("BlizzardWorld");
        }

        private void BtnClickEichenwalde(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Eichenwalde");
        }

        private void BtnClickHollywood(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Hollywood");
        }

        private void BtnClickKingsRow(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("KingsRow");
        }
        private void BtnClickNumbani(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Numbani");
        }

        private void BtnClickBusan(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Busan");
        }
        private void BtnClickIlios(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Ilios");
        }

        private void BtnClickLijiangTower(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("LijiangTower");
        }

        private void BtnClickNepal(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Nepal");
        }

        private void BtnClickOasis(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapInfoPage("Oasis");
        }
    }
}
