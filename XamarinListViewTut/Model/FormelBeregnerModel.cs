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
        public ICommand FormelFase2Command => new Command(FormelFase2);
        public ICommand FormelFase3Command => new Command(FormelFase3);
        public ICommand DisplayResultCommand => new Command(DisplayResult);



        private string _formel;
        public string Formel
        {
            get { return _formel; }
            set
            {
                _formel = value;
                OnPropertyChanged();
            }
        }

        private string _udfyldtFormel;
        public string UdfyldtFormel
        {
            get { return _udfyldtFormel; }
            set
            {
                _udfyldtFormel = value;
                OnPropertyChanged();
            }
        }

        private double _inputX;
        public double InputX
        {
            get { return _inputX; }
            set
            {
                _inputX = value;
                OnPropertyChanged();
            }
        }

        private double _inputY;
        public double InputY
        {
            get { return _inputY; }
            set
            {
                _inputY = value;
                OnPropertyChanged();
            }
        }
        private double _resultat;
        public double Resultat
        {
            get { return _resultat; }
            set
            {
                _resultat = value;
                OnPropertyChanged();
            }
        }

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

        public void DisplayResult()        
        {
            DisplayMessage = $"{UdfyldtFormel} = {Resultat}";             
        }

        public void FormelFase1()
        {         
            Formel = "(5 + X) / Y";
            UdfyldtFormel = $"(5 + {InputX} / {InputY}";
            Resultat = (5 + Convert.ToDouble(InputX)) / Convert.ToDouble(InputY);
            DisplayResult();
        }

        public void FormelFase2()
        {
            Formel = "PI * X + Y";
            UdfyldtFormel = $"(PI * {InputX} + {InputY}";
            Resultat = (Math.PI * Convert.ToDouble(InputX)) + Convert.ToDouble(InputY);
            DisplayResult();
        }

        public void FormelFase3()
        {
            Formel = "X opløftet til Y potens";
            UdfyldtFormel = $"{InputX} opløftet til {InputY}. potens";
            Resultat = Math.Pow((Convert.ToDouble(InputX)), Convert.ToDouble(InputY));
            DisplayResult();
        }
    }
}
