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
using System.Windows.Shapes;

namespace PrimerAPP_WPF
{
    /// <summary>
    /// Lógica de interacción para Pagos.xaml
    /// </summary>
    public partial class Pagos : Window
    {
        public Pagos()
        {
            InitializeComponent();
            DP_FechaFin.Visibility = Visibility.Hidden;
            DP_FechaIni.Visibility = Visibility.Hidden;
            LB_FechaFin.Visibility = Visibility.Hidden;
            LB_FechaIni.Visibility = Visibility.Hidden;
            LB_Cuota.Visibility = Visibility.Hidden;
            TB_Cuota.Visibility = Visibility.Hidden;
        }

        private void CB_Tipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


          

            ComboBoxItem itemSelected = CB_Tipo.SelectedItem as ComboBoxItem;

            if (itemSelected.Content.ToString() == "Abonar")
            {
                List<ComboBoxItem>  items = new List<ComboBoxItem> { new ComboBoxItem { Content = "Intereses" }, new ComboBoxItem { Content = "Capital" } };
                CB_Por.ItemsSource = null;
                CB_Por.ItemsSource = items;
            }
            else if(itemSelected.Content.ToString() == "Crear")
            {
                List<ComboBoxItem> items1 = new List<ComboBoxItem> { new ComboBoxItem { Content = "Fecha" }, new ComboBoxItem { Content = "Cuotas" } };
                CB_Por.ItemsSource = null;
                CB_Por.ItemsSource = items1;
                
            }
            
          
        }

        private void CB_Por_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            ComboBoxItem itemSelected = CB_Por.SelectedItem as ComboBoxItem;

            if (itemSelected.Content.ToString() == "Fecha")
            {
                DP_FechaFin.Visibility = Visibility.Visible;
                DP_FechaIni.Visibility = Visibility.Visible;
                LB_FechaFin.Visibility = Visibility.Visible;
                LB_FechaIni.Visibility = Visibility.Visible;
                LB_Cuota.Visibility = Visibility.Hidden;
                TB_Cuota.Visibility = Visibility.Hidden;
            }
            else if (itemSelected.Content.ToString() == "Cuotas")
            {
                DP_FechaIni.Visibility = Visibility.Visible;
                LB_FechaIni.Visibility = Visibility.Visible;
                LB_Cuota.Visibility = Visibility.Visible;
                TB_Cuota.Visibility = Visibility.Visible;
                DP_FechaFin.Visibility = Visibility.Hidden;
                LB_FechaFin.Visibility = Visibility.Hidden;
            }
        }
    }
}
