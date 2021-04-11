using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinListViewTut
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddOrEditAdvancedEmployeePage : ContentPage
    {
        public AddOrEditAdvancedEmployeePage(Employee employee = null)
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //making a variable called "employee" of type "Employee", and assigning it ....to what exactly?
            Employee employee = ((AddOrEditAdvancedEmployeeViewModel)BindingContext).Employee;

            if (employee.EmployeeId == 0)
            {
                employee.PictureUrl = "img7.jpg";
            }

            MessagingCenter.Send(this, "AddOrEditAdvancedEmployee", employee);

            Navigation.PopAsync();
        }
    }
}