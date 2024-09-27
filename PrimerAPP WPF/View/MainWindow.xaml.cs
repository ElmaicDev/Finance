using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Model;
using Dynamitey.DynamicObjects;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using PrimerAPP_WPF.ViewModel;


namespace PrimerAPP_WPF.View
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        int contfilas = 0;

        public static List<Variables> filas1 = new List<Variables>();

        List<Variables> filas = new List<Variables>();

        public static List<Variables> filtro = new List<Variables>();

        ObservableCollection<string> itemsCBAnos = new ObservableCollection<string>();

        
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new VMDía();
            

            //LlenarCB();
           

        }

      

        
    }
}
