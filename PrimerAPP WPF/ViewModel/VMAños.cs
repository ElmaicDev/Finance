using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerAPP_WPF.ViewModel
{
    public class VMAños : INotifyPropertyChanged
    {


        List<VMMeses> meses = new List<VMMeses>();
        List<VMDía>  dias = new List<VMDía>();
        List<VMSemanas> semanas = new List<VMSemanas>();




        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
