   M S B A M L   `   `   `  ����J  FRobotinterface2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Robotinterface2Robotinterface2  5   	        Robotinterface2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Robotinterface2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      $��30 �6   �� 5      �� 5      $��30 �6   �� 5      �� 5      $��30 �6   .+�5   
   �� $��	Émission��6   $��0q�6%   ���	#FFDDDDDD
���   �$��1��6[   $��1��6k   .��5      �� -   5         ��Name$ textBoxEmission��5      $��0q�6/    �� TextWrapping$
 Wrap=�6:    �� AcceptsReturn . ��6N   Z� ��6d   Z� 6�   5      �� 5   
   $��
Réception��6   $��0q�6&   ���	#FFDDDDDD
���   �$��3��6\   $��1��6l   .��5      �� -   5        $ textBoxReception��5      $��0q�60   $
 Wrap=�6;    .  �� 
IsReadOnly . ��6O   Z� ��6e   Z� 6�   5      �� 5   
   -   5         ��Name$ buttonEnvoyer��5      $��Envoyer��6(   $��1��6:   $��Center=�6J   $��0q�6g   $��3��6r   $	��100��6   6�   �� 5   
   -   5        $ buttonClear��5      $��Clear��6&   $��3��66   $��Center=�6F   $��0,1,0,0q�6c   $��3��6t   $	��100��6�   6�   5       5!      