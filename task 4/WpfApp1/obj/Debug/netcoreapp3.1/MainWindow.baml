   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��650��6   $��1350         ��6)   .��5
      � $��Center=�6    � ColumnDefinitions 5   
   �� 5      $	��250��6   $	��250��6.   6?    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��Username��6   $��4��6#   $��2��60   $��20(�6D   $��0,0,0,5q�6R   $
��Left=�6c   $��Bottom=�6~   $��Arial)�6�   $��Normal"�6�   6�   �� 5   
   -   5         ��Name$ userbox��5      $��5��6#   $
��Left=�60   $��Center=�6K   $	��250��6f   $��35��6r   $��0,0,0,3q�6~   $��Bottom=�6�   $��15(�6�   $��serif)�6�   6�   �� 5   
   $��6��6   $��Password��6   $��0,5,0,0q�60   $��20(�6A   $
��Left=�6O   $��Ariel)�6j   6   G� 5    
   -   5         G�Name$ passbox��5       $��7��6'   $
��left=�64   $��Center=�6O   $	��250��6j   $��35��6v   $��0,0,0,3q�6�   $��Bottom=�6�   6�   �� 5!   
   -   5        $ peekbox��5!      $��7��6$   $��0��61   $��Center=�6A   $
��Left=�6\   $	��250��6w   $��35��6�   $��0,0,0,3q�6�   $��Bottom=�6�   $y�Hidden=�6�   $��15(�6�   $��Ariel)�6�   6  �� 5"   
   -   5         ��Name$ 
showbutton��5"      $��7��6&   $��0��63   $
��auto��6C   $
��auto��6P   $��Show password��6^   $��9(�6v   $��0,0,0,0q�6�   
�������$
��Left=�6�   $��Center=�6�   $��Bottom=�6�   $��	186,0,0,0q�6	  6�  �� 5#   
   -   5        $��8��5#      $��0��6   $��Sign in��6.   $��15(�6@   $��Ariel)�6N   $��Center=�6a   $��25��6~   
�������6�   5%      5&      