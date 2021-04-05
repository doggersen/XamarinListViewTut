using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinListViewTut
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string PictureUrl { get; set; }
        public string CivilStatus { get; set; }

        public Employee(int employeeId, string employeeName, string designation, string pictureUrl, string civilStatus)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Designation = designation;
            PictureUrl = pictureUrl;
            CivilStatus = civilStatus;
        }

        //with this second constructor the above arguments are no longer required when creating a new Employee object
        public Employee()
        {

        }
    }
}
