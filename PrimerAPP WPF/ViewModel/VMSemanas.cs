using PrimerAPP_WPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerAPP_WPF.ViewModel
{
    public class VMSemanas : INotifyPropertyChanged
    {

        List<VMDia> dias = new List<VMDia>();
        




        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
