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
using Overwatch_Full_Guide_WPF_App.Pages.Characters;

namespace Overwatch_Full_Guide_WPF_App.Pages
{
    /// <summary>
    /// Interaction logic for CharacterSelect.xaml
    /// </summary>
    public partial class CharacterSelect : Page
    {
        MainWindow Mainwindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public CharacterSelect()
        {
            InitializeComponent();
        }

        private void Overwatch_Home_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MainMenu();
        }

        #region Row 1

        private void BtnClickDoomfist(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Doomfist");
        }

        private void BtnClickGenji(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Genji");
        }

        private void BtnClickMcCree(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("McCree");
        }

        private void BtnClickPharah(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Pharah");
        }

        private void BtnClickReaper(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Reaper");
        }

        #endregion

        #region Row 2

        private void BtnClickSoldier76(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Soldier76");
        }

        private void BtnClickSombra(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Sombra");
        }

        private void BtnClickTracer(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Tracer");
        }

        private void BtnClickBastion(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Bastion");
        }

        private void BtnClickHanzo(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Hanzo");
        }

        #endregion

        #region Row 3

        private void BtnClickJunkrat(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Junkrat");
        }

        private void BtnClickMei(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Mei");
        }

        private void BtnClickTorbjörn(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Torbjörn");
        }

        private void BtnClickWidowmaker(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Widowmaker");
        }

        private void BtnClickDVa(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("DVa");
        }

        #endregion

        #region Row 4

        private void BtnClickOrisa(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Orisa");
        }

        private void BtnClickReinhardt(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Reinhardt");
        }

        private void BtnClickRoadhog(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Roadhog");
        }

        private void BtnClickWinston(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Winston");
        }

        private void BtnClickZarya(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Zarya");
        }

        #endregion

        #region Row 5

        private void BtnClickAna(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Ana");
        }

        private void BtnClickBrigitte(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Brigitte");
        }

        private void BtnClickLucio(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Lúcio");
        }

        private void BtnClickMercy(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Mercy");
        }

        private void BtnClickMoira(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Moira");
        }

        #endregion

        #region Row 6

        private void BtnClickSymmetra(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Symmetra");
        }

        private void BtnClickZenyatta(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Zenyatta");
        }

        #endregion

    }
}