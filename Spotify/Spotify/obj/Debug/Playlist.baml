   M S B A M L   `   `   `  ����B  >Spotify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:SpotifySpotify  5   	       Spotify.Playlist   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Spotify     5   	   $	��450��5      $	��800��6'     � Icon$$  Assets/SpotifyLauncher_129.ico��63    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   .��5      �  � RowDefinitions 5	   
   �� 5
      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $ 	#FF323232��6   $ 0.003Q�61   5      .+�5   
   �� -   5        	 ��Name$	 lblPlaylist��5      $��Playlist��6%   $
��Left=�68   $��	25,35,0,0q�6S   $	��Top=�6f   
�������$
��Bold"�6�   $��36(�6�   �� 5   
   -   5        
 ��Name$
 lsvPlaylist��5      $��
10,0,12,13q�6(   
�������$	��275��6   $��Bottom=�6�   ��5      �� 5      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5      � $ Black��6#   $ 1Q�61   � 5      $ 	#FF252525��6#   5       �� View 5      �� 5       �� AllowsColumnReorder .   �� ColumnHeaderContextMenu 5      �� 5      
�������$��Center=�69   
�������6T   5       5"      �� 5#   
   -   5         ��Name$ cmbPlaylist��5#      $��529,0,12,343q�6(   $��22��6n   $��Bottom=�6z   �� 5$   
   $��Playlist seleccionada��6   $
��Left=�60   $��
529,59,0,0q�6K   $	��Top=�6_   ���	#FF8B8B8B��6�   Z� �� 5%   
   -   5         ��Name$ btnBorrarPlaylist��5%      $��Eliminar��6,   $��707,0,12,318q�6?   ���	#FF262626���	#FF8B8B8B$��20��6�   $��Bottom=�6�   6�   �� 5&   
   -   5        $ 	btnCargar��5&      $��Cargar��6$   $��627,0,0,318q�65   ���	#FF262626���	#FF8B8B8B$��20��6�   $��Bottom=�6�   $
��Left=�6�   $��75��6�   �� 5'   
   -   5         ��Name$ 	txtBuscar��5'      $
��Left=�6%   $��19��6@   $��	84,10,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Buscar��6�   $��Buscar��6�   ���	#FFF0F0F0���	#FF3838386  �� 5(   
   -   5        $ 	btnBuscar��5(      $�� ��6$   $
��Left=�6/   $��	62,10,0,0q�6J   $	��Top=�6]   $��22��6u   $��19��6�   ��5)      �� 5*       �� ImageSource$ Assets/lupa.png��6   5,      �� 5-   
   -   5        $ 
btnGestion��5-      $��Gestionar Playlist��6%   $��627,0,12,293q�6B   ���	#FF262626���	#FF8B8B8B$��20��6�   $��Bottom=�6�   �� 5.   
   -	   5        $ 	btnCerrar��5.      $�� ��6$   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   $��51��6u   ��5/      �� 50      $ Assets/return.png��6   52      �� 53   
   -
   5        $	 lblAyuda��53      $%��Agregue canciones a su playlist��6"   $
��Left=�6L   $��	25,98,0,0q�6g   $	��Top=�6z   
�������6�   55      56      