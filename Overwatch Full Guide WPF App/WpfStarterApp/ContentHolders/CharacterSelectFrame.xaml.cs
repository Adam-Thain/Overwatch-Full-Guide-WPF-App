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
using Overwatch_Full_Guide_WPF_App.Pages;
using Overwatch_Full_Guide_WPF_App.Pages.Characters;

namespace Overwatch_Full_Guide_WPF_App.ContentHolders
{
    /// <summary>
    /// Interaction logic for CharacterSelectFrame.xaml
    /// </summary>
    public partial class CharacterSelectFrame : Page
    {
        MainWindow Mainwindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public CharacterSelectFrame()
        {
            InitializeComponent();
        }

        #region Tanks

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DVaButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("DVa");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrisaButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Orisa");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReinhardtButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Reinhardt");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoadhogButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Roadhog");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinstonButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Winston");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZaryaButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Zarya");
        }

        #endregion

        #region Damage

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoomfistButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Doomfist");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenjiButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Genji");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void McCreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("McCree");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PharahButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Pharah");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaperButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Reaper");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Soldier_76Button_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Soldier76");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SombraButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Sombra");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TracerButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Tracer");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BastionButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Bastion");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HanzoButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Hanzo");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JunkratButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Junkrat");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeiButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Mei");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SymmetraButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Symmetra");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TorbjörnButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Torbjörn");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidowmakerButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Widowmaker");
        }

        #endregion

        #region Supports

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnaButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Ana");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrigitteButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Brigitte");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LúcioButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Lúcio");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MercyButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Mercy");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoiraButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Moira");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZenyattaButton_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterInfoPage("Zenyatta");
        }

        #endregion
    }
}
