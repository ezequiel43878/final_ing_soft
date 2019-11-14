using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
    /// Lógica de interacción para agregar_inmueble2.xaml
    /// </summary>
    public partial class agregar_inmueble2 : Window
    {
        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=inmobiliaria_2018.accdb");

        public agregar_inmueble2()
        {
            InitializeComponent();
           
        }
        String dni_2 ;
        public agregar_inmueble2(String dni)
        {
            InitializeComponent();
            dni_2 = dni;
            //dni_duenioTextBox.Text = dni;

        }

        private void cmb_barrios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeComponent();
        }

        private void cmb_barrios_loaded(object sender, RoutedEventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from zona", connection);
            OleDbDataReader reader = command.ExecuteReader();
           
            if (reader != null)
           {
                while (reader.Read())
                {
                    cmb_barrios.Items.Add(reader["nombre_zona"].ToString());
                }
            }
            else
            {
               MessageBox.Show("sin datos");
            }
            
            connection.Close();

        }

        private void cmb_tipo_loaded(object sender, RoutedEventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from tipo", connection);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    cmb_tipo.Items.Add(reader["nombre_tipo"].ToString());
                }
            }
            else
            {
                MessageBox.Show("sin datos");
            }

            connection.Close();
        }

        private void cmb_tipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeComponent();
        }

        private void cmb_situacion_loaded(object sender, RoutedEventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from situacion where id_situacion in (1,2)", connection);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                   cmb_situacion.Items.Add(reader["nombre_situacion"].ToString());
                }
            }
            else
            {
                MessageBox.Show("sin datos");
            }

            connection.Close();
        }

        private void cmb_situacion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeComponent();
        }
       

        private void agregar(object sender, RoutedEventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from zona where nombre_zona = '" + cmb_barrios.Text + "'", connection);
            OleDbDataReader reader = command.ExecuteReader();
            String id_zona = null;
            while (reader.Read())
            {
                //cmb_barrios.Items.Add(reader["nombre_zona"].ToString());
                id_zona = reader["id_zona"].ToString();
            }

            connection.Close();

            connection.Open();
            OleDbCommand command2 = new OleDbCommand("select * from tipo where nombre_tipo = '" + cmb_tipo.Text + "'", connection);
            OleDbDataReader reader2 = command2.ExecuteReader();
            String id_tipo = null;
            while (reader2.Read())
            {
                //cmb_barrios.Items.Add(reader["nombre_zona"].ToString());
                id_tipo = reader2["id_tipo"].ToString();
            }

            connection.Close();

            connection.Open();
            OleDbCommand command3 = new OleDbCommand("select * from situacion where nombre_situacion = '" + cmb_situacion.Text + "'", connection);
            OleDbDataReader reader3 = command3.ExecuteReader();
            String id_situacion = null;
            while (reader3.Read())
            {
                //cmb_barrios.Items.Add(reader["nombre_zona"].ToString());
                id_situacion = reader3["id_situacion"].ToString();
            }

            connection.Close();

            inmobiliaria_2018DataSetTableAdapters.inmuebleTableAdapter inmobiliaria_2018DataSetinmuebleTableAdapter = new inmobiliaria_2018DataSetTableAdapters.inmuebleTableAdapter();
            //inmobiliaria_2018DataSetduenioTableAdapter.insertar_duenio(dni, nomb_duenioTextBox.Text, apellido_duenioTextBox.Text, telefono);
            inmobiliaria_2018DataSetinmuebleTableAdapter.insertar_inmueble(calleTextBox.Text, int.Parse(alturaTextBox.Text), int.Parse(pisoTextBox.Text), numeroTextBox.Text, int.Parse(precioTextBox.Text), int.Parse(dni_2), int.Parse(id_situacion), int.Parse(id_tipo), int.Parse(id_zona));

            MessageBox.Show("Se agrego correctamente");


            
            this.Hide();
            Window MainWindow = new MainWindow();
            MainWindow.Show();
            //Window prueba = new prueba();
            //prueba.Show();
            
        }
    }
 
}
