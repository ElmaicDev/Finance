using System;
using System.Collections.Generic;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;


namespace Class1
{


    public class Graficas
    {

        public List<float> Dinero { get;  set; }
        public List<DateTime> Fechas { get;  set; }

        public Graficas(List<float> dinero, List<DateTime> fechas)
        {
            this.Dinero = dinero;
            
            this.Fechas = fechas;

        }

        public SeriesCollection Graficar()
        {


            List<DateTime> listDias = new List<DateTime>();
            List<float> listIng = new List<float>();


            foreach (var fech in Fechas)
            {

                listDias.Add(fech);
            }
            foreach (var ing in Dinero)
            {

                listIng.Add(ing);
            }


            var valores = new ChartValues<ObservablePoint>();
            for (int i = 0; i < listDias.Count; i++)
            {
                if (valores == null)
                {
                    valores.Add(new ObservablePoint(0, 0));
                }
                else
                {

                    valores.Add(new ObservablePoint(listDias[i].Day, listIng[i]));
                }
            }



            SeriesCollection series = new SeriesCollection();

         


            series.Add(new LineSeries
            {
                Title ="Gasto",
                Values = valores
            });
        

            return series;
        }
    }
}