using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lippert_József_modulzáró
{
    public class Context
    {
        
            public List<PatientData> Patients { get; } = new List<PatientData>
            {
                new PatientData{Name="Kis Jenő", },
                new PatientData{Name="Nagy Gábor",},
                new PatientData{Name="Lapos Elemér",},
                new PatientData{Name="Barack Obama",}
            };
        public List<PatientData> Purchases { get; }

        public Context()
        {
            Patients = new List<PatientData>
            {
                new PatientData
                {

                    Patients = new List<PatientData>
                    {
                        Patients[0]
                    }
                }
            };
        }
    }
}
