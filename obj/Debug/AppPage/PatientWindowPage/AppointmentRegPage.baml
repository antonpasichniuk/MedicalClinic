   M S B A M L   `   `   `  ����H  DMedicalClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:MedicalClinic.AppPage.PatientWindowPage'MedicalClinic.AppPage.PatientWindowPage  5      @    :MedicalClinic.AppPage.PatientWindowPage.AppointmentRegPage   5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:MedicalClinic.AppPage.PatientWindowPage     5        N� Title$  AppointmentPage��5
      .��5      � .+�5   
   �� -   5         ��Name$ 
ErrorState��5      $A��;На жаль, неможливо зробити запис��5      $��Center=�5      $��Center=�5      $��30(�5      $
��Bold"�5      $y�Hidden=�5      �� 5   
   -   5         ��Name$ 	WorkState��5      .��5      �� $��20q�6   .+�5      �� $��0 0 0 20q�6   $��
Запис��5      $��27(�5      $
��Bold"�5      �� 5      $	��400��6   .+�5      �� -   5         ��Name$ SpecialityBlock��5   !   .+�5      �� $.��(Виберіть спеціаліста:��6    $��15(�5       $
��0 10q�5       �� 5      -   5         ��Name$ SpecialitiesField��5   #   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Спеціаліст��5    #   $
��0 10q�5!   #   5#      5$      �� 5%      -   5        $ 	MainBlock��5%   !   {�.  .+�5'      �� $$��Виберіть лікаря:��6    $��15(�5(       $
��0 10q�5)       �� 5*      -   5        $ DoctorsField��5*   #   $ 
Лікар��5+   #   ��5-      �� 5.   "   .R�5/   &   �  � ColumnDefinitions 50   *   �� 51   .   $��1* �6?   �� 52   .   $��2* �6?   .+�54   *   �� $��0��60   $	��120��56   0   ��55   0   �� *PhotoOfUser+56   0   �� 57   *    �� Orientation$ 
Horizontal=�65   $��Center=�58   5   $��Center=�59   5   $��1��5:   5   $��30 0 0 0q�5;   5   .+�5<   .   �� $��17(�5=   4   ��5<   4   �� *	Surname+5=   4   �� 5>   .   $��17(�5?   4   ��5>   4   �� *Name+5?   4   5@   +   5A   '   5B   #   5D      �� 5E      -   5        $ DTPickersBlock��5E   %   $y�Hidden=�5F   %   {�.  .+�5H      �� $1��+Коментар (необов'яково):��6$   $��15(�5I       $
��0 10q�5J       �� 5K      -   5         ��Name$ DescriptionOfAppointment��5K   &    *  &MaterialDesignOutlinedTextFieldTextBox#��[  5L   "   	 �� TextWrapping$
	 Wrap=�5M   "   $	��100��5N   "   
 �� 	MaxLength$	
 100��5O   "   $	��250��5P   "   $
��Left=�5Q   "   $��14(�5R   "   �� 5S      $/��)Виберіть дату прийому:��6$   $��15(�5T       $
��0 10q�5U       (  "System.Windows.Controls.DatePicker  5V      -	   5          Name$ DateOfAppointment��5V   )   $	��120��5W   )   $
��Left=�5X   )   $ Оберіть дату��5Y   )    � Language$ uk-UA�5Z   )      IsTodayHighlighted .  5\   )   �� 5]      -
   5        $ TimeOfAppointmentField��5]   )   $y�Hidden=�5^   )   {�.  .+�5`   "   �� $-��'Виберіть час прийому:��6(   $��15(�5a   (   $
��0 10q�5b   (   �� 5c   "   -   5        $ TimeOfAppointment��5c   +   $ Оберіть час��5d   #   $	��120��5e   #   $
��Left=�5f   #   5g   #   5h      �� 5i      -   5         ��Name$ ErrorTimeApplointment��5i   $   $M��GНажаль, на цей день немає вільних мість��5j   $   $��15(�5k   $   $
��Bold"�5l   $   $y�Hidden=�5m   $   {�.  5n   $   5o      5p      �� 5q      -   5         ��Name$ ConfirmAppointmentButton��5q      $��Записатись��5s      $	��0 5q�5t      $	��200��5u      $y�Hidden=�5v      {�.  5w      5x      5y      5z      5{      5|      