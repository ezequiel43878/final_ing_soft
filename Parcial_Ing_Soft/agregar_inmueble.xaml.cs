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
    /// Lógica de interacción para agregar_inmueble.xaml
    /// </summary>
    public partial class agregar_inmueble : Window
    {
        public agregar_inmueble()
        {
            InitializeComponent();
        }

        private void agregar_volver_atras(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window ventana_menu = new MainWindow();
            ventana_menu.Show();
        }

        private void agregar_duenio(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(dni_duenioTextBox.Text))
            {

                MessageBox.Show("Debe completar el campo: DNI");

                return;

            }
            else if (string.IsNullOrEmpty(nomb_duenioTextBox.Text))
            {
                MessageBox.Show("Debe completar el campo: NOMBRE");

                return;
            }
            else if (string.IsNullOrEmpty(apellido_duenioTextBox.Text))
            {
                MessageBox.Show("Debe completar el campo: APELLIDO");

                return;
            }
            else if (string.IsNullOrEmpty(telefono_duenioTextBox.Text))
            {
                MessageBox.Show("Debe completar el campo: TELEFONO");

                return;
            }
            else
            {
                // inmobiliaria_2018DataSet inmobiliaria_2018DataSet = ((inmobiliaria_2018DataSet)(this.FindResource)("inmobiliaria_2018DataSet"));
                int dni = int.Parse(dni_duenioTextBox.Text);
                int telefono = int.Parse(telefono_duenioTextBox.Text);
                inmobiliaria_2018DataSetTableAdapters.duenioTableAdapter inmobiliaria_2018DataSetduenioTableAdapter = new inmobiliaria_2018DataSetTableAdapters.duenioTableAdapter();
                inmobiliaria_2018DataSetduenioTableAdapter.insertar_duenio(dni, nomb_duenioTextBox.Text, apellido_duenioTextBox.Text, telefono);

                this.Hide();
                
                Window agregar_inmueble2 = new agregar_inmueble2(dni.ToString());
                agregar_inmueble2.Show();
            }
        }
    }
}
