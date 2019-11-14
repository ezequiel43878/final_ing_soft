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
    /// Lógica de interacción para listar1.xaml
    /// </summary>
    public partial class listar1 : Window
    {
        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=inmobiliaria_2018.accdb");

        public listar1()
        {
            InitializeComponent();
        }

        private void agregar_volver_atras(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window ventana_menu = new MainWindow();
            ventana_menu.Show();
        }

        private void cmb_situacion_loaded(object sender, RoutedEventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from situacion", connection);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader != null)
            {
                cmb_situacion.Items.Add("Todos");
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

        }

        private void cmb_tipo_loaded(object sender, RoutedEventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from tipo", connection);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader != null)
            {
                cmb_tipo.Items.Add("Todos");
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

        }

        private void cmb_barrios_loaded(object sender, RoutedEventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from zona", connection);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader != null)
            {
                cmb_barrios.Items.Add("Todos");
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

        private void cmb_barrios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void consulta(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_situacion.Text))
            {

                MessageBox.Show("Debe completar el campo: SITUACION");

                return;

            }
            else if (string.IsNullOrEmpty(cmb_tipo.Text))
            {
                MessageBox.Show("Debe completar el campo: TIPO DE INMUEBLE");

                return;
            }
            else if (string.IsNullOrEmpty(cmb_barrios.Text))
            {
                MessageBox.Show("Debe completar el campo: BARRIO");

                return;
            }
            else
            {
                String situacion = cmb_situacion.Text;
                String tipo = cmb_tipo.Text;
                String zona = cmb_barrios.Text;

                this.Hide();
                Window listar2 = new listar2(tipo,situacion,zona);
                listar2.Show();
            }
        }

      
    }
}
