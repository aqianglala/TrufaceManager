   M S B A M L   `   `   `  ����=  9tf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:tftf  5   	       tf.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:tf     5   	     � WindowStartupLocation$  CenterScreen=�5   	      MetroWindowStyle#��[  5	   	    � Title$ LoginWindow��5
   	   $	��450��6   $	��800��6*   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.4* �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ Vertical=�6"     PrimaryColorBrush#��[ 69   .+�5      �� $��ARATEK��6   $
��Bold"�6&   $��Center=�68   
�������$��48(�6h   $��0,10,0,0q�6v   �� 5      $��Please login to continue��6   $
��Bold"�68   $��Center=�6J   
�������$��28(�6z   5      ]� 5   
   $��1��6   $��
60,50,60,0q�6!   $��False��65   .+�5      � $	��Top=�6   .+�5      �� -   5        $��TextBoxName��5      $��50��6-   $��28(�6:   $��80,3,0,0q�6H   �� 5      $��32��6   $��32��6#   $
��Left=�6/   $��20,0,0,0q�6J   $��	/user.png��5      5      � 5      $��50��6   $��Bottom=�6   .+�5      G� -   5        $��PasswordBoxPassword��5      $��50��69   $��28(�6F   $��80,3,0,0q�6T   �� 5      $��32��6   $��32��6#   $
��Left=�6/   $��20,0,0,0q�6J   $��/password.png��5      5      5       ]� 5!   
   $��2��6   $��False��6!   $��110,35q�67   .+�5"      �� -   5        $��loginButton��5"      $	��250��6(   #��[ 64   
�������$
��Left=�6w   $��28(�6�   .��6�   Login6�   �� 5#      -   5        $��cancelButton��5#      $	��250��6)   #��[ 65   
�������$��Right=�6x   $��28(�6�   .��6�   Cancel6�   5$      5%      5&      