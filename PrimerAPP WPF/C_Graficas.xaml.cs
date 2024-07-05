using Class1;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrimerAPP_WPF
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    /// 
 

    public partial class UserControl1 : UserControl //, INotifyPropertyChanged
    {


        List<Variables> list = new List<Variables>();
        


        //private SeriesCollection _series;
        public SeriesCollection Series { get; set; }
        //{
            //get { return _series; }
            //set
            //{
                //_series = value;
                //OnPropertyChanged(nameof(Series));
            //}
        //}



        public UserControl1()
        {
            InitializeComponent();

            infoListasString();
            DataContext = this;
        }



        public void infoListasString()
        {

            list = MainWindow.filtro;

            List<DateTime> fechas = new List<DateTime>();
            List<float> dinero = new List<float>();
          

            foreach (var fi in list)
            {
                fechas.Add(fi.Fecha);
                dinero.Add(fi.Ingresos);
                
            }
            

            Graficas g1 = new Graficas(dinero, fechas);
            Series = g1.Graficar();

            
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
