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
        
        private string _visResultat;
        public string VisResultat
        {
            get { return _visResultat; }
            set
            {
                _visResultat = value;
                OnPropertyChanged();
            }
        }

        public void KaldVisResultat()        
        {
            VisResultat = $"{UdfyldtFormel} = {Resultat}";             
        }

        public void FormelFase1()
        {         
            UdfyldtFormel = $"(5 + {InputX}) / {InputY}";
            Resultat = (5 + Convert.ToDouble(InputX)) / Convert.ToDouble(InputY);
            KaldVisResultat();
        }

        public void FormelFase2()
        {
            UdfyldtFormel = $"PI * {InputX} + {InputY}";
            Resultat = (Math.PI * Convert.ToDouble(InputX)) + Convert.ToDouble(InputY);
            KaldVisResultat();
        }

        public void FormelFase3()
        {
            UdfyldtFormel = $"{InputX} opløftet til {InputY}. potens";
            Resultat = Math.Pow((Convert.ToDouble(InputX)), Convert.ToDouble(InputY));
            KaldVisResultat();
        }
    }
}
