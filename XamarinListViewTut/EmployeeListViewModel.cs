using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;

namespace XamarinListViewTut

{
    class EmployeeListViewModel
    {
        public string[] Employees { get; set; }
        
        public EmployeeListViewModel()
        {
            

            string[] arrEmployees = new string[] { "batman", "superman", "wonderwoman" };
            Employees = arrEmployees;
        }


    }
}
