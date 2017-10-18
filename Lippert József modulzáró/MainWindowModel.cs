using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Lippert_József_modulzáró
{
    public class MainWindowModel : BaseModel
    {
        public ObservableCollection<Patient> PatientList { get; set; }
        public Patient SelectProduct { get; set; }
        
        public MainWindowModel()
        {
            PatientList = new ObservableCollection<Patient>();
            var ctx = new Context();
            foreach (var patient in ctx.Patients)
            {
                PatientList.Add(new Patient(patient));
            }
        }
        
    }
}
