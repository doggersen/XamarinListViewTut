using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinListViewTut
{



    class PlayerListViewModel : BaseViewModel
    {
        public ICommand AddPlayerCommand => new Command(AddPlayer);
        public ICommand RemovePlayerCommand => new Command(RemovePlayer);
        public ICommand UpdatePlayerCommand => new Command(UpdatePlayer);
        public ICommand ShowCivilStatusCommand => new Command(ShowCivilStatus);

        public class PlayerData
        {
            public string PlayerName { get; set; }
            public string CivilStatus { get; set; }

        }



        public ObservableCollection<PlayerData> Players { get; set; }


        public string PlayerName { get; set; }

        public PlayerData SelectedPlayer { get; set; }

        private string _civilStatus;
        public string CivilStatus
        {
            get { return _civilStatus; }
            set
            {
                _civilStatus = value;
                OnPropertyChanged();
            }
        }
        public PlayerListViewModel()
        {

            //string[] arrEmployees = new string[] { "batman", "superman", "wonderwoman" }; (sådan havde den normalt set ud hvis vi ikke brugte observablecollection)
            Players = new ObservableCollection<PlayerData>();
            PlayerData martin = new PlayerData();
            PlayerData cherryl = new PlayerData();
            PlayerData jimmy = new PlayerData();
            martin.CivilStatus = "married";
            cherryl.CivilStatus = "also married";
            jimmy.CivilStatus = "single";
            cherryl.PlayerName = "Cherryl";
            jimmy.PlayerName = "jimmy";
            martin.PlayerName = "martin";
            Players.Add(cherryl);
            Players.Add(martin);
            Players.Add(jimmy);

            PlayerData testPlayer = new PlayerData();
            testPlayer.PlayerName = "Johannes";
            testPlayer.CivilStatus = "single";
            Players.Add(testPlayer);

        }

        public void ShowCivilStatus()
        {

            CivilStatus = SelectedPlayer.CivilStatus;

        }

        public void AddPlayer()
        {
            //  Players.Add(PlayerName);

        }

        public void RemovePlayer()
        {
            Players.Remove(SelectedPlayer);
        }

        public void UpdatePlayer()
        {

            //int newIndex = Players.IndexOf(SelectedPlayer);
            //Players.Remove(SelectedPlayer);

            // Players.Add(PlayerName);
            //            int oldIndex = Players.IndexOf(PlayerName);

            //          Players.Move(oldIndex, newIndex);

        }
    }
}
