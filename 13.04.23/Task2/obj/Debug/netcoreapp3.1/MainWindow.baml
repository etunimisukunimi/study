   M S B A M L   `   `   `  ����@  <Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task2Task2  5   	       Task2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��Задание 2��6   $��20(�5      $��0��5      $
��Left=�5      $	��Top=�5      �� 5   
   $'��!Длина окружности L��6   $��20(�5      $��0��5      $��1��5      $��Center=�5      $��Center=�5      �� 5    
   $��Радиус��6   $��20(�5!      $��0��5"      $��3��5#      $��Center=�5$      $��Center=�5%      �� 5&   
   $��Площадь��6   $��20(�5'      $��0��5(      $��Center=�5)      $��Center=�5*      $��2��6/   �� 5,   
   -   5         ��Name$ BtnOK��5,      $��Вычислить��6    $	��120��5-      $��40��6    $��20(�5.      $��3��5/      $��1��50      $��center=�51      $��Center=�52      
�������
�������55      �� 56   
   -   5        $ 	BtnCancel��56      $��Отмена��6$   $	��120��57      $��40��6    $��20(�58      $��3��59      $��2��5:      $��center=�5;      $��Center=�5<      
�������
�������5?      �� 5@   
   -   5         ��Name$ 	TbNumberL��5@      $��1��5A      $��0��5B      $��Center=�5C      $��10q�5D      $��2q�5E      �� 5F   
   -   5         ��Name$ TextBlockAnswerR��5F      $��1��5G      $��1��5H      $��Center=�5I       �� Padding$ 10q�5J      �� 5K   
   -   5        $ TextBlockAnswerS��5K      $��1��5L      $��2��5M      $��Center=�5N      $ 10q�5O      5P      5Q      