   M S B A M L   `   `   `  ����G  CHorseClubApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HorseClubApp.Views.AddHorseClubApp.Views.Add  5   	   +    %HorseClubApp.Views.Add.AddBreedWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:HorseClubApp.Views.Add     5   	     � Title$  AddBreedWindow��5   	    � WindowStartupLocation$ CenterScreen=�6     � WindowStyle$
 None=�6E   
���   �$	��500��6k   $	��200��6w    � 	Resources 5	         BoldWhiteText �� 
TargetType �� Property �� Value  CustomButtonStyle �� 
TargetType ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName  CustomTextBoxStyle��%8  &	        &	 �     &	 7    �� 5
   
   " ��6&   .�5      ��  � ��$ 20(�6)   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�64   �� 5       � ��$ Consolas)�6+   5      �� 5   
   " ��6*   .�5      ��  � ��$ 0,15,0,0q�6'   �� 5       � ��$ 40��6'   �� 5       � ��
 �   �6+   �� 5       � ��
 �����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Consolas)�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��6[   $��1q�6�   ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5       P� 5!      
 � �� . . �5"   "   �� $ border��6)    � �� �#3333336S   5#      5%      5'      5(      �� 5+   
   " ��6+   .�5,      ��  � ��
 �����6+   �� 5-       � ��
 �   �6+   �� 5.       � ��
 �����6,   �� 5/       � ��$ 1q�60   �� 50       � ��$ 0,15,0,0q�6'   51      52      .��53      � .+�54   
   �� -   5         ��Name$ MainSP��54       �� Orientation$ 
Horizontal=�6%   $��Center=�6>   $��Center=�6Y   .+�55      �� -   5        $	 sp1��55      $��
0,10,20,10q�6&   $��Center=�6;   .+�57      �� $#��Название породы��6   #��[  6/   �� 58      -   5         ��Name$ breednameTextBox��58      #��[ 64   $	��200��6|   ��6`   �� *
BREED_name+6|   5;      �� 5=      -   5        $ 	ButtonsSP��5=      $	��150��6,   $��Center=�68   $��Center=�6U   .+�5?      �� -   5         ��Name$ AddBtn��5?      $��Добавить��5@   	   #��[ 6   6G   �� 5A      -   5        $ BackBtn��5A      $��Закрыть��5B      #��[ 6   6>   5C      5D      5E      5F      