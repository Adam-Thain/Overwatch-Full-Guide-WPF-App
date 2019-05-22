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

namespace Overwatch_Full_Guide_WPF_App.ContentHolders
{
    /// <summary>
    /// Interaction logic for MapStatsBox.xaml
    /// </summary>
    public partial class MapStatsBox : Page
    {
        private MapStats statsModel;

        public class MapStats
        {
            /// <summary>
            /// Map Name
            /// </summary>
            public string Name { set; get; }

            /// <summary>
            /// Character Portrait image
            /// </summary>
            public ImageSource PortraitImage { set; get; }

            /// <summary>
            /// Map Type
            /// </summary>
            public string Type { set; get; }

            /// <summary>
            /// Map Location 
            /// </summary>
            public string Location { set; get; }

            /// <summary>
            /// Map Terrain
            /// </summary>
            public string Terrain { set; get; }
        }

        public MapStatsBox(string Map)
        {
            // Read all lines from the txt file and store each line as a string in a list 
            string[] lines = File.ReadAllLines(@"F:\WpfStarterAppV4\WpfStarterApp\TextFiles\MapInfos\" + Map + "Info.txt");

            InitializeComponent();

            // Create a new character stats model and assign info to its members
            statsModel = new MapStats()
            {
                Name = Map,
                PortraitImage = new BitmapImage(new Uri(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\MapPortraits\" + Map + "_concept.jpg")),
                Type = lines[0],
                Location = lines[1],
                Terrain = lines[2],
            };

            // Set the data context to our character statistics model
            this.DataContext = statsModel;
        }
    }
}
