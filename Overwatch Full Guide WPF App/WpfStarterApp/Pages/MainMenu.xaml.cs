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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        MainWindow Mainwindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void CharacterSelect_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new CharacterSelect();
        }

        private void VideoSelect_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new VideoSelect();
        }

        private void MapSelect_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MapSelect();
        }
    }
}
