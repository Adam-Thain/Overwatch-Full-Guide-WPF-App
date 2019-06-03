using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Overwatch_Full_Guide_WPF_App.ContentHolders
{
    /// <summary>
    /// Interaction logic for VideoFrame.xaml
    /// </summary>
    public partial class VideoFrame : Page
    {
        /// <summary>
        /// Image resource for image placeholder
        /// </summary>
        public ImageSource PosterSource { get; set; }

        /// <summary>
        /// Boolean for if the video is currently playing
        /// </summary>
        private bool mediaPlayerIsPlaying = false;

        /// <summary>
        /// Boolean for if the user drags the thumbnail of the playback slider
        /// </summary>
        private bool userIsDraggingSlider = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Character"></param>
        public VideoFrame(String Character)
        {
            // Initialize the Video Player
            InitializeComponent();

            // Set The Video Player Source according to which page the user is on
            switch (Character)
            {
                case ("Genji"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Genji Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("McCree"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "McCree Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Pharah"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Pharah Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Reaper"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Reaper Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Soldier76"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Soldier_ 76 Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Sombra"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "[NEW HERO – NOW PLAYABLE] Introducing Sombra _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Tracer"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Tracer Ability Overview  Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Bastion"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Overwatch_ Bastion Ability Overview (EU).mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Hanzo"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Hanzo Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Junkrat"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Junkrat Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Mei"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Mei Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Torbjörn"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Torbjörn Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Widowmaker"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Widowmaker Ability Overview  Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("DVa"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "D.Va Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Orisa"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "[NEW HERO – NOW PLAYABLE] Introducing Orisa _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Reinhardt"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Overwatch_ Reinhardt Ability Overview (EU).mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Roadhog"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Roadhog Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Winston"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Overwatch_ Winston Ability Overview (EU).mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Zarya"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Zarya Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Ana"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "[NEW HERO] Introducing Ana _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Lúcio"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Lúcio Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Mercy"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Overwatch Mercy Ability Overview (EU).mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Moira"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "[NEW HERO NOW AVAILABLE] Introducing Moira _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Symmetra"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Symmetra Ability Overview _ Overwatch.mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Zenyatta"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\CharacterOverviews\") + "Overwatch_ Zenyatta Ability Overview (EU).mp4");
                    DescriptionBorder.Visibility = Visibility.Collapsed;
                    break;
                case ("Recall"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Animated Short _ _Recall_.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-Recall_Thumbnail.png"));
                    CreateDescription(0);
                    break;
                case ("RiseShine"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Animated Short _ _Rise and Shine_.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-Rise_and_Shine_thumbnail.png"));
                    CreateDescription(1);
                    break;
                case ("LastBastion"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Animated Short _ _The Last Bastion_.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-The_Last_Bastion_thumbnail.png"));
                    CreateDescription(2);
                    break;
                case ("Infiltration"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Animated Short _ _Infiltration_.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-Infiltration_thumbnail.jpg"));
                    CreateDescription(3);
                    break;
                case ("Alive"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Animated Short _ Alive.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-Alive_Thumbnail.png"));
                    CreateDescription(4);
                    break;
                case ("Dragons"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Animated Short _ Dragons.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-Dragons_Thumbnail.png"));
                    CreateDescription(5);
                    break;
                case ("Hero"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Animated Short _ Hero.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-Hero_Thumbnail.png"));
                    CreateDescription(6);
                    break;
                case ("HonorGlory"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Animated Short _ Honor and Glory.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-Honor_and_Glory.png"));
                    CreateDescription(7);
                    break;
                case ("ShootingStar"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Animated Short _ Shooting Star.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-Shooting_Star_thumbnail.jpg"));
                    CreateDescription(8);
                    break;
                case ("Reunion"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Animated Short _ Reunion.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-Reunion_thumbnail.jpg"));
                    CreateDescription(9);
                    break;
                case ("ThePlan"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "_Junkertown_ The Plan_ _ Overwatch.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-The_Plan_thumbnail.jpg"));
                    CreateDescription(10);
                    break;
                case ("Cinematic"):
                    MediaPlayer.Source = new Uri(Path.GetFullPath(@"..\..\Videos\AnimatedShorts\") + "Overwatch Cinematic Trailer.mp4");
                    PlayerOverlay.Source = new BitmapImage(new Uri(Path.GetFullPath(@"..\..\Images\Video Placeholders\") + "1200px-Cinematic_Trailer_thumbnail.jpg"));
                    CreateDescription(11);
                    break;
            }

            MediaPlayer.Stop();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// update Slider control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            // IF the medial player has a source, a timespan and there is not playback slider thumbnail dragging, update the Slider control
            if (MediaPlayer.Source != null && (MediaPlayer.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                // Set playback sliders minimum value
                TimelineSlider.Minimum = 0;

                // Set playback sliders maximum value
                TimelineSlider.Maximum = MediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;

                // Set the value of the slider to the time of the media player
                TimelineSlider.Value = MediaPlayer.Position.TotalSeconds;
            }
        }

        /// <summary>
        /// Check if the play command can be executed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (MediaPlayer != null) && (MediaPlayer.Source != null);
        }

        /// <summary>
        /// Play the video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PlayerOverlay.Visibility = Visibility.Hidden;
            PlayIcon.Visibility = Visibility.Hidden;
            MediaPlayer.Play();
            mediaPlayerIsPlaying = true;
        }

        /// <summary>
        /// Check if the pause command can be executed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        /// <summary>
        /// Pause the video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MediaPlayer.Pause();
        }

        /// <summary>
        /// Check if the stop command can be executed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        /// <summary>
        /// Stop the video 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PlayerOverlay.Visibility = Visibility.Visible;
            PlayIcon.Visibility = Visibility.Visible;
            MediaPlayer.Stop();
            mediaPlayerIsPlaying = false;
        }


        /// <summary>
        /// When the video player is first opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediaPlayer_MediaOpened(object sender, System.Windows.RoutedEventArgs e)
        {
            if(MediaPlayer.NaturalDuration.HasTimeSpan)
            {
                TimeSpan ts = TimeSpan.FromMilliseconds(MediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds);
                TimelineSlider.Maximum = ts.TotalSeconds;
            }
        }

        /// <summary>
        /// When the User clicks on the playback slider thumb 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sliProgress_DragStarted(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        /// <summary>
        /// When the User releases the click on the playback slider thumb 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sliProgress_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            MediaPlayer.Position = TimeSpan.FromSeconds(TimelineSlider.Value);
        }

        /// <summary>
        /// Update the status label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sliProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblProgressStatus.Text = TimeSpan.FromSeconds(TimelineSlider.Value).ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// Change the volume of the video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VolumeSlider_ValueChanged(object sender, EventArgs e)
        {
            // Set media player volume
            MediaPlayer.Volume = VolumeSlider.Value;
        }

        /// <summary>
        /// Write the description for the video
        /// </summary>
        private void CreateDescription(int descriptionNumber)
        {
            // Read all lines from the txt file and store each line as a string in a list 
            string[] lines = File.ReadAllLines(Path.GetFullPath(@"..\..\TextFiles\VideoInfos\VideoDescriptions.txt"));

            Paragraph paragraph = new Paragraph();

            paragraph.Inlines.Add(lines[descriptionNumber]);

            Description.Blocks.Add(paragraph);
        }
    }
}
