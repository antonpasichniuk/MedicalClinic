   M S B A M L   `   `   `  ����H  DMedicalClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MedicalClinic.WindowsMedicalClinic.Windows  5   	   .    (MedicalClinic.Windows.ShowPatientsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MedicalClinic.Windows     5   	     � Title$  ShowPatientsWindow��5   	   $	��450��6$   $	��700��61    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   �� .��5      �� $��20q�6   .+�5      �� $��Ім'я лікаря:��6   $��16(�5      $
��Bold"�5      �� 5      -   5         ��Name$ NameOfDoctor��5      $��14(�5      $��15q�5      �� 5      $!��Спеціальність:��6   $��16(�5      $
��Bold"�5      �� 5      -   5        $ DoctorsSpeciality��5      $��14(�5      $��15q�5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ Patients��5         AlternatingRowBackground
 �����   CanUserAddRows .     AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn
   Header$
 Ім'я пацієнта��5!   %      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5    -   ��  �� Path$ NameOfPatient�5"   %     5#      $!
 Номер телефону��5$   %    .  5#   -   �� $ PhoneNumber�5%   %     5&      $
 Дата зустрічі��5'   %    .  5&   -   �� $ DateOfMeeting�5(   %   5*      �� 5+      -   5        $	��200��5+      $��10q�5,      $��Center=�5-      $��
Назад��5.      5/      50      51      52      53      