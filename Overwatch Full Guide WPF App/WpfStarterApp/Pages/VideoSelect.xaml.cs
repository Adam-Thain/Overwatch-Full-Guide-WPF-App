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
using Overwatch_Full_Guide_WPF_App.ContentHolders;

namespace Overwatch_Full_Guide_WPF_App.Pages
{
    /// <summary>
    /// Interaction logic for VideoSelect.xaml
    /// </summary>
    public partial class VideoSelect : Page
    {
        MainWindow Mainwindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public VideoSelect()
        {
            InitializeComponent();

            RecallFrameHolder.Content = new VideoFrame("Recall");
            RiseShineFrameHolder.Content = new VideoFrame("RiseShine");
            LastBastionFrameHolder.Content = new VideoFrame("LastBastion");
            InfiltrationFrameHolder.Content = new VideoFrame("Infiltration");
            AliveFrameHolder.Content = new VideoFrame("Alive");
            DragonsFrameHolder.Content = new VideoFrame("Dragons");
            HeroFrameHolder.Content = new VideoFrame("Hero");
            HonorGloryFrameHolder.Content = new VideoFrame("HonorGlory");
            ShootingStarFrameHolder.Content = new VideoFrame("ShootingStar");
            ReunionFrameHolder.Content = new VideoFrame("Reunion");
            ThePlanFrameHolder.Content = new VideoFrame("ThePlan");
            CinematicFrameHolder.Content = new VideoFrame("Cinematic");
        }

        private void Overwatch_Home_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MainMenu();
        }
    }
}