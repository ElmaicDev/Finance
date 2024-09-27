using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Model;

namespace PrimerAPP_WPF.ViewModel
{

    public class VMDía: INotifyPropertyChanged
    {
        
        private ObservableCollection<Variables> _dias;
        public ObservableCollection<Variables> Dias
        {
            get { return _dias; }
            set 
            { 
                _dias = value;
                OnPropertyChanged(nameof(Dias));
            }
        }

        private Variables _nuevoDia;
        public Variables NuevoDia
        {
            get { return _nuevoDia; }
            set {
                _nuevoDia = value;
                OnPropertyChanged(nameof(NuevoDia));
            }
        }

        //private DateTime _fecha;
        //public DateTime Fecha
        //{
        //    get { return Fecha; }
        //    set
        //    {
        //        if (_fecha != value)
        //        {
        //            _fecha = value;
        //            OnPropertyChanged(nameof(Fecha));
        //        }
        //    }
        //}

        private string _categoria;
        public string Categoria 
        {
            get { return _categoria; }
            set
            {
                if (_categoria != value)
                {
                    _categoria = value;
                    OnPropertyChanged(nameof(Categoria));
                }
            }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                if (_descripcion != value)
                {
                    _descripcion = value;
                    OnPropertyChanged(nameof(Descripcion));
                }
            }
        }

        private float _ingresos;
        public float Ingresos
        {
            get { return _ingresos; }
            set
            {
                if (_ingresos != value)
                {
                    _ingresos = value;
                    OnPropertyChanged(nameof(Ingresos));
                }
            }
        }

        private float _egresos;
        public float Egresos
        {
            get { return _egresos; }
            set
            {
                if (_egresos != value)
                {
                    _egresos = value;
                    OnPropertyChanged(nameof(Egresos));
                }
            }
        }

        private string _metodoPago;
        public string MetodoPago
        {
            get { return _metodoPago;}
            set
            {
                if (_metodoPago != value)
                {
                    _metodoPago = value;
                    OnPropertyChanged(nameof(MetodoPago));
                }
            }
        }

        private bool _isDGvisible;
        public bool IsDGVisible
        {
            get { return _isDGvisible; }
            set
            {
                if (_isDGvisible != value)
                {
                    _isDGvisible = value;
                    OnPropertyChanged(nameof(IsDGVisible));
                }
            }
        }

       
        public  ICommand CommandAddDia { get; }
        public bool IsPlotVisible => !IsDGVisible;

         

        public VMDía()
        {
            CommandAddDia = new CommandHandler(CrearDía);
            Dias = new ObservableCollection<Variables> ();
            
            
        }
        private void CrearDía()
        {

            IsDGVisible = true;
            //dia.Fecha = Fecha;
            NuevoDia = new Variables();
            NuevoDia.Ingresos = Ingresos;
            NuevoDia.Egresos = Egresos;
            NuevoDia.Categoria = Categoria;
            NuevoDia.Descripcion = Descripcion;

            Dias.Add(NuevoDia);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
