   M S B A M L   `   `   `  ����B  >Spotify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:SpotifySpotify  5   	       Spotify.Canciones   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Spotify     5   	   $	��450��5      $	��800��6'     � Icon$$  Assets/SpotifyLauncher_129.ico��63    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   .��5      � ��5	   
   �� 5
       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $ 	#FF323232��6   $ 0.003Q�61   5      .+�5   
   �� $��	Canciones��6   $
��Left=�6$   $��	25,35,0,0q�6?   $	��Top=�6R   
�������$
��Bold"�6}   $��36(�6�   �� 5   
   -   5         ��Name$ lsvCanciones��5      $
��Left=�6)   $	��306��6D   $��
10,134,0,0q�6Q   $	��Top=�6e   $	��780��6}   
���������5      �� 5      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5      � $ Black��6#   $ 1Q�61   � 5      $ 	#FF252525��6#   5      	 �� View	 5      �� 5      
 �� AllowsColumnReorder
 .   �� ColumnHeaderContextMenu 5      �� 5      
�������$��Center=�69   
�������6T   5      5      �� 5    
   -   5         ��Name$ 	txtBuscar��5       $
��Left=�6%   $��19��6@   $��	84,10,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Buscar��6�   $��Buscar��6�   ���	#FFF0F0F0���	#FF3838386  �� 5!   
   -   5         ��Name$ btnId��5!      $��a��6    $
��Left=�6,   $��
10,114,0,0q�6G   $	��Top=�6[   $��25��6s   ��6~   Z� ��5"      �� 5#       �� ImageSource$ Assets/abajo.png��6   5%      �� 5&   
   -   5        $ 
btnArtista��5&      $��Button��6%   $
��Left=�66   $��
54,114,0,0q�6Q   $	��Top=�6e   $��26��6}   ��6�   Z� ��5'      �� 5(      $ Assets/abajo.png��6   5*      �� 5+   
   -   5        $ btnAlbum��5+      $��Button��6#   $
��Left=�64   $��130,114,0,0q�6O   $	��Top=�6d   $��26��6|   ��6�   Z� ��5,      �� 5-      $ Assets/abajo.png��6   5/      �� 50   
   -   5        $ 
btnCancion��50      $��Button��6%   $
��Left=�66   $��238,114,0,0q�6Q   $	��Top=�6f   $��26��6~   ��6�   Z� ��51      �� 52      $ Assets/abajo.png��6   54      �� 55   
   -   5        $ 	btnBuscar��55      $�� ��6$   $
��Left=�6/   $��	62,10,0,0q�6J   $	��Top=�6]   $��22��6u   $��19��6�   ��56      �� 57      $ Assets/lupa.png��6   59      �� 5:   
   -   5        $ 	btnCerrar��5:      $�� ��6$   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   $��51��6u   ��5;      �� 5<      $ Assets/return.png��6   5>      5@      5A      