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
using Class1;
using Dynamitey.DynamicObjects;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;


namespace PrimerAPP_WPF
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

            #region TESTEAR CON VALORES EN EL DATA GRID.
            //Variables f1 = new Variables { Ind = 1, Fecha = new DateTime(2023, 03, 24), Categoria = "Casa", Descripcion = "Canilla nueva", Egresos = 20000, Ingresos = 0, MetodoPago = "Transferencia" };
            //Variables f2 = new Variables { Ind = 2, Fecha = new DateTime(2023, 03, 25), Categoria = "Mercado", Descripcion = "Canilla nueva", Egresos = 3000, Ingresos = 0, MetodoPago = "Transferencia" };
            //Variables f3 = new Variables { Ind = 3, Fecha = new DateTime(2023, 03, 26), Categoria = "Salud", Descripcion = "Canilla nueva", Egresos = 0, Ingresos = 5000, MetodoPago = "Transferencia" };
            //Variables f4 = new Variables { Ind = 4, Fecha = new DateTime(2023, 03, 27), Categoria = "Moto", Descripcion = "Canilla nueva", Egresos = 0, Ingresos = 2000, MetodoPago = "Transferencia" };
            //Variables f5 = new Variables { Ind = 5, Fecha = new DateTime(2023, 03, 28), Categoria = "Transporte", Descripcion = "Canilla nueva", Egresos = 520000, Ingresos = 0, MetodoPago = "Transferencia" };
            //Variables f6 = new Variables { Ind = 6, Fecha = new DateTime(2023, 03, 29), Categoria = "Servicios", Descripcion = "Canilla nueva", Egresos = 0, Ingresos = 3000, MetodoPago = "Transferencia" };
            //Variables f7 = new Variables { Ind = 7, Fecha = new DateTime(2023, 03, 30), Categoria = "Cuidado Personal", Descripcion = "Motilada", Egresos = 17000, Ingresos = 0, MetodoPago = "Transferencia" };




            //filas.Add(f1);
            //filas.Add(f2);
            //filas.Add(f3);
            //filas.Add(f4);
            //filas.Add(f5);
            //filas.Add(f6);
            //filas.Add(f7);

            //DG.ItemsSource = filas;

            #endregion

            LlenarCB();
           

        }

        public void LlenarCB()
        {
            DG.Visibility = Visibility.Hidden;
            DP_Fecha.SelectedDate = DateTime.Now;
            CB_GCategoria.Visibility = Visibility.Hidden;
            CB_Meses.Visibility = Visibility.Hidden;
            CB_Años.Visibility = Visibility.Hidden;
            LB_GCategoria.Visibility = Visibility.Hidden;
            LB_Meses.Visibility = Visibility.Hidden;
            LB_Años.Visibility = Visibility.Hidden;
            BT_Filrto.Visibility = Visibility.Hidden;


            var itemsCateg = new List<string>();

            CB_Categoria.ItemsSource = Enum.GetValues(typeof(eCategorias)).Cast<eCategorias>().Select(x => x.ToString().Replace("_", " "));
            CB_Meses.ItemsSource = Enum.GetValues(typeof(eMeses));

            itemsCateg.AddRange(Enum.GetValues(typeof(eCategorias)).Cast<eCategorias>().Select(x => x.ToString().Replace("_", " ")));

            CB_GCategoria.ItemsSource = itemsCateg;
            itemsCateg.Add("Ingreso");
            itemsCateg.Add("Egreso");
            



        }
 
        private void LlenarDG()
        {
            
            Variables fila = new Variables();
            fila.Ind = contfilas;
            fila.Fecha = DP_Fecha.SelectedDate.Value;
            fila.Categoria = CB_Categoria.Text;
            fila.Descripcion = TB_Descripción.Text;

            if (CB_IngEgre.Text == "Ingreso")
            {
                fila.Ingresos = float.Parse(TB_Valor.Text);
                fila.Egresos = 0f;
            }
            else if (CB_IngEgre.Text == "Egreso")
            {
                fila.Egresos = float.Parse(TB_Valor.Text);
                fila.Ingresos = 0f;
            }

            fila.MetodoPago = CB_MetodoPago.Text;
 

            filas.Add(fila);   
            filas1.Add(fila);
        }
        


        private void BT_Archivo_Click(object sender, RoutedEventArgs e)
        {
            BT_Archivo.ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            BT_Archivo.ContextMenu.PlacementTarget = BT_Archivo;
            BT_Archivo.ContextMenu.IsOpen = true;
        }
        private void BT_Agregar_Click(object sender, RoutedEventArgs e)
        {
            contfilas++;
            
            LlenarDG();
            DG.ItemsSource = null;
            DG.ItemsSource = filas;
            DG.Visibility = Visibility.Visible;
            CB_GCategoria.Visibility = Visibility.Hidden;
            CB_Meses.Visibility = Visibility.Hidden;
            CB_Años.Visibility = Visibility.Hidden;
            LB_GCategoria.Visibility = Visibility.Hidden;
            LB_Meses.Visibility = Visibility.Hidden;
            LB_Años.Visibility = Visibility.Hidden;
            G_ControlGrafica.Visibility = Visibility.Hidden;
            BT_Filrto.Visibility = Visibility.Hidden;
            

            if (filas != null & filas.Count > 0)
            {
                foreach (var obj in filas)
                {
                    if (!itemsCBAnos.Contains(obj.Fecha.Year.ToString())) 
                    {
                        itemsCBAnos.Add(obj.Fecha.Year.ToString());
                    }
                    

                }
            }


            
            CB_Años.ItemsSource = itemsCBAnos;

        }


        private void CB_Plan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBoxItem selectedItem = CB_Plan.SelectedItem as ComboBoxItem;

            if(selectedItem.Content.ToString() == "Pagos")
            {
                Pagos pagos = new Pagos();
                pagos.Show();
                
            }
            else if (selectedItem.Content.ToString() == "Ahorros")
            {
                Ahorros ahorros = new Ahorros();
                ahorros.Show();
            }
            else if(selectedItem.Content.ToString() == "Inversiones")
            {
                Inversiones inversiones = new Inversiones();
                inversiones.Show();
            }
        }

        private void BT_VerGrafica_Click(object sender, RoutedEventArgs e)
        {
            CB_GCategoria.Visibility = Visibility.Visible;
            CB_Meses.Visibility = Visibility.Visible;
            CB_Años.Visibility = Visibility.Visible;
            LB_GCategoria.Visibility = Visibility.Visible;
            LB_Meses.Visibility = Visibility.Visible;
            LB_Años.Visibility = Visibility.Visible;
            DG.Visibility = Visibility.Hidden;

            UserControl1 UserControl1 = new UserControl1();
            G_ControlGrafica.Children.Add(UserControl1);
            G_ControlGrafica.Visibility = Visibility.Visible;
            BT_Filrto.Visibility = Visibility.Visible;


        }

        private void CB_GCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            filtro.Clear();
        }

        private void BT_Filrto_Click(object sender, RoutedEventArgs e)
        {
            filtro.Clear();
            #region MESES DEL AÑO
            string mes = "";

            switch (CB_Meses.Text)
            {
                case "Enero":
                    mes = "1";
                    break;

                case "Febrero":
                    mes = "2";
                    break;

                case "Marzo":
                    mes = "3";
                    break;

                case "Abril":
                    mes = "4";
                    break;

                case "Mayo":
                    mes = "5";
                    break;

                case "Junio":
                    mes = "6";
                    break;

                case "Julio":
                    mes = "7";
                    break;

                case "Agosto":
                    mes = "8";
                    break;
                case "Septiembre":
                    mes = "9";
                    break;

                case "Octubre":
                    mes = "10";
                    break;

                case "Noviembre":
                    mes = "11";
                    break;

                case "Diciembre":
                    mes = "12";
                    break;
            }

            #endregion

            if (CB_GCategoria.SelectedItem.ToString() != "Ingreso" && CB_GCategoria.SelectedItem.ToString() != "Egreso" )
            {
                filtro.AddRange(filas.Where(x => x.Fecha.Month.ToString() == mes && x.Fecha.Year.ToString() == CB_Años.Text.ToString() && (x.Categoria == CB_GCategoria.SelectedItem.ToString())));

            }
            else
            {
                filtro.AddRange(filas.Where(x => x.Fecha.Month.ToString() == mes && x.Fecha.Year.ToString() == CB_Años.Text.ToString() && (  CB_GCategoria.SelectedItem.ToString() == "Ingreso" || CB_GCategoria.SelectedItem.ToString() == "Egreso")));
            }
            UserControl1 UserControl1 = new UserControl1();
            G_ControlGrafica.Children.Add(UserControl1);
        }



    }
}
