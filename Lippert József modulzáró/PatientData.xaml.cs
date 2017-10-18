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

namespace Lippert_József_modulzáró
{
    /// <summary>
    /// Interaction logic for PatientData.xaml
    /// </summary>
    public partial class PatientData : BaseModel
    {
       

        public Patient Patient { get; set; }
        public bool IsNew { get; set; }
        
        Patient patient;
        public PatientData(Patient Patient)
        {
            this.Patient = Patient;
            if (!IsNew)
                Save();
        }

        public bool PatientValidate()
        {
            return !string.IsNullOrEmpty(Patient.Name) && Patient.Name.Length > 3 && Patient.Bplace.Length >0 && Patient.Bdate >= 0;
        }

        public void Save()
        {
            if (!IsNew)
                patient = new Patient { Name = Patient.Name, Bplace = Patient.Bplace, Bdate = Patient.Bdate };
        }

        public void OriginalValue()
        {
            Patient.Name = patient.Name;
            Patient.Bplace = patient.Bplace;
            Patient.Bdate = patient.Bdate;
        }
    }
        
    
}
