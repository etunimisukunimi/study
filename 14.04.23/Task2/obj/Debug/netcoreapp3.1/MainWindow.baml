   M S B A M L   `   `   `  ����@  <Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task2Task2  5   	       Task2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��Задание 2��6   $��20(�5      $��0��5      $
��Left=�5      $	��Top=�5      �� 5   
   $��
Число��6   $��20(�5      $��0��5      $��1��5      $��Center=�5      $��Center=�5      �� 5    
   $��
Ответ��6   $��20(�5!      $��0��5"      $��Center=�5#      $��Center=�5$      $��2��6/   �� 5%   
   -   5         ��Name$ BtnOK��5%      $��Вычислить��6    $	��120��5&      $��40��6    $��20(�5'      $��3��5(      $��1��5)      $��center=�5*      $��Center=�5+      
�������
�������5.      �� 5/   
   -   5        $ 	BtnCancel��5/      $��Отмена��6$   $	��120��50      $��40��6    $��20(�51      $��3��52      $��2��53      $��center=�54      $��Center=�55      
�������
�������58      �� 59   
   -   5         ��Name$ 	TbNumberA��59      $��1��5:      $��0��5;      $��Center=�5<      $��10q�5=      $��2q�5>      �� 5?   
   -   5         ��Name$ TextBlockAnswerP��5?      $��1��5@      $��2��5A      $��Center=�5B       �� Padding$ 10q�5C      5D      5E      