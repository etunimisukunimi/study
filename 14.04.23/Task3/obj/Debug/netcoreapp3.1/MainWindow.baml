   M S B A M L   `   `   `  ����@  <Task3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task3Task3  5   	       Task3.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task3     5   	     � Title$  
MainWindow��5   	   $	��200��6   $	��350��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $*��$Введите число K (1-365):��6!   $��10q�6A   �� 5   
   -   5         ��Name$	 TbK��5      $��1��6   $��10q�6,   $��Center=�68   $��1q�6Z   �� 5   
   -   5         ��Name$ TextBlockResult��5      $��2��6-   $��10q�6:   $
��Wrap=�6F   �� 5   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $
��0 10q�6X   .+�5      �� -   5         ��Name$ BtnCalculate��5      $��Вычислить��6+   $��80��6?   $��24��6J   $��3q�6V   6a   �� 5      -   5        $ 	BtnCancel��5      $��Отмена��6(   $��80��69   $��24��6D   $��3q�6P   6[   5      5      5      