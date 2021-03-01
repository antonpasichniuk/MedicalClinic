using MedicalClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedicalClinic.AppPage.ManagerWindowPage
{
    /// <summary>
    /// Interaction logic for SignOutPage.xaml
    /// </summary>
    public partial class PatientRegPage : Page
    {
        public PatientRegPage()
        {
            InitializeComponent();

            PageInitialState();
        }

        private void PageInitialState()
        {
            DateText.DisplayDateStart = DateTime.Now.AddYears(-100);
            DateText.DisplayDateEnd = DateTime.Now;
        }

        public void RegClick(object sender, RoutedEventArgs e)
        {
            string login = LoginText.Text.Trim();
            string pass = PassText.Password.Trim();
            string passRep = PassRepText.Password.Trim();
            string name = NameText.Text.Trim();
            string surname = SurnameText.Text.Trim();
            string sex = SexText.Text;
            DateTime? date = DateText.SelectedDate;
            string email = EmailText.Text.Trim();
            string phone = PhoneText.Text.Trim();

            string message = CheckRegValues(login, pass, passRep, name, surname, sex, date, email, phone);
            if (!String.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
            }
            else
            {
                AddPatient(login, pass, name, surname, sex, date, email, phone);
                MessageBox.Show("Реєстрація пройшла успішно");
                ClearAllFields();
            }
        }

        private void ClearAllFields()
        {
            LoginText.Text = null;
            PassText.Password = null;
            PassRepText.Password = null;
            NameText.Text = null;
            SurnameText.Text = null;
            SexText.Text = null;
            DateText.SelectedDate = null;
            EmailText.Text = null;
            PhoneText.Text = null;
        }

        private void AddPatient(string login, string pass, string name, string surname, string sex, DateTime? date, string email, string phone)
        {
            using (MedicalClinicContext context = new MedicalClinicContext())
            {
                Patient patient = new Patient();

                PersonalData patientPersonalData = new PersonalData();
                patientPersonalData.Name = name;
                patientPersonalData.Surname = surname;
                patientPersonalData.Sex = sex;
                patientPersonalData.DateOfBirth = (DateTime)date;
                patientPersonalData.Email = email;
                patientPersonalData.PhoneNumber = phone;

                context.PersonalData.Add(patientPersonalData);
                context.SaveChanges();

                User patientUser = new User();
                patientUser.Login = login;
                patientUser.Password = pass;

                context.User.Add(patientUser);
                context.SaveChanges();

                Medcard patientMedcard = new Medcard();

                context.Medcard.Add(patientMedcard);
                context.SaveChanges();

                patient.Medcard = patientMedcard;
                patient.User = patientUser;
                patient.PersonalData = patientPersonalData;

                patient.MedcardId = patientMedcard.Id;
                patient.UserId = patientUser.Id;
                patient.PersonalData.Id = patientPersonalData.Id;

                context.Patient.Add(patient);
                context.SaveChanges();
            }
        }

        private string CheckRegValues(string login, string pass, string passRep, string name, string surname, string sex, DateTime? date, string email, string phone)
        {
            string message = "";

            Regex ukrSymbRegex = new Regex("^[А-Яа-яёЁЇїІіЄєҐґ]+$");
            Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Regex loginSybmRegex = new Regex(@"^[a-zA-Z0-9]+$");

            if (login.Length < 8 || login.Length > 20)
                message = "В логіні має бути 8 або більше символів";
            else if (!loginSybmRegex.IsMatch(login))
                message = "Логін має містити лише латинські літери та цифри";
            else if (IsLoginAlreadyExists(login))
                message = "Такий логін вже існує. Придумайте новий";
            else if (pass.Length < 8 || pass.Length > 20)
                message = "В паролі має бути 8 або більше символів";
            else if (!loginSybmRegex.IsMatch(pass))
                message = "Пароль має містити лише латинські літери та цифри";
            else if (passRep != pass)
                message = "Повторення паролю не співпадає з паролем";
            else if (name.Length == 0)
                message = "Поле з іменем порожнє";
            else if (!ukrSymbRegex.IsMatch(name))
                message = "Ім'я повинно містити лише українські літери";
            else if (name.Length > 25)
                message = "Ім'я повинно бути менше 25 символів";
            else if (pass.Length == 0)
                message = "Поле з прізвищем порожнє";
            else if (!ukrSymbRegex.IsMatch(surname))
                message = "Прізвище повинно містити лише українські літери";
            else if (surname.Length > 40)
                message = "Прізвище повинно бути менше 40 символів";
            else if (sex.Length == 0)
                message = "Стать не вибрана";
            else if (date == null)
                message = "Дата народження не вибрана";
            else if (!emailRegex.IsMatch(email))
                message = "Email невірно вказаний";
            else if (IsEmailAlreadyExists(email))
                message = "Такий email вже був зареєстрований";
            else if (phone.Length == 0 || phone.Length < 10)
                message = "Номер неправильно записаний";
            else if (IsPhoneAlreadyExists(phone))
                message = "Такий номер вже зареєстрований";
            return message;
        }

        private bool IsLoginAlreadyExists(string login)
        {
            using (MedicalClinicContext context = new MedicalClinicContext())
            {
                return context.User.Any(user => user.Login == login);
            }
        }

        private bool IsEmailAlreadyExists(string email)
        {
            using (MedicalClinicContext context = new MedicalClinicContext())
            {
                return context.PersonalData.Any(user => user.Email == email);
            }
        }

        private bool IsPhoneAlreadyExists(string phone)
        {
            using (MedicalClinicContext context = new MedicalClinicContext())
            {
                return context.PersonalData.Any(user => user.PhoneNumber == phone);
            }
        }

        private void PhoneTextPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
