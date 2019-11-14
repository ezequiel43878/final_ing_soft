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
using System.Data.OleDb;

namespace Parcial_Ing_Soft
{
    /// <summary>
    /// Lógica de interacción para listar2.xaml
    /// </summary>
    public partial class listar2 : Window

    {
        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=inmobiliaria_2018.accdb");

        CollectionViewSource dataTable1ViewSource;
        public listar2()
        {
            InitializeComponent();
        }
        String dato_tipo = null;
        String dato_situacion;
        String dato_zona = null;

        public listar2(String tipo, String situacion, String zona)
        {
            InitializeComponent();
            dato_tipo = tipo;
            dato_situacion = situacion;
            dato_zona = zona;
        }

        private void agregar_volver_atras(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window listar1 = new listar1();
            listar1.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Parcial_Ing_Soft.inmobiliaria_2018DataSet inmobiliaria_2018DataSet = ((Parcial_Ing_Soft.inmobiliaria_2018DataSet)(this.FindResource("inmobiliaria_2018DataSet")));
            // Cargar datos en la tabla DataTable1. Puede modificar este código según sea necesario.
            Parcial_Ing_Soft.inmobiliaria_2018DataSetTableAdapters.DataTable1TableAdapter inmobiliaria_2018DataSetDataTable1TableAdapter = new Parcial_Ing_Soft.inmobiliaria_2018DataSetTableAdapters.DataTable1TableAdapter();
           
           if (dato_tipo == "Todos" && dato_situacion == "Todos" && dato_zona == "Todos") {       //TODOS
                inmobiliaria_2018DataSetDataTable1TableAdapter.Fill(inmobiliaria_2018DataSet.DataTable1);
            }
            else if (dato_tipo == "Todos" && dato_situacion == "Todos" && dato_zona != "Todos")             //BARRIO 
            {
                inmobiliaria_2018DataSetDataTable1TableAdapter.Query(inmobiliaria_2018DataSet.DataTable1,dato_zona);         
            }
            else if (dato_tipo != "Todos" && dato_situacion == "Todos" && dato_zona != "Todos")             //BARRIO - TIPO
            {
                inmobiliaria_2018DataSetDataTable1TableAdapter.QueryTipBarrio(inmobiliaria_2018DataSet.DataTable1,dato_zona,dato_tipo);
            }
            else if (dato_tipo == "Todos" && dato_situacion != "Todos" && dato_zona != "Todos")             //BARRIO - SITUACION
            {
                inmobiliaria_2018DataSetDataTable1TableAdapter.QuerySitBarrio(inmobiliaria_2018DataSet.DataTable1,dato_situacion,dato_zona);
            }
            else if (dato_tipo == "Todos" && dato_situacion != "Todos" && dato_zona == "Todos")             // SITUACION
            {
                inmobiliaria_2018DataSetDataTable1TableAdapter.QuerySituacion(inmobiliaria_2018DataSet.DataTable1,dato_situacion);
            }
            else if (dato_tipo != "Todos" && dato_situacion != "Todos" && dato_zona == "Todos")             // SITUACION -TIPO
            {
                inmobiliaria_2018DataSetDataTable1TableAdapter.QuerySitTipo(inmobiliaria_2018DataSet.DataTable1,dato_tipo,dato_situacion);
            }
            else if (dato_tipo != "Todos" && dato_situacion == "Todos" && dato_zona == "Todos")             // TIPO
            {
                inmobiliaria_2018DataSetDataTable1TableAdapter.QueryTipo(inmobiliaria_2018DataSet.DataTable1, dato_tipo);
            }
            else if (dato_tipo != "Todos" && dato_situacion != "Todos" && dato_zona != "Todos")             // BARRIO - SITUACION - TIPO
            {
                inmobiliaria_2018DataSetDataTable1TableAdapter.QueryTodos(inmobiliaria_2018DataSet.DataTable1,dato_situacion,dato_tipo,dato_zona);
            }

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
            else if (sender == buttonPrevious)
            {
                dataTable1ViewSource.View.MoveCurrentToPrevious();
            }
            else if (sender == buttonNext)
            {
                dataTable1ViewSource.View.MoveCurrentToNext();
            }
            else if (sender == buttonLast)
             {
                dataTable1ViewSource.View.MoveCurrentToLast();
             }
        }

        private void cmb_tipo_loaded(object sender, RoutedEventArgs e)
        {   
          
        }

        private void cmb_tipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void guardar(object sender, RoutedEventArgs e)
        {
            inmobiliaria_2018DataSetTableAdapters.duenioTableAdapter inmobiliaria_2018DataSetduenioTableAdapter = new inmobiliaria_2018DataSetTableAdapters.duenioTableAdapter();
            inmobiliaria_2018DataSetduenioTableAdapter.ActualizarDuenio(nomb_duenioTextBox.Text,apellido_duenioTextBox.Text,int.Parse(telefono_duenioTextBox.Text),int.Parse(dni_duenioTextBox.Text));
            MessageBox.Show("Datos de dueño Actualizado");

            this.Hide();
            Window MainWindow = new MainWindow();
            MainWindow.Show();
        }

        private void agregar(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window agregar = new agregar_inmueble();
            agregar.Show();
        }
    }
}
