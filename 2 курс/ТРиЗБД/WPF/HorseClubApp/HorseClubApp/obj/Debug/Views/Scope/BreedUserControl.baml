   M S B A M L   `   `   `  ����G  CHorseClubApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HorseClubApp.Views.ScopeHorseClubApp.Views.Scope  5      /    )HorseClubApp.Views.Scope.BreedUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:HorseClubApp.Views.Scope     5        � 	Resources  5	         BoldWhiteText �� 
TargetType �� Property �� Value  CustomButtonStyle �� 
TargetType ��Name �� Triggers P� Property P� Value	 �� 
TargetName��%K  &	        &	 �     �� 5
   
   " ��6&   .�5      ��  � ��$ 20(�6)   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�64   �� 5       � ��$ Consolas)�6+   5      �� 5   
   " ��6*   .�5      ��  � ��$ 0,15,0,0q�6'   �� 5       � ��$ 40��6'   �� 5       � ��
 �   �6+   �� 5       � ��
 �����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Consolas)�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��6[   $��1q�6�   ._�5      �� $��Center=�6/   $��Center=�6L   5       5       P� 5!       � �� . . �5"   "   �� $	 border��6)    � �� �#3333336S   5#      5%      5'      5(      5)      .��5+      � .+�5,   
   �� .+�5-      �� $!��Просмотр пород��6   #��[  6.   $��10q�6U   &   System.Windows.Controls.DataGrid  50      -   5        
  Name$
 DataGridBreeds��50      
������    AutoGenerateColumns .     
IsReadOnly . $��10q�51   L   $	��320��6X      Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 27 54      1  +System.Windows.Controls.DataGridBoundColumn   Binding 53   5   �� *
BREED_ID+54        55      $ Название��6)   $	 250 56       55   ;   �� *
BREED_name+56      4  .System.Windows.Controls.DataGridTemplateColumn  5:      $ 84 6-      CellTemplate 5;      �� 5<      .R�5=   "   ��  ��Name$ ButtonDeleteGrid��6)   -   5        $��Удалить��5=   C   
���   �
�������5?   ;   5@      5B        5C      $ 84 6-    5D      �� 5E      .R�5F   "   �� $ ButtonEditGrid��6)   -   5        $��Изменить��5F   A   
���   �
�������5H      5I      5K      5M      �� 5O      -   5        $ AddBtn��5O      $��Добавить��5P      #��[ 6   $	��500��6X   �� 5Q      -   5        $ 	UpdateBtn��5Q      $��Обновить��5R      #��[ 6   $	��500��6@   6L   5S      5T      5U      