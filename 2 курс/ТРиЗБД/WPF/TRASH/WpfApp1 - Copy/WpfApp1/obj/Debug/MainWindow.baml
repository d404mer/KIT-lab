   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   ?$clr-namespace:WpfApp1.MVVM.ViewModelWpfApp1.MVVM.ViewModel  5   
   5clr-namespace:WpfApp1.MVVM.ViewWpfApp1.MVVM.View  5          WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   :	viewModel$clr-namespace:WpfApp1.MVVM.ViewModel     5   
   0viewclr-namespace:WpfApp1.MVVM.View     5        � Title$  КЛС - Main Window��5
   	   $	��600��5   	   $	��920��6    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      *  $WpfApp1.MVVM.ViewModel.MainViewModel  5   
    � 	Resources 5       �� 
TargetType   DarkExitButtonStyle �� Property	 �� Value
 �� 
TargetType �� CornerRadius��%.  &	        �� 5   
   " ��6   .�5      ��  � ��	 �#1818196+   �� 5       � ��
	 �����6+   �� 5       � ��$	 10q�6(   �� 5       � ��$	 10q�6'   �� 5       �@�Cursor$
	 Hand��6'   �� 5       � ��$	 50��6&   �� 5       � ��$	 30��6'   �� 5        � ��	 5"      �� 5#      "
 ��6&   .R�5$      �� #��z��6!   #��z��5%   !   #��z��5&   !   $ 5��5'   !   ._�5(      � .+�5)   "   �� $��Center=�63   $��Center=�6P   5*      5+      5,      5.      5/      50      .��52      �� ���#181819$ 20��6"   ._�53   
   �  � RowDefinitions 54      �� 55      $	��83* �6    �� 56      $
��517* �6     � ColumnDefinitions 58      �� 59      $
��143* �6#   �� 5:      $
��777* �6#   .+�5?      ��  �� Orientation$ 
Horizontal=�6   $��0��62   $��0��6?   .+�5@      �� -   5         ��Name$ ExitBtn��5@      $��
Выйти��6*   #��[  6O   5A      ]� 5E      $��1��6   $��0��6(   $��Right=�65   .+�5G      �� .+�5I      �� -   5         ��Name$
 icon��5I      $��/Asset 1.png��6&   $
��Left=�6<   $��Center=�6W   $��20q�5J       � Cursor$
 Hand��5K   =   $��35��5L      5M      5O      �� 5S      $��1��6   .+�5T      	� $
��Main��6   $��50��5U      
�������$��14(�5W        MenuButtonTheme#��[ 5X       d� 	IsChecked$
 TrueY�5Y      ��5Z      �� *HomeViewCommand+	� 5]      $
��Main��6   $��50��5^      
�������$��14(�5`      #��[ 5a      ��5b      �� *MembersViewCommand+	� 5d      $��	Mafdgdfsn��6   $��50��5e      
�������$��14(�5g      #��[ 5h      	� 5j      $
��Main��6   $��50��5k      
�������$��14(�5m      #��[ 5n      5p      �� 5s      $��1��6   $��1��5t      $��10q�5u      ��5v      �� *CurrentView+5w      5x      5�      