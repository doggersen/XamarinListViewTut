using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinListViewTut
{
    class AddOrEditAdvancedEmployeeViewModel
    {
        //this is a property. it always have get set. 
        public Employee Employee { get; set; }

        
        public AddOrEditAdvancedEmployeeViewModel()
        {
            Employee = new Employee();

            
        }
    }
}
