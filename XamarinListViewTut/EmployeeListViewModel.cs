using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinListViewTut

{
    class EmployeeListViewModel
    {
        public ICommand AddEmployeeCommand => new Command(AddEmployee);
        public ICommand RemoveEmployeeCommand => new Command(RemoveEmployee);
        public ICommand UpdateEmployeeCommand => new Command(UpdateEmployee);


        public ObservableCollection<string> Employees { get; set; }


        public string EmployeeName { get; set; }

        public string SelectedEmployee { get; set; }



        public EmployeeListViewModel()
        {

            //string[] arrEmployees = new string[] { "batman", "superman", "wonderwoman" }; (sådan havde den normalt set ud hvis vi ikke brugte observablecollection)
            Employees = new ObservableCollection<string>();
            Employees.Add("batman");
            Employees.Add("wonderwoman");
            Employees.Add("superman");
            


        }

        public void AddEmployee()
        {
            Employees.Add(EmployeeName);

        }

        public void RemoveEmployee()
        {
            Employees.Remove(SelectedEmployee);
        }

        public void UpdateEmployee()
        {

            int newIndex = Employees.IndexOf(SelectedEmployee);
            Employees.Remove(SelectedEmployee);

            Employees.Add(EmployeeName);
            int oldIndex = Employees.IndexOf(EmployeeName);

            Employees.Move(oldIndex, newIndex);

        }

    }
}
