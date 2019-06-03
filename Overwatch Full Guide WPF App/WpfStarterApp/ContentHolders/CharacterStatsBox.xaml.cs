using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for CharacterStatsBox.xaml
    /// </summary>
    public partial class CharacterStatsBox : Page
    {
        /// <summary>
        /// 
        /// </summary>
        private CharacterStats statsModel;

        public class CharacterStats
        {
            /// <summary>
            /// Characters Call Sign
            /// </summary>
            public string CallSign { set; get; }

            /// <summary>
            /// Character Portrait image
            /// </summary>
            public ImageSource PortraitImage { set; get; }

            /// <summary>
            /// Character Portrait image
            /// </summary>
            public ImageSource PixelImage { set; get; }

            /// <summary>
            /// Character Cute image
            /// </summary>
            public ImageSource CuteImage { set; get; }

            /// <summary>
            /// Characters Real Name
            /// </summary>
            public string RealName { get; set; }

            /// <summary>
            /// Characters Age
            /// </summary>
            public string Age { get; set; }

            /// <summary>
            /// Characters nationality (If Applicable)
            /// </summary>
            public string Nationality { set; get; }

            /// <summary>
            /// Characters Occupation (current and former)
            /// </summary>
            public string Occupation { set; get; }

            /// <summary>
            /// Characters base of operations
            /// </summary>
            public string Base { set; get; }

            /// <summary>
            /// Characters affiliations to any specific organization
            /// </summary>
            public string Affiliation { set; get; }

            /// <summary>
            /// Characters relations to other in-game characters (both PC and NPC)
            /// </summary>
            public string Relations { set; get; }
        }

        public CharacterStatsBox(String Character)
        {
            // Get the root
            string root = System.IO.Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));

            // String for selected character
            string SelectedCharacter = Character;

            // Read all lines from the txt file and store each line as a string in a list 
            string[] lines = File.ReadAllLines(System.IO.Path.GetFullPath(@"..\..\TextFiles\CharacterInfos\") + Character + "Info.txt");

            InitializeComponent();

            // Create a new character stats model and assign info to its members
            statsModel = new CharacterStats()
            {
                CallSign = lines[0],
                PortraitImage = new BitmapImage(new Uri(System.IO.Path.GetFullPath(@"..\..\Images\CharacterArtworks\") + SelectedCharacter + "-portrait.png")),
                PixelImage = new BitmapImage(new Uri(System.IO.Path.GetFullPath(@"..\..\Images\Sprites\") + "Spray_" + SelectedCharacter + "_Pixel.png")),
                CuteImage = new BitmapImage(new Uri(System.IO.Path.GetFullPath(@"..\..\Images\Cutes\") + "Spray_" + SelectedCharacter + "_Cute.png")),
                RealName = lines[1],
                Age = lines[2],
                Nationality = lines[3],
                Occupation = lines[4],
                Base = lines[5],
                Affiliation = lines[6],
                Relations = lines[7],
            };
            
            // Set the data context to our character statistics model
            this.DataContext = statsModel;
        }   
    }
}
