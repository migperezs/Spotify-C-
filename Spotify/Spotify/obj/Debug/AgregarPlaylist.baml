   M S B A M L   `   `   `  ����B  >Spotify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:SpotifySpotify  5   	       Spotify.AgregarPlaylist   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Spotify     5   	   $��261.125��5      $��585.5��6+     � WindowStyle$  
ToolWindow=�69    � 
ResizeMode$ NoResize=�6R    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6~   .��5      � ���	#FF252525$��Right=�6"   $	��580��6>   $	��233��6J   $	��Top=�6W   .+�5	   
   �� $��Crear playlist��6   $
��Left=�6)   $��
243,10,0,0q�6D   $	��Top=�6X   $��16(�6p   
�������$
��Bold"�6�   �� 5
   
   $��Nombre��6   $
��Left=�6!   $��
210,46,0,0q�6<   $	��Top=�6P   ���	#FF999999$��57��6   �� 5   
   -   5         ��Name$ 	txtNombre��5      $
��Left=�6%   $��23��6@   $��
210,72,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $��Mi playlist #1��6t   $	��Top=�6�   $	��360��6�   
���   �6�   �� 5   
   $��Descripción��6   $
��Left=�6&   $��210,100,0,0q�6A   $	��Top=�6V   ���	#FF999999$��73��6�   �� 5   
   -   5        $ txtDescripcion��5      $
��Left=�6*   $��50��6E   $��210,126,0,0q�6Q   $
 Wrap=�6f   $3��-Ponle a tu playlist una descripción pulenta.��6z   $	��Top=�6�   $	��360��6�   
���   �6�   �� 5   
   $��22,17,393,57q�6   $��Assets/ElegirImagen.png��6&   $
��Fill=�6G   �� 5   
   -   5         ��Name$ btnCrear��5      $��CREAR��6#   $��0,191,252,20q�63   ���	#FF0E4B00���	#FF2BB60D
�������$��11(�6�   $��UltraExpanded&�6�   $��SemiBold"�6�   &   System.Windows.Media.TextOptions   TextHintingMode$ Animated=�6�   $��Right=�6�   $��74��6  6  5      5      