   M S B A M L   `   `   `  ����G  CHorseClubApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HorseClubApp.Views.ScopeHorseClubApp.Views.Scope  5      .    (HorseClubApp.Views.Scope.ListUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:HorseClubApp.Views.Scope     5        � 	Resources  5
         BoldWhiteText �� 
TargetType �� Property �� Value  CustomButtonStyle �� 
TargetType ��Name �� Triggers P� Property P� Value	 �� 
TargetName��%K  &	        &	 �     �� 5   
   " ��6&   .�5      ��  � ��$ 20(�6)   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�64   �� 5       � ��$ Consolas)�6+   5      �� 5   
   " ��6*   .�5      ��  � ��$ 0,15,0,0q�6'   �� 5       � ��$ 40��6'   �� 5       � ��
 �   �6+   �� 5       � ��
 �����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Consolas)�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��6[   $��1q�6�   ._�5      �� $��Center=�6/   $��Center=�6L   5        5!      P� 5"       � �� . . �5#   "   �� $	 border��6)    � �� �#3333336S   5$      5&      5(      5)      5*      .��5,      � .+�5-   
   �� .+�5.      �� $I��CПросмотр связи участник-мероприятие��6   #��[  6C   $��10q�6j   &   System.Windows.Controls.DataGrid  51      -   5        
  Name$
 DataGridBreeds��51      
������    AutoGenerateColumns .     
IsReadOnly . $��10q�52   L   $	��320��6X      Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 27 55      1  +System.Windows.Controls.DataGridBoundColumn   Binding 54   5   �� *	LIST_ID+55        56      $ 
FK_USER_ID��6)   $	 100 57       56   =   �� *
FK_USER_ID+57        58      $ FK_EVENT_ID��6)   $	 100 59       58   >   �� *FK_EVENT_ID+59      4  .System.Windows.Controls.DataGridTemplateColumn  5>      $ 84 6-      CellTemplate 5?      �� 5@      .R�5A   "   ��  ��Name$ ButtonDeleteGrid��6)   -   5        $��Удалить��5A   C   
���   �
�������5C   ;   5D      5F        5G      $ 84 6-    5H      �� 5I      .R�5J   "   �� $ ButtonEditGrid��6)   -   5        $��Изменить��5J   A   
���   �
�������5L      5M      5O      5Q      �� 5S      -   5        $ AddBtn��5S      $��Добавить��5T      #��[ 6   $	��500��6X   �� 5U      -   5        $ 	UpdateBtn��5U      $��Обновить��5V      #��[ 6   $	��500��6@   6L   5W      5X      5Y      