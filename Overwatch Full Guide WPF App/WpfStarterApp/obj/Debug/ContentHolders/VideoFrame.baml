   M S B A M L   `   `   `  ����W  SOverwatch Full Guide WPF App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Overwatch_Full_Guide_WPF_App.ContentHolders+Overwatch_Full_Guide_WPF_App.ContentHolders  5      <    6Overwatch_Full_Guide_WPF_App.ContentHolders.VideoFrame   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Klocal9clr-namespace:Overwatch_Full_Guide_WPF_App.ContentHolders     5        N� Title$  
VideoFrame��5	       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ MediaCommands.Play��5      6S     5   
   -   5        $ MediaCommands.Pause��5      6U     5   
   -   5        $ MediaCommands.Stop��5      6S   .��5      �� 
����� �$��2q�6     �� CornerRadius$ 8,8,8,8��64   ._�5   
   � $��10q�6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5       � .+�5!      r� -   5        $��MediaPlayer��5!        r� LoadedBehavior$ Manual=�63   6M   �� 5"      -   5        $��PlayerOverlay��5"      $
��Fill=�6-   �� 5#      -   5        $��PlayIcon��5#      $0��*/Images/Misc/Media_player_icons-12-512.png��6(   $	��100��6\    J� Opacity$	 0.5Q�6i   5$      �� 5&      $��1��6   
����� �$��2q�65   $ 6,6,6,6��6I   $��0,5,0,5q�6`   ._�5)      �� .+�5,      �  � ColumnDefinitions 5/      �� 50      $��* �6/   �� 51      $
��auto �6/   .+�55      �� -   5        $��TimelineSlider��55   !   $��5q�67   6�   �� 58      -   5        $��lblProgressStatus��58   $   
����� �$��5��6O   $��Center=�6`   $��5q�6{   
00:00:006�   5:      � 5=      $��Center=�6   $��5q�68    5@      �� 5A      $��* �6/   �� 5B      $��* �6/   �� 5C      $��* �6/   �� 5D      $��* �6/   �� 5E      $	��100 �6/   �� 5F      $��* �6/   .+�5J      �� -	   5        $��btnPlay��5J   !      VideoPlayerButton#��[  60   $��MediaCommands.Play��6[   $��0��6x   .��6�   Play6�   �� 5M      -
   5        $��btnPause��5M   !   #��[  61   $	��5,0q�6\   $��MediaCommands.Pause��6i   $��1��6�   .��6�   Pause6�   �� 5P      -   5        $��btnStop��5P   !   #��[  60   $��MediaCommands.Stop��6[   $��2��6x   .��6�   Stop6�   �� 5S      
����� �$��3��66   $��Center=�6F   $��Center=�6c   $��5q�6~   Volume6�   �� 5V      -   5        $��VolumeSlider��5V   !    � Value$
 0.05Q�65   	 � Maximum$	 1Q�6B   $��4��6N   $��Center=�6^   6y   5X      5Y      5[      �� 5]      -   5        
 ��Name$
 DescriptionBorder��5]      $��2��60   
����� �$��2q�6P   $ 6,6,6,6��6d   ._�5^      �� 
������ 
����� �
������ . �5_      /� -   5         �Name$ Description��5_   #   5`      5a      5b      5d      5f      