using MedicalClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MedicalClinic.Windows
{
    /// <summary>
    /// Interaction logic for ConclusionAddWindow.xaml
    /// </summary>
    public partial class ConclusionAddWindow : Window
    {
        public int appointmentId { get; private set; }

        public ConclusionAddWindow(int appointmentId)
        {
            InitializeComponent();

            this.appointmentId = appointmentId;
        }

        private void AcceptClick(object sender, RoutedEventArgs e)
        {
            string complaints = Complaints.Text;

            bool allergy = (bool)Allergy.IsChecked;
            bool chd = (bool)CHD.IsChecked;
            bool convulsion = (bool)Convulsion.IsChecked;
            bool diabetes = (bool)Diabetes.IsChecked;
            bool onco = (bool)Onco.IsChecked;

            double bodyTemperature = BodyTemperature.Value;
            string bloodPressure = $"{(int)HighPressure.Value}/{(int)LowPresure.Value}";
            int pulse = (int)Pulse.Value;
            int respiratoryRate = (int)RespiratoryRate.Value;

            string additionalInfo = AdditionalInfo.Text;

            string conclusionResult = ConclusionResult.Text;

            string message = CheckValues(complaints, conclusionResult);

            if (String.IsNullOrEmpty(message))
            {
                AddConclusion(complaints,
                              allergy, chd, convulsion, diabetes, onco,
                              bodyTemperature, bloodPressure, pulse, respiratoryRate,
                              additionalInfo,
                              conclusionResult);
                MessageBox.Show("Заключення було успішно створено");
                Close();
            }
            else{
                MessageBox.Show(message);
            }
        }

        private string CheckValues(string complaints, string conclusionResult)
        {
            string message = "";

            if (String.IsNullOrWhiteSpace(complaints))
            {
                message = "Поле зі скаргами повинно бути заповнено";
            }
            else if (String.IsNullOrWhiteSpace(conclusionResult))
            {
                message = "Призначення повинно бути заповнено";
            }

            return message;
        }

        private void AddConclusion(string complaits,
                                   bool allergy, bool chd, bool convulsion, bool diabetes, bool onco,
                                   double bodyTemperature, string bloodPressure, int pulse, int respiratoryRate,
                                   string additionalInfo,
                                   string conclusionResult)
        {
            using (var context = new MedicalClinicContext())
            {
                Anamnesis anamnesis = new Anamnesis();
                anamnesis.Allergy = allergy;
                anamnesis.CHD = chd;
                anamnesis.Convulsions = convulsion;
                anamnesis.Diabetes = diabetes;
                anamnesis.Onco = onco;

                Examination examination = new Examination();
                examination.BodyTemperature = bodyTemperature;
                examination.BloodPressure = bloodPressure;
                examination.Pulse = pulse;
                examination.RespiratoryRate = respiratoryRate;

                Conclusion conclusion = new Conclusion();
                int medcardId = context.Appointment.FirstOrDefault(app => app.Id == appointmentId).Patient.Medcard.Id;
                conclusion.MedcardId = medcardId;
                conclusion.AppointmentId = appointmentId;
                conclusion.Сomplaints = complaits;
                conclusion.AnamnesisId = anamnesis.Id;
                conclusion.ExaminationId = examination.Id;
                conclusion.AdditionalInfo = additionalInfo;
                conclusion.ConclusionResult = conclusionResult;

                conclusion.Anamnesis = anamnesis;
                conclusion.Examination = examination;

                context.Conclusion.Add(conclusion);
                context.SaveChanges();
            }
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }        
    }
}
