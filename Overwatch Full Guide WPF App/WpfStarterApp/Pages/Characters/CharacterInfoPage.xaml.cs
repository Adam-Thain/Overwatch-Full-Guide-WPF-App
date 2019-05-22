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

namespace Overwatch_Full_Guide_WPF_App.Pages.Characters
{
    /// <summary>
    /// Interaction logic for CharacterInfoPage.xaml
    /// </summary>
    public partial class CharacterInfoPage : Page
    {
        MainWindow Mainwindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public CharacterInfoPage(string Character)
        {
            // Read all lines from the txt file and store each line as a string in a list 
            string[] lines = File.ReadAllLines(@"F:\WpfStarterAppV4\WpfStarterApp\TextFiles\CharacterInfos\" + Character + "Info.txt");
            
            // List to store all paragraphs
            List<Paragraph> Paragraphs = new List<Paragraph>();

            // UI element to store the video grid
            BlockUIContainer VideoContainer = new BlockUIContainer();

            // UI element to store the character select frame
            BlockUIContainer CharacterSelectBoxContainer = new BlockUIContainer();

            // Frame to hold the video player
            Frame VideoContent = new Frame();

            // Frame to hold the character Select box
            Frame CharacterSelectBoxContent = new Frame();

            InitializeComponent();

            // Inject introduction paragraph with content
            IntroContainer.Inlines.Add(new Run(lines[9]));

            // Inject Character stats box with relevant character content
            CharacterStatsBox.Content = new CharacterStatsBox(Character);

            // Create individual paragraphs and fill each with the individual lines from the relevant txt file
            for (int i = 11; i < lines.Length; i++)
            {
                Paragraph p = new Paragraph();
                p.Inlines.Add(new Run(lines[i]));
                PageContentHolder.Blocks.Add(p);
                Paragraphs.Add(p);
            }

            VideoContainer.Child = VideoContent;
            VideoContent.Content = new VideoFrame(Character);

            CharacterSelectBoxContainer.Child = CharacterSelectBoxContent;
            CharacterSelectBoxContent.Content = new CharacterSelectFrame();

            PageContentHolder.Blocks.Add(VideoContainer);
            PageContentHolder.Blocks.Add(CharacterSelectBoxContainer);
        }

        private void Overwatch_Home_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Mainwindow != null)
                Mainwindow.Main.Content = new MainMenu();
        }
    }
}
