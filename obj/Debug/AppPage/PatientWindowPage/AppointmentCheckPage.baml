   M S B A M L   `   `   `  ����H  DMedicalClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:MedicalClinic.AppPage.PatientWindowPage'MedicalClinic.AppPage.PatientWindowPage  5      B    <MedicalClinic.AppPage.PatientWindowPage.AppointmentCheckPage   5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:MedicalClinic.AppPage.PatientWindowPage     5        N� Title$  CheckAppointment��5
      .��5      � .+�5   
   �� .��5      �� -   5         ��Name$ AppointmentsTable��5      $��10 20q�5      $	��800��5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Appointments��5         AlternatingRowBackground
 �����   CanUserAddRows .     AutoGenerateColumns .     Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 5   1      CanUserResize .  1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5   1   �� 
 �� Path$
 
IsSelected�5   1   0  *System.Windows.Controls.DataGridTextColumn  5         Header$ Ім'я лікаря��5   %      
IsReadOnly . 	 5   -   �� $
 NameOfDoctor�5   %     5      $ 
Лікар��5   %    . 	 5   -   �� $
 SpeciallityOfDoctor�5   %     5      $ Опис��5    %    . 	 5   -   �� $
 Description�5!   %     5"      $ Дата зустрічі��5#   %    . 	 5"   -   �� $
 DateOfMeeting�5$   %   5&      �� 5'      -   5        $'��!Відмінити зустріч��5'      $	��200��5(      $
��0 20q�5)      5*      5+      5,      �� 5-   
   -   5         ��Name$ ErrorAppointments��5-      $��Center=�5.      $��Center=�5/      $��30(�50      $
��Bold"�51      $;��5У вас немає записів до лікаря��52      53      54      