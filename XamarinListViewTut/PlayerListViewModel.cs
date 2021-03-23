using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace XamarinListViewTut
{
    class PlayerListViewModel
    {
        public ICommand AddEmployeeCommand => new Command(AddPlayer);
        public ICommand RemoveEmployeeCommand => new Command(RemovePlayer);
        public ICommand UpdateEmployeeCommand => new Command(UpdatePlayer);


        public ObservableCollection<string> Players { get; set; }


        public string PlayerName { get; set; }
        public string SelectedEmployee { get; set; }
        public string SelectedPlayer { get; set; }



        public PlayerListViewModel()
        {

            //string[] arrEmployees = new string[] { "batman", "superman", "wonderwoman" }; (sådan havde den normalt set ud hvis vi ikke brugte observablecollection)
            Players = new ObservableCollection<string>();
            Players.Add("Martin");
            Players.Add("Cherryl");
            Players.Add("Jimmy");


        }

        public void AddPlayer()
        {
            Players.Add(PlayerName);

        }

        public void RemovePlayer()
        {
            Players.Remove(SelectedEmployee);
        }

        public void UpdatePlayer()
        {

            int newIndex = Players.IndexOf(SelectedEmployee);
            Players.Remove(SelectedEmployee);

            Players.Add(PlayerName);
            int oldIndex = Players.IndexOf(PlayerName);

            Players.Move(oldIndex, newIndex);

        }
    }
}
