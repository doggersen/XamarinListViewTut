using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinListViewTut
{
    class AddOrEditAdvancedEmployeeViewModel
    {
        public Employee Employee { get; set; }

        public AddOrEditAdvancedEmployeeViewModel()
        {
            Employee = new Employee();
        }
    }
}
