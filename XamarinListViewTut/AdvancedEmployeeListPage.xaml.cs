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
    public partial class AdvancedEmployeeListPage : ContentPage
    {
        public AdvancedEmployeeListPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddOrEditAdvancedEmployeePage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)

        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;

            Employee employee = ((EmployeeListViewModel)BindingContext).Employees.Where(emp => emp.EmployeeId == (int)tappedEventArgs.Parameter).FirstOrDefault();

            Navigation.PushAsync(new AddOrEditAdvancedEmployeePage());
        }
    }
}