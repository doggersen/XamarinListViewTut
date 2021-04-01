using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinListViewTut.Model
{
    class FormelBeregnerModel : BaseViewModel
    {
        public ICommand FormelFase1Command => new Command(FormelFase1);

        public string Formel { get; set; }
        public double InputX { get; set; }
        //{
        //    get
        //    {
        //        return Convert.ToString InputX.ToString();
        //    }

        //    set
        //    {

        //        InputX = Convert.ToDouble(value);
        //    }
        //}

        public double InputY { get; set; }
        public double Resultat { get; set; }

        private string _displayMessage;
        public string DisplayMessage
        {
            get { return _displayMessage; }
            set
            {
                _displayMessage = value;
                OnPropertyChanged();
            }
        }



        public void Submit()
        {
            DisplayMessage = $"Formel : {Formel} inputtet af x : {InputX}"
                                    + $"Resultat : {Resultat.ToString()}";
        }

        public void TestFunktion()
        {

        }

        public void FormelFase1()
        {
            Formel = "(5 + X) / Y";
            Resultat = (5 + InputX) / 2;
            Submit();
        }

        //public void FormelFase1 (double inputX = 0, double inputY = 0)
        //{
        //    inputX = InputX;
        //    inputY = InputY;
        //    Formel = "(5 + X) / Y";
        //    Resultat = (5 + inputX) / inputY;
        //}

        public void FormelFase2(double inputX, double inputY)
        {

        }

        public void FormelFase3(double inputX, double inputY)
        {

        }
    }
}
