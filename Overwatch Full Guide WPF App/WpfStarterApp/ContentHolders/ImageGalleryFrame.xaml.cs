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
using System.IO;

namespace Overwatch_Full_Guide_WPF_App.ContentHolders
{
    /// <summary>
    /// Interaction logic for ImageGallery.xaml
    /// </summary>
    public partial class ImageGalleryFrame : Page
    {
        string[] filepaths;

        public ImageGalleryFrame(string Map)
        {
            switch(Map)
            {
                case("Hanamura"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Hanamura\", " *.jpg");
                    break;
                case ("HorizonLunerColony"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\HorizonLunerColony\", " *.jpg");
                    break;
                case ("TempleOfAnubis"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\TempleOfAnubis\", " *.jpg");
                    break;
                case ("VolskayaIndustries"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\VolskayaIndustries\", " *.jpg");
                    break;
                case ("Dorado"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Dorado\", " *.jpg");
                    break;
                case ("Junkertown"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Junkertown\", " *.jpg");
                    break;
                case ("Rialto"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Rialto\", " *.jpg");
                    break;
                case ("Route66"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Route66\", " *.jpg");
                    break;
                case ("WatchpointGibraltar"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\WatchpointGibraltar\", " *.jpg");
                    break;
                case ("BlizzardWorld"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterAppImages\Maps\BlizzardWorld\", " *.jpg");
                    break;
                case ("Eichenwalde"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Eichenwalde\", " *.jpg");
                    break;
                case ("Hollywood"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Hollywood\", " *.jpg");
                    break;
                case ("KingsRow"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\KingsRow\", " *.jpg");
                    break;
                case ("Numbani"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Numbani\", " *.jpg");
                    break;
                case ("Busan"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Busan\", " *.jpg");
                    break;
                case ("Ilios"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Ilios\", " *.jpg");
                    break;
                case ("LijiangTower"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\LijiangTower\", " *.jpg");
                    break;
                case ("Nepal"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Nepal\", " *.jpg");
                    break;
                case ("Oasis"):
                    filepaths = Directory.GetFiles(@"F:\WpfStarterAppV4\WpfStarterApp\Images\Maps\Oasis\", " *.jpg");
                    break;
            }

            InitializeComponent();
        }
    }
}
