using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lippert_József_modulzáró
{
    public class Patient : BaseModel
    {
        string _name;
        string _bplace;
        int _bdate;
        private object patient;

        

       

        public string Name { get { return _name; } set { _name = value; OnPropertyChange(); } }
        public string Bplace { get { return _bplace; } set { _bplace = value; OnPropertyChange(); } }
        public int Bdate { get { return _bdate; } set { _bdate = value; OnPropertyChange(); } }


        public Patient()
        {

        }

    }

}
