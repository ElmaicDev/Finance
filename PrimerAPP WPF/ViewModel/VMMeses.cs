using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerAPP_WPF.ViewModel
{
    public class VMMeses: INotifyPropertyChanged
    {


        List<VMDia> dias = new List<VMDia>();
        List<VMSemanas> semanas = new List<VMSemanas>();




        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            var a = 10200f;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
