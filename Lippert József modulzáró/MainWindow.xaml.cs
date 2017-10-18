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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Lippert_József_modulzáró
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainWindow _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainWindowModel
            {

            };
            DataContext = _vm;
        }

        private IEnumerable<object> Patient()
        {
            throw new NotImplementedException();
        }

        private void NewPatient(object sender, RoutedEventArgs e)
        {
            PatientData viewModel = new PatientData(new Patient()) { IsNew = true };
            PatientData patientForm = new PatientData { DataContext = viewModel };
            patientForm.ShowDialog();
            var patientList = _vm.PatientList;
            if (patientForm.DialogResult == true)
            
                patientList.Add(viewModel.Patient);
            
        }
    }
}
