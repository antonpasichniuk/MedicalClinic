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
    /// Interaction logic for ConclusionResultWindow.xaml
    /// </summary>
    public partial class ConclusionResultWindow : Window
    {
        public int appointmentId { get; private set; }

        public ConclusionResultWindow(int appointmentId)
        {
            InitializeComponent();

            this.appointmentId = appointmentId;

            FillConclusion();
        }

        private void FillConclusion()
        {
            using (var context = new MedicalClinicContext())
            {
                var conclusion = context.Conclusion.FirstOrDefault(conc => conc.AppointmentId == appointmentId);

                Complaints.Text = conclusion.Сomplaints;

                Allergy.IsChecked = conclusion.Anamnesis.Allergy;
                CHD.IsChecked = conclusion.Anamnesis.CHD;
                Convulsion.IsChecked = conclusion.Anamnesis.Convulsions;
                Diabetes.IsChecked = conclusion.Anamnesis.Diabetes;
                Onco.IsChecked = conclusion.Anamnesis.Onco;

                BodyTemperature.Text = $"{conclusion.Examination.BodyTemperature} ℃";
                BloodPresure.Text = conclusion.Examination.BloodPressure;
                Pulse.Text = conclusion.Examination.Pulse.ToString();
                RespiratoryRate.Text = conclusion.Examination.RespiratoryRate.ToString();

                AdditionalInfo.Text = conclusion.AdditionalInfo == null ? "Відсутні" : conclusion.AdditionalInfo;
                ConclusionResult.Text = conclusion.ConclusionResult;
            }
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
