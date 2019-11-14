using System;
using System.Collections.Generic;
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

namespace Parcial_Ing_Soft
{
    /// <summary>
    /// Lógica de interacción para prueba.xaml
    /// </summary>
    public partial class prueba : Window
    {
        CollectionViewSource dataTable1ViewSource;
        public prueba()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Parcial_Ing_Soft.inmobiliaria_2018DataSet inmobiliaria_2018DataSet = ((Parcial_Ing_Soft.inmobiliaria_2018DataSet)(this.FindResource("inmobiliaria_2018DataSet")));
            // Cargar datos en la tabla duenio. Puede modificar este código según sea necesario.
            Parcial_Ing_Soft.inmobiliaria_2018DataSetTableAdapters.duenioTableAdapter inmobiliaria_2018DataSetduenioTableAdapter = new Parcial_Ing_Soft.inmobiliaria_2018DataSetTableAdapters.duenioTableAdapter();
            inmobiliaria_2018DataSetduenioTableAdapter.Fill(inmobiliaria_2018DataSet.duenio);
            System.Windows.Data.CollectionViewSource duenioViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("duenioViewSource")));
            duenioViewSource.View.MoveCurrentToFirst();

            // Cargar datos en la tabla inmueble. Puede modificar este código según sea necesario.
            Parcial_Ing_Soft.inmobiliaria_2018DataSetTableAdapters.inmuebleTableAdapter inmobiliaria_2018DataSetinmuebleTableAdapter = new Parcial_Ing_Soft.inmobiliaria_2018DataSetTableAdapters.inmuebleTableAdapter();
            inmobiliaria_2018DataSetinmuebleTableAdapter.Fill(inmobiliaria_2018DataSet.inmueble);
            System.Windows.Data.CollectionViewSource inmuebleViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("inmuebleViewSource")));
            inmuebleViewSource.View.MoveCurrentToFirst();

            // Cargar datos en la tabla DataTable1. Puede modificar este código según sea necesario.
            Parcial_Ing_Soft.inmobiliaria_2018DataSetTableAdapters.DataTable1TableAdapter inmobiliaria_2018DataSetDataTable1TableAdapter = new Parcial_Ing_Soft.inmobiliaria_2018DataSetTableAdapters.DataTable1TableAdapter();
            //inmobiliaria_2018DataSetDataTable1TableAdapter.Fill(inmobiliaria_2018DataSet.DataTable1);
            //inmobiliaria_2018DataSetDataTable1TableAdapter.Query(inmobiliaria_2018DataSet.DataTable1, "ALMAGRO");
            inmobiliaria_2018DataSetDataTable1TableAdapter.QuerySituacion(inmobiliaria_2018DataSet.DataTable1, "En Venta");
            System.Windows.Data.CollectionViewSource dataTable1ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("dataTable1ViewSource")));
            //dataTable1ViewSource.View.MoveCurrentToFirst();
            Button_Click(buttonFirst, new RoutedEventArgs());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataTable1ViewSource = ((CollectionViewSource)(this.FindResource("dataTable1ViewSource")));
            if (sender == buttonFirst)
            {
                dataTable1ViewSource.View.MoveCurrentToFirst();
            }
            else if (sender==buttonPrevious)
            {
                dataTable1ViewSource.View.MoveCurrentToPrevious();
            }
            else if (sender == buttonNext)
            {
                dataTable1ViewSource.View.MoveCurrentToNext();
            }
           /* else if (sender == buttonLast)
            {
                tblpersonasViewSource.View.MoveCurrentToLast();
            }*/
            /*else if (sender == buttonRefresh)
            {
                personasDataSet personasDataSet = ((personasDataSet)(this.FindResource("personasDataSet")));
                CollectionViewSource.GetDefaultView(personasDataSet).Refresh();
            }*/
            //TextboxCurrent.Text = tblpersonasViewSource.View.CurrentPosition.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
