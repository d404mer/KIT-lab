   M S B A M L   `   `   `  ����G  CHorseClubApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HorseClubApp.Views.ScopeHorseClubApp.Views.Scope  5      /    )HorseClubApp.Views.Scope.HorseUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:HorseClubApp.Views.Scope     5        � 	Resources  5
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
   �� .+�5.      �� $%��Просмотр лошадей��6   #��[  60   $��10q�6W   &   System.Windows.Controls.DataGrid  51      -   5        
  Name$
 DataGridBreeds��51      
������    AutoGenerateColumns .     
IsReadOnly . $��10q�52   L   $	��320��6X      Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 27 55      1  +System.Windows.Controls.DataGridBoundColumn   Binding 54   5   �� *
HORSE_ID+55        56      $ Кличка��6)   $	 100 57       56   9   �� *
HORSE_name+57        58      $ Возраст��6)   $ 50 59       58   :   �� *	HORSE_age+59        5:      $ Пол��6)   $ 50 5;       5:   6   �� *	HORSE_sex+5;        5<      $ ID владельца��6)   $	 100 5=       5<   ?   �� *FK_USER_ID_HORSE+5=        5>      $ ID породы��6)   $	 120 5?       5>   <   �� *FK_HORSE_breedID+5?      4  .System.Windows.Controls.DataGridTemplateColumn  5D      $ 84 6-      CellTemplate 5E      �� 5F      .R�5G   "   ��  ��Name$ ButtonDeleteGrid��6)   -   5        $��Удалить��5G   C   
���   �
�������5I   ;   5J      5L        5M      $ 84 6-    5N      �� 5O      .R�5P   "   �� $ ButtonEditGrid��6)   -   5        $��Изменить��5P   A   
���   �
�������5R      5S      5U      5W      �� 5Y      -   5        $ AddBtn��5Y      $��Добавить��5Z      #��[ 6   $	��500��6X   �� 5[      -   5        $ 	UpdateBtn��5[      $��Обновить��5\      #��[ 6   $	��500��6@   6L   5]      5^      5_      