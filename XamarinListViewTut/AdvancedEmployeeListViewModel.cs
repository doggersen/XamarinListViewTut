﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinListViewTut
{
    class AdvancedEmployeeListViewModel
    {
        //public ICommand AddEmployeeCommand => new Command(AddEmployee);
        //public ICommand RemoveEmployeeCommand => new Command(RemoveEmployee);
        //public ICommand UpdateEmployeeCommand => new Command(UpdateEmployee);


        public ObservableCollection<Employee> Employees { get; set; }


        public string EmployeeName { get; set; }

        public string SelectedEmployee { get; set; }



        public AdvancedEmployeeListViewModel()
        {

            //string[] arrEmployees = new string[] { "batman", "superman", "wonderwoman" }; (sådan havde den normalt set ud hvis vi ikke brugte observablecollection)
            Employees = new ObservableCollection<Employee>();

            //Employees.Add("batman");
            //Employees.Add("wonderwoman");
            //Employees.Add("superman");

            Employees.Add(new Employee(1, "Finn Hansen", "Infrastructure", "img1.jpg"));
            Employees.Add(new Employee(2, "Tom Cruise", "Fliselægger", "img2.jpg"));
            Employees.Add(new Employee(3, "Pia Poulsen", "Administrationen", "img3.jpg"));
            Employees.Add(new Employee(4, "Martin", "Lærling", "img4.jpg"));
            Employees.Add(new Employee(5, "Ole B", "Bossen", "img5.jpg"));
            Employees.Add(new Employee(6, "Jørgen Mondrup", "Infrastructure", "img6.jpg"));

        }

        public void AddEmployee()
        {
            // Employees.Add(EmployeeName);

        }

        public void RemoveEmployee()
        {
            //Employees.Remove(SelectedEmployee);
        }

        public void UpdateEmployee()
        {

            //int newIndex = Employees.IndexOf(SelectedEmployee);
            //Employees.Remove(SelectedEmployee);

            //Employees.Add(EmployeeName);
            //int oldIndex = Employees.IndexOf(EmployeeName);

            //Employees.Move(oldIndex, newIndex);

        }

    }

}
