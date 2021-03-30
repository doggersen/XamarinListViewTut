using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinListViewTut
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string Name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }


        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged(string propertyname)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        //}

    }
}
