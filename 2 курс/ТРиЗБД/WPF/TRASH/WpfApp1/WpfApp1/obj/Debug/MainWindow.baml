   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   ?$clr-namespace:WpfApp1.MVVM.ViewModelWpfApp1.MVVM.ViewModel  5   
   5clr-namespace:WpfApp1.MVVM.ViewWpfApp1.MVVM.View  5          WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   :	viewModel$clr-namespace:WpfApp1.MVVM.ViewModel     5   
   0viewclr-namespace:WpfApp1.MVVM.View     5        � Title$  КЛС - Main Window��5
   	   $	��600��5   	   $	��920��6    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      *  $WpfApp1.MVVM.ViewModel.MainViewModel  5   
   .��5      �� 
���iii� �� CornerRadius$ 20��6"   ._�5   
   �  � RowDefinitions 5      �� 5      $	��83* �6    �� 5      $
��517* �6     � ColumnDefinitions 5      �� 5      $
��143* �6#   �� 5      $
��777* �6#   .+�5      �� $��КЛС��6   $��Center=�5       $��Center=�5!      
�������$��22(�5#      $��0��5$      $��0��5%      �� 5(      $��1��6   .+�5)      	� $
��Main��6   $��50��5*      
�������$��14(�5,         MenuButtonTheme#��[  5-       d� 	IsChecked$
 TrueY�5.      ��5/      �� *HomeViewCommand+	� 52      $
��Main��6   $��50��53      
�������$��14(�55      #��[  56      ��57      �� *MembersViewCommand+	� 59      $��	Mafdgdfsn��6   $��50��5:      
�������$��14(�5<      #��[  5=      	� 5?      $
��Main��6   $��50��5@      
�������$��14(�5B      #��[  5C      5E      �� 5G      $��1��6   $��1��5H      $��10q�5I      ��5J      �� *CurrentView+5K      5L      5f      