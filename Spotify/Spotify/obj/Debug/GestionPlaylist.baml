   M S B A M L   `   `   `  ����B  >Spotify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:SpotifySpotify  5   	       Spotify.GestionPlaylist   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Spotify     5   	   $��339.623��5      $��623.113��6+     � 
ResizeMode$  NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q    � Topmost .  � WindowStyle$
 None=�6�   ��5      �� 5	   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5
      �  � Color$ Black��6    � Offset$ 1Q�6)   � 5      $ 	#FF3A3A3A��6   5      .��5      � $��	0,0,0,-31q�6   .+�5   
   �� -   5         ��Name$ 
lsvGestion��5      $��10,64,10,10q�6'   
���������5      �� 5      $ 0.5,1&�6&   	 � MappingMode$	 RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5      � $ Black��6#   $ 1Q�61   � 5      $ 	#FF252525��6#   5      
 �� View
 5      �� 5       �� AllowsColumnReorder .   �� ColumnHeaderContextMenu 5      �� 5      
�������$��Center=�69   
�������6T   5      5      �� 5   
   -   5         ��Name$ 	btnCerrar��5      $�� ��6$   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   $��51��6u   ��5      �� 5        �� ImageSource$ Assets/return.png��6   5"      �� 5#   
   -   5        $ btnPlaylist��5#      $��a��6&   $
��Left=�62   $��	47,44,0,0q�6M   $	��Top=�6`   $��25��6x   ��6�   Z� ��5$      �� 5%      $ Assets/abajo.png��6   5'      �� 5(   
   -   5        $ btnID��5(      $��Button��6    $
��Left=�61   $��
109,44,0,0q�6L   $	��Top=�6`   $��26��6x   ��6�   Z� ��5)      �� 5*      $ Assets/abajo.png��6   5,      �� 5-   
   -   5        $ 
btnArtista��5-      $��Button��6%   $
��Left=�66   $��
150,44,0,0q�6Q   $	��Top=�6e   $��26��6}   ��6�   Z� ��5.      �� 5/      $ Assets/abajo.png��6   51      �� 52   
   -   5        $ btnAlbum��52      $��Button��6#   $
��Left=�64   $��
259,44,0,0q�6O   $	��Top=�6c   $��26��6{   ��6�   Z� ��53      �� 54      $ Assets/abajo.png��6   56      �� 57   
   -   5        $ 
btnCancion��57      $��Button��6%   $
��Left=�66   $��
402,44,0,0q�6Q   $	��Top=�6e   $��26��6}   ��6�   Z� ��58      �� 59      $ Assets/abajo.png��6   5;      �� 5<   
   -   5        $ btnFecha��5<      $��Button��6#   $
��Left=�64   $��
527,44,0,0q�6O   $	��Top=�6c   $��26��6{   ��6�   Z� ��5=      �� 5>      $ Assets/abajo.png��6   5@      �� 5A   
   -	   5         ��Name$ 	txtBuscar��5A      $
��Left=�6%   $��19��6@   $��	84,10,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Buscar��6�   $��Buscar��6�   ���	#FFF0F0F0���	#FF3838386  �� 5B   
   -
   5        $ 	btnBuscar��5B      $�� ��6$   $
��Left=�6/   $��	62,10,0,0q�6J   $	��Top=�6]   $��22��6u   $��19��6�   ��5C      �� 5D      $ Assets/lupa.png��6   5F      5H      5I      