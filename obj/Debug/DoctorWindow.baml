   M S B A M L   `   `   `  ����H  DMedicalClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MedicalClinicMedicalClinic  5   	        MedicalClinic.DoctorWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:MedicalClinic     5   	     � Title$  
UserWindow��5   	   $	��600��6   $
��1000��6)   $	��500��5	   	   $	��900��6    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � 
�������.+�5   
   �  � ColumnDefinitions 5      �� 5      $	��260 �6#   �� 5      .+�5      ��  �� Padding$ 20q�6   $��5q�5      
������� �� CornerRadius$ 10��5      $��0��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6'      Color$ 	SlateGray��5   '      ShadowDepth$ 0Q�5   '   ._�5      �� .+�5      �� $��0 0 0 20q�6    $��Меню лікаря��5       $��27(�5       $
��Bold"�5       �� 5       -   5        $��Особисті дані��5       $	��0 5q�5!      5"      �� 5#      -   5        $!��Журнал записів��5#      $	��0 5q�5$      5%      �� 5&      -   5        $��
Вихід��5&      $	��0 5q�5'      5(      5)      5*      �� 5+      $ 20q�5,      $��5q�5-      
�������$ 10��5/      $��1��50       51        52      $ 30Q�6'   $ 	SlateGray��53   #   $ 0Q�54   #   ._�56       � -   5        	  �Name$	 	UserFrame��56      
  � NavigationUIVisibility$
 Hidden=�6+   57      58      59      5:      