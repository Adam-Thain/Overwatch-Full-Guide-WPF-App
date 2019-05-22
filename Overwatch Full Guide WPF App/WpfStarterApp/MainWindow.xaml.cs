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

namespace Overwatch_Full_Guide_WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 
        /// </summary>
        public MainWindow()
        {
            // Initialize the Main Window 
            InitializeComponent();

            // Apply the Window View Model to the data Context
            this.DataContext = new WindowViewModel(this);

            // Inject the character select page into the window content
            Main.Content = new MainMenu();
        }
        private void myFrame_ContentRendered(object sender, EventArgs e)
        {
            Main.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }
    }
}
