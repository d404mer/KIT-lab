   M S B A M L   `   `   `  ����G  CHorseClubApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HorseClubApp.Views.ScopeHorseClubApp.Views.Scope  5      .    (HorseClubApp.Views.Scope.UserUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:HorseClubApp.Views.Scope     5        � 	Resources  5	         BoldWhiteText �� 
TargetType �� Property �� Value  CustomButtonStyle �� 
TargetType ��Name �� Triggers P� Property P� Value	 �� 
TargetName��%K  &	        &	 �     �� 5
   
   " ��6&   .�5      ��  � ��$ 20(�6)   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�64   �� 5       � ��$ Consolas)�6+   5      �� 5   
   " ��6*   .�5      ��  � ��$ 0,15,0,0q�6'   �� 5       � ��$ 40��6'   �� 5       � ��
 �   �6+   �� 5       � ��
 �����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Consolas)�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��6[   $��1q�6�   ._�5      �� $��Center=�6/   $��Center=�6L   5       5       P� 5!       � �� . . �5"   "   �� $	 border��6)    � �� �#3333336S   5#      5%      5'      5(      5)      .��5,      � .+�5-   
   �� .+�5.      �� $+��%Просмотр участников��6   #��[  63   $��10q�6Z   &   System.Windows.Controls.DataGrid  51      -   5        
  Name$
 DataGridBreeds��51      
������    AutoGenerateColumns .     
IsReadOnly . $��10q�52   L   $	��320��6X      Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 27 55      1  +System.Windows.Controls.DataGridBoundColumn   Binding 54   5   �� *	USER_ID+55        56      $ Имя��6)   $ 60 57       56   6   �� *	USER_name+57        58      $ Фамилия��6)   $ 80 59       58   :   �� *USER_surname+59        5:      $ 
Почта��6)   $	 150 5;       5:   8   �� *
USER_email+5;        5<      $ Телефон��6)   $	 100 5=       5<   :   �� *
USER_phone+5=        5>      $ Login��6)   $ 70 5?       5>   8   �� *
USER_login+5?        5@      $ Пароль��6)   $ 70 5A       5@   9   �� *USER_password+5A        5B      $ Статус��6)   $ 80 5C       5B   9   �� *USER_status+5C      4  .System.Windows.Controls.DataGridTemplateColumn  5G      $ 84 6-      CellTemplate 5H      �� 5I      .R�5J   "   ��  ��Name$ ButtonDeleteGrid��6)   -   5        $��Удалить��5J   C   
���   �
�������5L   ;   5M      5O        5P      $ 84 6-    5Q      �� 5R      .R�5S   "   �� $ ButtonEditGrid��6)   -   5        $��Изменить��5S   A   
���   �
�������5U      5V      5X      5Z      �� 5\      -   5        $ AddBtn��5\      $��Добавить��5]      #��[ 6   $	��500��6X   �� 5^      -   5        $ 	UpdateBtn��5^      $��Обновить��5_      #��[ 6   $	��500��6@   6L   5`      5a      5b      