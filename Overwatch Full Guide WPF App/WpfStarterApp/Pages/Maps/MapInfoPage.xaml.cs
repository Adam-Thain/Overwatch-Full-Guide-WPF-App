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
using Overwatch_Full_Guide_WPF_App.ContentHolders;

namespace Overwatch_Full_Guide_WPF_App.Pages.Maps
{
    /// <summary>
    /// Interaction logic for MapInfoPage.xaml
    /// </summary>
    public partial class MapInfoPage : Page
    {
        MainWindow Mainwindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public MapInfoPage(string Map)
        {
            // Read all lines from the txt file and store each line as a string in a list 
            string[] lines = File.ReadAllLines(@"F:\WpfStarterAppV4\WpfStarterApp\TextFiles\MapInfos\" + Map + "Info.txt");

            // List to store all paragraphs
            List<Paragraph> Paragraphs = new List<Paragraph>();

            InitializeComponent();

            // Inject introduction paragraph with content
            IntroContainer.Inlines.Add(new Run(lines[4]));

            // Inject Map stats box with relevant Map content
            MapsStatsBox.Content = new MapStatsBox(Map);

            // UI element to store the Image Gallery
            BlockUIContainer ImageGalleryContainer = new BlockUIContainer();

            // Frame to hold the Image Gallery
            Frame ImageGalleryContent = new Frame();

            // Create individual paragraphs and fill each with the individual lines from the relevant txt file
            for (int i = 6; i < lines.Length; i++)
            {
                Paragraph p = new Paragraph();
                p.Inlines.Add(new Run(lines[i]));
                PageContentHolder.Blocks.Add(p);
                Paragraphs.Add(p);
            }

            ImageGalleryContainer.Child = ImageGalleryContent;
            ImageGalleryContent.Content = new ImageGalleryFrame(Map);
            PageContentHolder.Blocks.Add(ImageGalleryContainer);

        }
        private void Overwatch_Home_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MainMenu();
        }
    }
}
